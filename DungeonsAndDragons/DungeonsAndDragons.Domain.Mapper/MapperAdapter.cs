using AutoMapper;
using DungeonsAndDragons.Domain.Contracts;

namespace DungeonsAndDragons.Domain.Mapper
{
    public class MapperAdapter : IMapperAdapter
    {
        private readonly IMapper _mapper;

        public MapperAdapter(IObjectIdentifierParser objectIdentifierParser)
        {
            _mapper = MapperFactory.GetInstance(objectIdentifierParser);
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
