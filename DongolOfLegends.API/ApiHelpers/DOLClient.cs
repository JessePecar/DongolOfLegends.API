﻿using DongolOfLegends.API.ApiHelpers.Contracts;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DongolOfLegends.API.ApiHelpers
{
    public class DOLClient : HttpClient, IClient
    {
        private readonly IHttpClientFactory _factory;
        private readonly IConfiguration _configuration;
        public DOLClient(IHttpClientFactory factory, IConfiguration configuration)
        {
            _factory = factory;
            _configuration = configuration;
        }

        private HttpClient GetClient() => _factory.CreateClient();


        private HttpRequestMessage GetRequest(string requestUrl)
        {
            HttpRequestMessage message = new HttpRequestMessage()
            {
                RequestUri = new Uri(requestUrl),
                Method = HttpMethod.Get
            };

            message.Headers.Add(_configuration["Riot:Api:TokenHeader"], _configuration["Riot:Api:DeveloperKey"]);

            return message;
        }

        private HttpRequestMessage PostRequest<T>(string requestUrl, T postObject)
        {
            string postContent = JsonConvert.SerializeObject(postObject);
            HttpRequestMessage message = new HttpRequestMessage()
            {
                RequestUri = new Uri(requestUrl),
                Method = HttpMethod.Post,
                Content = new StringContent(postContent)
            };

            message.Headers.Add(_configuration["Riot:Api:TokenHeader"], _configuration["Riot:Api:DeveloperKey"]);

            return message;
        }

        public T GetRequestForItem<T>(string requestUrl)
        {
            HttpRequestMessage request = GetRequest(requestUrl);
            HttpResponseMessage response = GetClient().Send(request);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
            return default;
        }
        public List<T> GetRequestForList<T>(string requestUrl)
        {
            HttpRequestMessage request = GetRequest(requestUrl);
            HttpResponseMessage response = GetClient().Send(request);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
            return default;
        }


    }
}