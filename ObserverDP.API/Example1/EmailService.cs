namespace ObserverDP.API.Example1
{
    public class EmailService : IUserObserver
    {
        public ValueTask OnUserCreated(UserCreatedEvent userCreatedEvent)
        {
            Console.WriteLine($"Email sent to {userCreatedEvent.Email} for user creation.");
            return ValueTask.CompletedTask;
        }
    }
}
