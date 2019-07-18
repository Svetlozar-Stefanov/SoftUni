using P03.Detail_Printer;
using System;
using System.Collections.Generic;
namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<IWorker> employees;

        public DetailsPrinter(IList<IWorker> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetDetails());
            }
        }
    }
}
