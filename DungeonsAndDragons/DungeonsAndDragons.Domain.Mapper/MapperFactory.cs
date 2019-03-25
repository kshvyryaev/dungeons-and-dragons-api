using System;
using AutoMapper;
using DungeonsAndDragons.Domain.Contracts;
using DungeonsAndDragons.Domain.Mapper.Profiles;

namespace DungeonsAndDragons.Domain.Mapper
{
    internal static class MapperFactory
    {
        internal static IMapper GetInstance(IObjectIdentifierParser objectIdentifierParser)
        {
            if (objectIdentifierParser == null)
            {
                throw new ArgumentNullException(nameof(objectIdentifierParser));
            }

            var mapperConfiguration = new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new CharactersProfile(objectIdentifierParser));
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
