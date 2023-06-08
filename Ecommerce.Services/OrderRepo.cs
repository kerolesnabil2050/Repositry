using Ecommerce.Models;
using Ecommerce.Repositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class OrderRepo

    {
      IgenricRepo<Order, int> order;
      IgenricRepo<OrderItem, int> items;

        UnitOfWork UnitOfWork;
        public OrderRepo(IgenricRepo<Order, int> _order, IgenricRepo<OrderItem, int> _items, UnitOfWork unitOfWork)
        {
            this.order = _order;
            this.items = _items;
            UnitOfWork = unitOfWork;
        }

        public void Add(Order orderr)

        {
            var kero = orderr.Items.ToList();
            orderr.Items = null;
             order.Add(orderr);
            UnitOfWork.SaveChange();
            foreach(var item in kero)
            {
                item.orderId=orderr.Id;
                items.Add(item);
            }


        }
        public IEnumerable<Order> GetBranches() 
        {
            return order.GetAll().ToList();
        }
        public void save()
        {
            UnitOfWork.SaveChange();
        }

    }
}
