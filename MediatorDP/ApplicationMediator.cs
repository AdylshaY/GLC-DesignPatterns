using MediatorDP.Modules;

namespace MediatorDP
{
    public class ApplicationMediator : IMediator
    {
        private readonly List<BaseModule> _modules = new List<BaseModule>();

        public void Send(BaseModule sender, NotifyMessage notifyMessage)
        {
            foreach (var module in _modules)
            {
                if (module != sender)
                {
                    module.Notify(notifyMessage);
                }
            }
        }

        public void RegisterModule(BaseModule module)
        {
            if (!_modules.Contains(module))
            {
                _modules.Add(module);
            }
        }
    }
}
