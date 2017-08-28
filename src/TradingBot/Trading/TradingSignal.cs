﻿using System;
using Newtonsoft.Json;

namespace TradingBot.Trading
{
    public enum SignalType
    {
        Long,
        Short
    }

    public enum OrderType
    {
        Market,
        Limit
    }

    public enum TradeType
    {
        Buy,
        Sell
    }

    public enum OrderCommand
    {
        Create,
        Edit,
        Cancel
    }

    public enum TimeInForce
    {
        GoodTillCancel,
        FillOrKill
    }

    public class TradingSignal
    {
        [JsonConstructor]
        public TradingSignal(string orderId, OrderCommand command, TradeType tradeType, decimal price, decimal volume, DateTime time, 
            OrderType orderType = OrderType.Market,
            TimeInForce timeInForce = TimeInForce.FillOrKill)
        {
            OrderId = orderId;
            Command = command;
            
            TradeType = tradeType;
            Price = price;
            Volume = volume;
            Time = time;
            OrderType = orderType;
            TimeInForce = timeInForce;

            Type = tradeType == TradeType.Sell ? SignalType.Short : SignalType.Long;
        }
        
        public DateTime Time { get; }

        public SignalType Type { get; }
        
        public OrderType OrderType { get; }
        
        public TradeType TradeType { get; }
        
        public TimeInForce TimeInForce { get; }
        
        public decimal Price { get; }

        public decimal Volume { get; }
        
        public string OrderId { get; }
        
        public OrderCommand Command { get; }

        public override string ToString()
        {
            return $"Id: {OrderId}, Command: {Command}, Type: {Type}, Price: {Price}, Count: {Volume}";
        }

        public bool Equals(TradingSignal another)
        {
            return
                TradeType == another.TradeType &&
                Price == another.Price &&
                Volume == another.Volume &&
                OrderType == another.OrderType;
        }
    }
}
