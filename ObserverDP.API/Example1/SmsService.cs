namespace ObserverDP.API.Example1
{
    public class SmsService : IUserObserver
    {
        public ValueTask OnUserCreated(UserCreatedEvent userCreatedEvent)
        {
            Console.WriteLine($"SMS sent for user creation: {userCreatedEvent.Name}");
            return ValueTask.CompletedTask;
        }
    }
}
