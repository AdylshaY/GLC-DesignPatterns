namespace ObserverDP.API.Example1
{
    public interface IUserObserver
    {
        ValueTask OnUserCreated(UserCreatedEvent userCreatedEvent);
    }
}
