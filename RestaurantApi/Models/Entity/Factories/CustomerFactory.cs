using Newtonsoft.Json;
using RestaurantApi.CQRS.Commands.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantApi.Models.Entity.Factories
{
    public class CustomerFactory
    {
        private HttpClient _client;

        private static CustomerFactory _customerFactory;

        private CustomerFactory()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44325/api/Reservation");
        }

        public static CustomerFactory GetFactory()
        {
            if (_customerFactory is null)
            {
                _customerFactory = new CustomerFactory();
            }

            return _customerFactory;
        }

        public string CreateNewCustomerReservation(string fullName, string dateTime, int tableId)
        {
            var responseTask = _client.GetAsync("/Create_Customer");
            responseTask.Wait();

            var result = responseTask.Result;

            CreateCustomerCommandRequest c = new CreateCustomerCommandRequest();

            c.FullName = fullName;
            c.ReservationTime = dateTime;
            c.TableId = tableId;

            string json = JsonConvert.SerializeObject(c);

            return json;
        }
    }
}
