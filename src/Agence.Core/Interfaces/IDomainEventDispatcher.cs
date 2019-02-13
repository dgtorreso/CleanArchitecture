using Agence.Core.SharedKernel;

namespace Agence.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}