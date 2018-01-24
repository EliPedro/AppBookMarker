using BookMarker.Core.Domain.Events;

namespace BookMarker.Core.Domain.Handles
{
    public interface IHandler<T>  where T : IDomainEvent
    {
         void Handle(T args);
     }
}
