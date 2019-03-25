namespace DungeonsAndDragons.Domain.Contracts
{
    public interface IMapperAdapter
    {
        TDestination Map<TDestination>(object source);

        TDestination Map<TSource, TDestination>(TSource source);
    }
}
