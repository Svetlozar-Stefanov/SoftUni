using P03.Detail_Printer;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : IWorker
    {

        public Manager(string name, List<string> documents) 
        {
            Name = name;
            Documents = documents;
        }

        public IReadOnlyCollection<string> Documents { get; private set; }

        public string Name { get; private set; }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(string.Join(Environment.NewLine, Documents));

            return sb.ToString().TrimEnd();
        }
    }
}
