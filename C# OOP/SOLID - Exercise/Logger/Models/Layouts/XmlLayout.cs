using Logger.Contracts;
using System.Text;

namespace Logger.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format
        {
            get
            {
                return GetLayout();
            }
        }

        private string GetLayout()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<log>");
            sb.AppendLine("    <date>{0}</date>");
            sb.AppendLine("    <level>{1}</level>");
            sb.AppendLine("    <message>{2}</message>");
            sb.AppendLine("</log>");

            return sb.ToString().TrimEnd();
        }
    }
}
