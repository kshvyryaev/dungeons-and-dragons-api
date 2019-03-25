using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DungeonsAndDragons.WebApi.Infrastructure;
using DungeonsAndDragons.Domain.Contracts;
using DungeonsAndDragons.Domain.Models.Commands.Characters;

namespace DungeonsAndDragons.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharactersController : ApiControllerBase
    {
        private readonly ICharactersService _charactersService;

        public CharactersController(ICharactersService charactersService)
        {
            _charactersService = charactersService ?? throw new ArgumentNullException(nameof(charactersService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var characters = await _charactersService.GetAllAsync();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var character = await _charactersService.GetByIdAsync(id);
            return ResultIfNotNull(character);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCharacterCommand createCommand)
        {
            var createdCharacter = await _charactersService.CreateAsync(createCommand);
            return this.CreatedAtAction(nameof(GetById), new { id = createdCharacter.Id }, createdCharacter);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCharacterCommand updateCommand)
        {
            var updatedCharacter = await _charactersService.UpdateAsync(updateCommand);
            return this.ResultIfNotNull(updatedCharacter);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _charactersService.DeleteAsync(id);
        }
    }
}