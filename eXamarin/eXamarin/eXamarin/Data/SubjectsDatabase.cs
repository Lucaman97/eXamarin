using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using eXamarin.Models;
using SQLite;

namespace eXamarin.Data
{
    public class SubjectsDatabase
    {
        readonly SQLiteAsyncConnection _subjectsDatabase;

        public SubjectsDatabase(string dbPath)
        {
            _subjectsDatabase = new SQLiteAsyncConnection(dbPath);
            _subjectsDatabase.CreateTableAsync<Subjects>().Wait();
        }

        public Task<List<Subjects>> GetSubjAsync()
        {
            return _subjectsDatabase.Table<Subjects>().ToListAsync();
        }

        public Task<Subjects> GetSubjAsync(int id)
        {
            return _subjectsDatabase.Table<Subjects>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveSubjAsync(Subjects subject)
        {
            if(subject.ID != 0)
            {
                return _subjectsDatabase.UpdateAsync(subject);
            }
            else
            {
                return _subjectsDatabase.InsertAsync(subject);
            }
        }

        public Task<int> DeleteSubjAsync(Subjects subject)
        {
            return _subjectsDatabase.DeleteAsync(subject);
        }

        public Task<Subjects> ControlSubjAsync(string subject)
        {
            return _subjectsDatabase.Table<Subjects>().Where(i => i.Subject.Equals(subject)).FirstOrDefaultAsync();
        }
    }
}
