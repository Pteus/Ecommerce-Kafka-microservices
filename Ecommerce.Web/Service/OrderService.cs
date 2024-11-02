using Ecommerce.Model;

namespace Ecommerce.Web.Service;

public class OrderService(HttpClient httpClient)
{
    public async Task<bool> CreateOrder(OrderModel order)
    {
       var res = await httpClient.PostAsJsonAsync("order", order);
       return res.IsSuccessStatusCode;
    }

    public async Task<List<OrderModel>> GetOrdersAsync()
    {
        return await httpClient.GetFromJsonAsync<List<OrderModel>>("order");
    }
}