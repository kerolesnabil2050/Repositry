using Ecommerce.Models;
using Ecommerce.Repositry;
using Ecommerce.Services;
using EcommerceViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace IgenricRepo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        OrderItems order;
        public OrderItemController(OrderItems _orderItem)
        {
            this.order = _orderItem;

        }
        [HttpGet]
        public List<OrderitemViewModel> Index()
        {
           return  order.GetAll().ToList();
        }




    }
}
