using Newtonsoft.Json;
using RestaurantApi.CQRS.Handlers.QueryHandlers;
using RestaurantApi.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantApi.Models.Entity.Factories
{
    public class EmptyTableLister
    {
        private HttpClient _client;

        private static EmptyTableLister _tableFactory;

        private EmptyTableLister()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44325/api/Reservation");
        }

        public static EmptyTableLister GetFactory()
        {
            if (_tableFactory is null)
            {
                _tableFactory = new EmptyTableLister();
            }

            return _tableFactory;
        }

        public ICollection<GetEmptyTablesQueryResponse> GetEmptyTables()
        {
            var responseTask = _client.GetAsync("/Empty_Tables");
            responseTask.Wait();

            var result = responseTask.Result;
            if (!result.IsSuccessStatusCode)
            {
                throw new Exception(result.ReasonPhrase);
            }

            Task<string> readTask = result.Content.ReadAsStringAsync();
            readTask.Wait();

            string jsonObjectContent = readTask.Result;

            return JsonConvert.DeserializeObject<ICollection<GetEmptyTablesQueryResponse>>(jsonObjectContent);            
        }
    }
}
