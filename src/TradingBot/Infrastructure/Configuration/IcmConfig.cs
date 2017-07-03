﻿using TradingBot.Common.Configuration;

namespace TradingBot.Infrastructure.Configuration
{
    public class IcmConfig : IExchangeConfiguration
    {
        public bool Enabled { get; set; }
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public string[] Instruments { get; set; }

        public RabbitMqConfiguration RabbitMq { get; set; }
    }
}