namespace Ordering.Application.Orders.Queries.GetOrders;

using BuildingBlocks.Pagination;

public record GetOrdersQuery(PaginationRequest PaginationRequest)
    : IQuery<GetOrdersResult>;

public record GetOrdersResult(PaginatedResult<OrderDto> Orders);
