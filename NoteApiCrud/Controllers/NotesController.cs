using Microsoft.AspNetCore.Mvc;
using NoteApiCrud.Models;
using NoteApiCrud.Repositories;

namespace NoteApiCrud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly INoteRepository _repository;

        public NotesController(INoteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Note>>> GetAll()
        {
            var notes = await _repository.GetAllAsync();
            return Ok(notes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Note>> GetById(int id)
        {
            var note = await _repository.GetByIdAsync(id);
            if (note == null) return NotFound();
            return Ok(note);
        }

        [HttpPost]
        public async Task<ActionResult<Note>> Create(Note note)
        {
            var result = await _repository.AddAsync(note);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Note>> Update(int id, Note note)
        {
            var result = await _repository.UpdateAsync(id, note);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repository.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}

