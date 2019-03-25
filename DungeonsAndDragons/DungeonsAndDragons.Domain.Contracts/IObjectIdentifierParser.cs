using DungeonsAndDragons.Base.Identifier;

namespace DungeonsAndDragons.Domain.Contracts
{
    public interface IObjectIdentifierParser
    {
        ObjectIdentifier ValidateAndParse(string id);
    }
}
