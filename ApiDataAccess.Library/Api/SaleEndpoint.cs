using ApiDataAccess.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApiDataAccess.Library.Api
{
    public class SaleEndpoint : ISaleEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public SaleEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<SaleModel>> GetAll()
        {
            using HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Sale");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<List<SaleModel>>();
                return result!;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<List<SaleProductModel>> GetProductsFromSaleId(int SaleId)
        {
            using HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/Sale/Products/{SaleId}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<List<SaleProductModel>>();
                return result!;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
