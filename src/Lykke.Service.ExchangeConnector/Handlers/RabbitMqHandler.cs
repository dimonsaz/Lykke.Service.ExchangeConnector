﻿using System.Threading.Tasks;
using Common.Log;
using Lykke.RabbitMqBroker.Subscriber;
using Lykke.RabbitMqBroker.Publisher;
using TradingBot.Trading;

namespace TradingBot.Handlers
{
    public class RabbitMqHandler<T> : Handler<T>
    {
        private readonly RabbitMqPublisher<T> _rabbitPublisher;

        public RabbitMqHandler(string connectionString, string exchangeName, bool durable = false)
        {
            var publisherSettings = new RabbitMqSubscriptionSettings()
            {
                ConnectionString = connectionString,
                ExchangeName = exchangeName,
                IsDurable = durable
            };

            _rabbitPublisher = new RabbitMqPublisher<T>(publisherSettings)
                .DisableInMemoryQueuePersistence()
                .SetSerializer(new GenericRabbitModelConverter<T>())
                .SetLogger(new LogToConsole())
                .SetPublishStrategy(new DefaultFanoutPublishStrategy(publisherSettings))
                .SetConsole(new LogToConsole())
                .PublishSynchronously()
                .Start();
        }

        public override Task Handle(T message)
        {
            return _rabbitPublisher.ProduceAsync(message);
        }
    }
}