
namespace Herança.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double juros)
        {
            Balance += InterestRate * Balance;
        }
        public override void WithDraw(double amount)
        {
            Balance -= amount;
        }
    }
}
