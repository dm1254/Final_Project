namespace Payment
{
    public class DebitCardPayment : Payment
    {
        public decimal Balance {get;set;}
        private const decimal transactionFee = .25m;
        public DebitCardPayment(decimal balance)
        {
            Balance = balance;
        }
        public override decimal CalculateTotal(decimal baseAmount)
        {
            return  baseAmount + transactionFee;
        }
        public override decimal ProcessPayment(decimal baseAmount)
        {
            decimal toCharge = CalculateTotal(baseAmount);
            if(Balance >= toCharge)
            {
                Balance -= toCharge;
                return true; 
            }
            return false;
        }
    }

}
