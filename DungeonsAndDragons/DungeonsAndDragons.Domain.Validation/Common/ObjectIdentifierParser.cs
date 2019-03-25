using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Results;
using DungeonsAndDragons.Base.Identifier;
using DungeonsAndDragons.Domain.Contracts;

namespace DungeonsAndDragons.Domain.Validation.Common
{
    public class ObjectIdentifierParser : IObjectIdentifierParser
    {
        public ObjectIdentifier ValidateAndParse(string id)
        {
            if (!ObjectIdentifier.TryParse(id, out var parsedId))
            {
                var failureList = new List<ValidationFailure>()
                {
                    new ValidationFailure(nameof(id), "Unable to parse", id)
                };

                throw new ValidationException(failureList);
            }

            return parsedId;
        }
    }
}
