using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntity
{
    class OrderServicies
    {
        public List<Orders> GetOrders(DateTime beginTime, DateTime endTime)
        {
            List<Orders> listeOrders = new List<Orders>();

            using (var dbContext = new WideWorldImportersEntities())
            {
                listeOrders = dbContext.Orders.Where(o => o.OrderDate >= beginTime && o.OrderDate <= endTime).ToList();
            }
            return listeOrders;
        }
    }
}
