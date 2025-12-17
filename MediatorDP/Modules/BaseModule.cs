namespace MediatorDP.Modules
{
    public abstract class BaseModule(IMediator mediator, string ModuleName)
    {
        public abstract void Notify(NotifyMessage notifyMessage);
    }
}
