using DungeonsAndDragons.Base.Domain;
using DungeonsAndDragons.Base.Identifier;
using MongoDB.Bson.Serialization.Attributes;

namespace DungeonsAndDragons.Entities
{
    public abstract class BaseEntity : IEntity<ObjectIdentifier>
    {
        [BsonId]
        public ObjectIdentifier Id { get; set; }
    }
}
