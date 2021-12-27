using MediatR;
using RestaurantApi.CQRS.Queries.Response;
using System.Collections.Generic;

namespace RestaurantApi.CQRS.Queries.Request
{
    public class GetEmptyTablesQueryRequest : IRequest<List<GetEmptyTablesQueryResponse>>
    {
    }
}
