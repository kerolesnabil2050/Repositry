using Ecommerce.Models;
using Ecommerce.Repositry;
using Ecommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace IgenricRepo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderRepo OrderRepo;
        UnitOfWork UnitOfWork;
        public OrderController(OrderRepo order, UnitOfWork unitOfWork)
        {
            OrderRepo = order;
            UnitOfWork = unitOfWork;
        }
        [HttpPost]
        public void post() 
        {
            OrderRepo.Add(new Order
            {
                branch=new branch {   Name="alssad"},
                Items = new List<OrderItem>
                {
                    new OrderItem { Name = "dairy malk", Price = 200 },
                    new OrderItem { Name = "bess", Price = 100 }
                }
               
            });;
            UnitOfWork.CommitTransaction();
        }




    }
}
