﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Common;
using Common.Log;
using Newtonsoft.Json;
using TradingBot.Exchanges.Concrete.BitMEX.WebSocketClient;
using TradingBot.Exchanges.Concrete.BitMEX.WebSocketClient.Model;
using TradingBot.Handlers;
using TradingBot.Infrastructure.Configuration;
using TradingBot.Trading;
using Action = TradingBot.Exchanges.Concrete.BitMEX.WebSocketClient.Model.Action;

namespace TradingBot.Exchanges.Concrete.BitMEX
{
    internal class BitMexPriceHarvester : IStartable, IStopable
    {
        private readonly IBitmexSocketSubscriber _socketSubscriber;
        private readonly ILog _log;
        private readonly BitMexModelConverter _mapper;
        private readonly IHandler<TickPrice> _tickPriceHandler;

        public BitMexPriceHarvester(
            BitMexExchangeConfiguration configuration,
            IBitmexSocketSubscriber socketSubscriber,
            ILog log, IHandler<TickPrice> tickPriceHandler)
        {
            _socketSubscriber = socketSubscriber;
            _log = log;
            _tickPriceHandler = tickPriceHandler;
            _mapper = new BitMexModelConverter(configuration.SupportedCurrencySymbols, BitMexExchange.Name);
        }

        private async Task HandleResponseAsync(TableResponse table)
        {
            if (_tickPriceHandler == null)
            {
                throw new InvalidOperationException("Tick price handler is not set.");
            }

            if (!ValidateQuote(table))
            {
                await _log.WriteWarningAsync(nameof(BitMexPriceHarvester), nameof(HandleResponseAsync),
                    $"Ignoring invalid 'quote' message: '{JsonConvert.SerializeObject(table)}'");
                return;
            }

            if (table.Action == Action.Insert)
            {
                var prices = table.Data.Select(q => _mapper.QuoteToModel(q));
                foreach (var price in prices)
                {
                    await _tickPriceHandler.Handle(price);
                }
            }
        }

        private bool ValidateQuote(TableResponse table)
        {
            return table != null
                   && table.Data != null
                   && table.Data.All(item => item.AskPrice.HasValue && item.BidPrice.HasValue);
        }

        public void Start()
        {
            _socketSubscriber.Subscribe(BitmexTopic.quote, HandleResponseAsync);
            _socketSubscriber.Start();

        }

        public void Dispose()
        {
            Stop();
        }

        public void Stop()
        {
            _socketSubscriber.Stop();
        }
    }
}
