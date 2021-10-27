namespace WebApiRouting
{
    public class ComputeUnit
    {
        public int Value1 { get; set; }
        public int Value2 { get; set;  }
        public string Mode { get; set; }

        public int Compute()
        {
            if (Mode == "addition")
            {
                int result = Value1 + Value2;
                return result;
            }
            else if (Mode == "multiplication")
            {
                int result = Value1 * Value2;
                return result;
            }
            else { return -1; }
        }
    }
}
