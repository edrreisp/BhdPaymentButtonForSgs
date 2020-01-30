using System;
using System.Threading.Tasks;
using BhdPaymentButtonForSgs.Enums;
using BhdPaymentButtonForSgs.Infrastructure.Dtos;
using BhdPaymentButtonForSgs.Infrastructure.ObjectsForBhd;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace BhdPaymentButtonForSgs.Services
{
    public class BhdPaymentButtonService:IBhdPaymentButtonService
    {
        readonly IConfiguration _configuration;
        public BhdPaymentButtonService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetKeyByRestaurant(RestaurantType restaurantType, string key)
        {
            string restaurantName = restaurantType.ToString();
            return _configuration[$"BhdPaymentButtonInfo:{restaurantName}:{key}"];
        }
        public async Task<BhdPaymentButtonResponse> PayWithBhdButton(BhdPaymentButtonApiDto dto)
        {
            var client = new RestClient(_configuration["BhdService"]);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new BhdPaymentButtonRequest
            {
                billingNumber = dto.billingNumber,
                transactionId = dto.transactionId,
                amount = dto.amount,
                returnedURL = dto.returnedURL,
                cancelledURL = dto.cancelledURL,
                scope = dto.scope,
                description =dto.description,
                //Las llaves no las manda el api, porque estan guardadas en tu servidor 
                clientId = GetKeyByRestaurant(dto.restaurantType, "ClientId"),
                clientSecret = GetKeyByRestaurant(dto.restaurantType, "ClientSecret"),
            });
            IRestResponse response = await client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                //Manejas tu error y devuelves un 403 con un mensaje de error
            }
            BhdPaymentButtonResponse result = JsonConvert.DeserializeObject<BhdPaymentButtonResponse>(response.Content);
            return result;
        }
    }
}
