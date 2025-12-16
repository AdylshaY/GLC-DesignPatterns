namespace ObserverDP.API.Example1
{
    public class UserService(UserSubject userSubject)
    {
        public async Task CreateUser(string name, string email, string phoneNumber)
        {
            var userId = new Random().Next(1, 1000);
            var userCreatedEvent = new UserCreatedEvent(userId, name, email, phoneNumber);
            await userSubject.NotifyObservers(userCreatedEvent);
        }
    }
}
