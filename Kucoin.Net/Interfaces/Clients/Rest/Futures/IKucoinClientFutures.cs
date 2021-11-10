﻿using CryptoExchange.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kucoin.Net.Interfaces.Clients.Rest.Spot
{
    public interface IKucoinClientFutures : IRestClient
    {
        /// <summary>
        /// Set the API key and secret
        /// </summary>
        /// <param name="apiKey">The api key</param>
        /// <param name="apiSecret">The api secret</param>
        /// <param name="apiPass">The api passphrase</param>
        void SetApiCredentials(string apiKey, string apiSecret, string apiPass);

        IKucoinClientFuturesAccount Account { get; }
        IKucoinClientFuturesExchangeData ExchangeData { get; }
        IKucoinClientFuturesTrading Trading { get; }
    }
}