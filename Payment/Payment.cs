namespace Payment
{
    public abstract class Payment
    {
        public abstract bool ProcessPayment(decimal baseAmount);
        public abstract decimal CalculateTotal(decimal baseAmount);
    }


}
