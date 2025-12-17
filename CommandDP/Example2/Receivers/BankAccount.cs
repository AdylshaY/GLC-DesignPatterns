namespace CommandDP.Example2.Receivers
{
    public class BankAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"BankAccount ID: {Id}, Balance: {Balance}";
        }
    }
}
