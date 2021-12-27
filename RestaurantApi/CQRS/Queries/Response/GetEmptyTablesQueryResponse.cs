using RestaurantApi.Models.Entity;

namespace RestaurantApi.CQRS.Queries.Response
{
    public class GetEmptyTablesQueryResponse
    {
        public int Id { get; set; }

        public string TableName { get; set; }

        public bool IsEmpty { get; set; }
    }
}
