

namespace Herança.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAccount()
        {

        }
        public BussinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double loan)
        {
            if (loan <= LoanLimit)
            {
                Balance += loan;
            }
        }

        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.00;
        }
    }
}
