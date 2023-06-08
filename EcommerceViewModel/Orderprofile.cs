using AutoMapper;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceViewModel
{
    public class Orderprofile:Profile
    {
        public Orderprofile() 
        {
            CreateMap<OrderItem, OrderitemViewModel>()
                .ForMember(dst => dst.branch,
                opt => opt.MapFrom(src => src.order.branch.Name));

        }
    }
}
