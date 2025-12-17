using MediatorDP.Modules;

namespace MediatorDP
{
    public interface IMediator
    {
        void Send(BaseModule sender, NotifyMessage notifyMessage);
    }
}
