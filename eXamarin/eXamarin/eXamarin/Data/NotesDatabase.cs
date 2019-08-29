using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eXamarin.Models;
using SQLite;

namespace eXamarin.Data
{
    public class NotesDatabase
    {
        readonly SQLiteAsyncConnection _notesDatabase;

        public NotesDatabase(string dbPath)
        {
            _notesDatabase = new SQLiteAsyncConnection(dbPath);
            _notesDatabase.CreateTableAsync<Note>().Wait();
        }

        public Task<List<Note>> GetNoteAsync()
        {
            return _notesDatabase.Table<Note>().ToListAsync();
        }

        public Task<Note> GetNoteAsync(int id)
        {
            return _notesDatabase.Table<Note>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            if (note.ID != 0)
            {
                return _notesDatabase.UpdateAsync(note);
            }
            else
            {
                return _notesDatabase.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Note note)
        {
            return _notesDatabase.DeleteAsync(note);
        }

        public Task<List<Note>> GetNoteBySubj(string mat)
        {
            return _notesDatabase.Table<Note>().Where(i => i.Subject.Equals(mat)).ToListAsync();
        }
    }
}
