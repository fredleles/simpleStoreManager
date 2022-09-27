using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLData.Library.DataAccess;
using SQLData.Library.Models;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SaleController : ControllerBase
    {
        private readonly ISaleData _saleData;

        public SaleController(ISaleData saleData)
        {
            _saleData = saleData;
        }


        [HttpGet]
        public List<SaleModel> GetAll()
        {
            return _saleData.GetSales();
        }

        [HttpGet]
        [Route("Products/{SaleId?}")]
        public List<SaleProductModel> GetProductsBySaleId(int SaleId)
        {
            return _saleData.GetProductsBySaleId(SaleId);
        }
    }
}
