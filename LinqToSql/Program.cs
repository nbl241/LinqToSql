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
            var dbContext = new WideWorldImportersDbDataContext();
            var allInvoices = dbContext.OrderLines.Select(o => o.Description).Take(100);
            foreach (var allInvoice in allInvoices)
            {
                Console.WriteLine(allInvoice);
            }
            Console.ReadLine();
        }
    }
}
