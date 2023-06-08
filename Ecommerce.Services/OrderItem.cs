using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ecommerce.Models;
using Ecommerce.Repositry;
using EcommerceViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class OrderItems:IOrderItem
    {
        IgenricRepo<OrderItem, int> reposity1;
        UnitOfWork UnitOfWork;
        IMapper mapper;
        public OrderItems(IgenricRepo<OrderItem, int> _reposity, UnitOfWork unitOfWork,IMapper _mapper)
        {
            reposity1 = _reposity;
            UnitOfWork = unitOfWork;
            mapper = _mapper;

        }
        public OrderItem Add(OrderItem item)
        {
            reposity1.Add(item);
            UnitOfWork.SaveChange();
            return item;
        }
        public  IEnumerable<OrderitemViewModel> GetAll()
        {
           var orderr= reposity1.GetAll();
           return orderr.ProjectTo<OrderitemViewModel>(mapper.ConfigurationProvider);

        }






    }
}
