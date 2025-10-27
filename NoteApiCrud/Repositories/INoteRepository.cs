using NoteApiCrud.Models;

namespace NoteApiCrud.Repositories
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetAllAsync();
        Task<Note?> GetByIdAsync(int id);
        Task<Note> AddAsync(Note note);
        Task<Note?> UpdateAsync(int id, Note note);
        Task<bool> DeleteAsync(int id);
    }
}

