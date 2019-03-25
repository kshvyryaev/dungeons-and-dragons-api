using DungeonsAndDragons.Base.Identifier;
using DungeonsAndDragons.Entities;
using DungeonsAndDragons.Persistence.Contracts;

namespace DungeonsAndDragons.Persistence.Mongo
{
    public class CharactersRepository : Repository<Character, ObjectIdentifier>, ICharactersRepository<ObjectIdentifier>
    {
        public CharactersRepository(IDatabaseConfiguration configuration) : base(configuration)
        {
        }
    }
}
