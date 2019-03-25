using DungeonsAndDragons.Entities;

namespace DungeonsAndDragons.Persistence.Contracts
{
    public interface ICharactersRepository<in TIdentifier> : IRepository<Character, TIdentifier>
    {
    }
}
