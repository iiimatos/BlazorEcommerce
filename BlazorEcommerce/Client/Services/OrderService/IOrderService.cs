﻿namespace BlazorEcommerce.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task PlacerOrder();
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
