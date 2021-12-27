using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.CQRS.Queries.Request;
using RestaurantApi.CQRS.Queries.Response;
using RestaurantApi.Models.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantApi.CQRS.Handlers.QueryHandlers
{
    public class GetEmptyTablesQueryHandler : IRequestHandler<GetEmptyTablesQueryRequest, List<GetEmptyTablesQueryResponse>>
    {
        readonly DatabaseContext _db;

        public GetEmptyTablesQueryHandler([FromServices]DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<GetEmptyTablesQueryResponse>> Handle(GetEmptyTablesQueryRequest request, CancellationToken cancellationToken)
        {
            return _db.Tables.Where(x => x.IsEmpty.Equals(true)).Select(table => new GetEmptyTablesQueryResponse
            {
                Id = table.Id,
                TableName = $"Masa {table.Id}",
                IsEmpty = table.IsEmpty
            }).ToList();

            await _db.SaveChangesAsync();
        }
    }
}
