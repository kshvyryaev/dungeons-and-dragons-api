using System;
using AutoMapper;
using DungeonsAndDragons.Base.Identifier;
using DungeonsAndDragons.Domain.Contracts;
using DungeonsAndDragons.Domain.Models.Commands.Characters;
using DungeonsAndDragons.Domain.Models.Responses;
using DungeonsAndDragons.Entities;

namespace DungeonsAndDragons.Domain.Mapper.Profiles
{
    internal class CharactersProfile : Profile
    {
        public CharactersProfile(IObjectIdentifierParser objectIdentifierParser)
        {
            if (objectIdentifierParser == null)
            {
                throw new ArgumentNullException(nameof(objectIdentifierParser));
            }

            CreateMap<Character, CharacterResponse>();

            CreateMap<CreateCharacterCommand, Character>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(command => ObjectIdentifier.GenerateNewId()));

            CreateMap<UpdateCharacterCommand, Character>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(command => objectIdentifierParser.ValidateAndParse(command.Id)));
        }
    }
}
