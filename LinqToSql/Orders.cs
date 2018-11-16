using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    public class Orders
    {

        public List<Order> GetOrders(DateTime beginTime, DateTime endTime)
        {
            List<Order> listeOrders = new List<Order>();

            using (var dbContext = new WideWorldImportersDbDataContext())
            {
                listeOrders = dbContext.Orders.Where(o => o.OrderDate >= beginTime && o.OrderDate <= endTime).ToList();

            }
            return listeOrders;
        }
    }
}
