namespace Payment
{
    public class CashPayment : Payment
    {
        public decimal CashRecieved {get;set;}
        public CashPayment(decimal cashRecieved)
        {
            CashRecieved = cashRecieved;
        }
        public override CalculateTotal(decimal baseAmount)
        {
            return baseAmount;
        }
        public override bool ProcessPayment(decimal baseAmount)
        {
            if(CashRecieved >= baseAmount)
            {
                CashRecieved -= baseAmount;
                return true;
            }
            return false;
        }

    }


}
