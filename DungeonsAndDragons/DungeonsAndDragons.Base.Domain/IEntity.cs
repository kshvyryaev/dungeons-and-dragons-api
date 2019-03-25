namespace DungeonsAndDragons.Base.Domain
{
    public interface IEntity<TIdentifier>
    {
        TIdentifier Id { get; set; }
    }
}
