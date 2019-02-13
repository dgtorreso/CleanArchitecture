using Agence.Core.SharedKernel;

namespace Agence.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}