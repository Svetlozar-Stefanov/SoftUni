namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if (!int.TryParse(obj.ToString(), out int result) 
                || (result < minValue 
                || result > maxValue))
            {
                return false;
            }

            return true;
        }
    }
}
