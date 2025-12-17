using CommandDP.Example2.Receivers;

namespace CommandDP.Example2.Commands
{
    public class WithdrawCommand(BankAccount account, decimal amount) : IBankCommand
    {
        public void Execute()
        {
            account.Withdraw(amount);
        }
        public void Undo()
        {
            account.Deposit(amount);
        }
    }
}
