namespace DungeonsAndDragons.Persistence.Contracts
{
    public interface IDatabaseConfiguration
    {
        string ConnectionString { get; }

        string Database { get; }
    }
}
