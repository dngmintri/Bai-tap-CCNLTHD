using Microsoft.EntityFrameworkCore;
using NoteApiCrud.Data;
using NoteApiCrud.Models;

namespace NoteApiCrud.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _context;

        public NoteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note?> GetByIdAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task<Note> AddAsync(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
            return note;
        }

        public async Task<Note?> UpdateAsync(int id, Note note)
        {
            var existingNote = await _context.Notes.FindAsync(id);
            if (existingNote == null) return null;

            existingNote.Title = note.Title;
            existingNote.Content = note.Content;
            await _context.SaveChangesAsync();
            return existingNote;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note == null) return false;

            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

