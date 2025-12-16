namespace ObserverDP.API.Example1
{
    public class NotificationService : IUserObserver
    {
        public ValueTask OnUserCreated(UserCreatedEvent userCreatedEvent)
        {
            Console.WriteLine($"Notification sent for user creation: {userCreatedEvent.Name}");
            return ValueTask.CompletedTask;
        }
    }
}
