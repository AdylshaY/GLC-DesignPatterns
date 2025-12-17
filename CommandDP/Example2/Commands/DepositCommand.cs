using CommandDP.Example2.Receivers;

namespace CommandDP.Example2.Commands
{
    public class DepositCommand(BankAccount account, decimal amount) : IBankCommand
    {
        public void Execute()
        {
            account.Deposit(amount);
        }
        public void Undo()
        {
            account.Withdraw(amount);
        }
    }
}
