using Logger.Contracts;

namespace Logger.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string MessageFormat => "{0} - {1} - {2}";
    }
}
