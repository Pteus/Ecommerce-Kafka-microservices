using Ecommerce.Model;

namespace Ecommerce.Web.Service;

public class ProductService(HttpClient httpClient)
{
    public async Task<List<ProductModel>> GetProductsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<ProductModel>>("product");
    }

    public async Task<ProductModel> GetProductAsync(int productId)
    {
        return await httpClient.GetFromJsonAsync<ProductModel>("product/" + productId);
    }
}