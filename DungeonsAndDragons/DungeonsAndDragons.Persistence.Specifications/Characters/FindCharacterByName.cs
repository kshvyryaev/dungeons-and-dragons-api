using System;
using System.Linq.Expressions;
using DungeonsAndDragons.Base.Domain;
using DungeonsAndDragons.Entities;

namespace DungeonsAndDragons.Persistence.Specifications.Characters
{
    public class FindCharacterByName : ISpecification<Character>
    {
        private readonly string _name;

        public FindCharacterByName(string name)
        {
            _name = name;
        }

        public Expression<Func<Character, bool>> Predicate => c => c.Name == _name;
    }
}
