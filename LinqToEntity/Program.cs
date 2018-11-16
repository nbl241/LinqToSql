using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime beginTime = new DateTime(2013, 01, 01);
            DateTime endTime = new DateTime(2013, 01, 02);

            OrderServicies order = new OrderServicies();

            List<Orders> liste = order.GetOrders(beginTime, endTime);

            liste.ForEach(o => Console.WriteLine("OrderID : {0}, OrderDate : {1}", o.OrderID, o.OrderDate));

            Console.ReadLine();
        }
    }
}
