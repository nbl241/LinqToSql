using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            //récupère les 100 premières factures
            //var dbContext = new WideWorldImportersDbDataContext();
            //var allInvoices = dbContext.OrderLines.Select(o => o.Description).Take(100);
            //foreach (var allInvoice in allInvoices)
            //{
            //    Console.WriteLine(allInvoice);
            //}
            //Console.ReadLine();


            //récupère les commandes effectués entres deux dates
            DateTime beginTime = new DateTime(2013, 01,01);
            DateTime endTime = new DateTime(2013, 01,02);

            Orders order = new Orders();

            List<Order> liste = order.GetOrders(beginTime, endTime);

            liste.ForEach(o => Console.WriteLine("OrderID : {0}, OrderDate : {1}", o.OrderID, o.OrderDate));

            Console.ReadLine();
        }
    }
}
