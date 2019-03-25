using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DungeonsAndDragons.Base.Identifier;
using DungeonsAndDragons.Domain.Contracts;
using DungeonsAndDragons.Domain.Mapper;
using DungeonsAndDragons.Domain.Models.Commands.Characters;
using DungeonsAndDragons.Domain.Validation.Characters;
using DungeonsAndDragons.Entities;
using DungeonsAndDragons.Persistence.Contracts;
using DungeonsAndDragons.Persistence.Mongo;
using DungeonsAndDragons.Domain;
using DungeonsAndDragons.Domain.Validation.Common;

namespace DungeonsAndDragons.Ioc
{
    public static class IocConfiguration
    {
        public static void ConfigureIoc(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            // Repositories
            services.AddSingleton<IDatabaseConfiguration>(c => new DatabaseConfiguration(configuration));
            services.AddSingleton<ICharactersRepository<ObjectIdentifier>, CharactersRepository>();

            // Validations
            services.AddTransient<ICommandValidator<CreateCharacterCommand, Character>, CreateCharacterValidator>();
            services.AddTransient<ICommandValidator<UpdateCharacterCommand, Character>, UpdateCharacterValidator>();
            services.AddSingleton<IObjectIdentifierParser, ObjectIdentifierParser>();

            // Mappings
            services.AddSingleton<IMapperAdapter, MapperAdapter>();

            // Services
            services.AddSingleton<ICharactersService, CharactersService>();
        }
    }
}
