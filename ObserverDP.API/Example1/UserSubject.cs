namespace ObserverDP.API.Example1
{
    public class UserSubject
    {
        private readonly List<IUserObserver> _observers = new();

        public void RegisterObserver(IUserObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IUserObserver observer)
        {
            _observers.Remove(observer);
        }

        public async Task NotifyObservers(UserCreatedEvent userCreatedEvent)
        {
            foreach (var observer in _observers)
            {
                await observer.OnUserCreated(userCreatedEvent);
            }
        }
    }
}
