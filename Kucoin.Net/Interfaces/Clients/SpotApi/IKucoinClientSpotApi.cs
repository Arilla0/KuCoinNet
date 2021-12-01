﻿using System;

namespace Kucoin.Net.Interfaces.Clients.SpotApi
{
    /// <summary>
    /// Client for accessing the Kucoin Spot API. 
    /// </summary>
    public interface IKucoinClientSpotApi : IDisposable
    {
        /// <summary>
        /// Endpoints related to account settings, info or actions
        /// </summary>
        IKucoinClientSpotApiAccount Account { get; }

        /// <summary>
        /// Endpoints related to retrieving market and system data
        /// </summary>
        IKucoinClientSpotApiExchangeData ExchangeData { get; }

        /// <summary>
        /// Endpoints related to orders and trades
        /// </summary>
        IKucoinClientSpotApiTrading Trading { get; }
    }
}