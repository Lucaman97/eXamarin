using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using eXamarin.Models;
using SQLite;

namespace eXamarin.Data
{
    public class OrarioDatabase
    {
        readonly SQLiteAsyncConnection _orarioDatabase;

        public OrarioDatabase(string dbPath)
        {
            _orarioDatabase = new SQLiteAsyncConnection(dbPath);
            _orarioDatabase.CreateTableAsync<Orario>().Wait();
        }

        public Task<List<Orario>> GetOrarioAsync()
        {
            return _orarioDatabase.Table<Orario>().ToListAsync();
        }

        public Task<Orario> GetOrarioAsync(int id)
        {
            return _orarioDatabase.Table<Orario>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }


        public Task<int> SaveOrarioAsync(Orario orario)
        {
            if(orario.ID != 0)
            {
                return _orarioDatabase.UpdateAsync(orario);
            }
            else
            {
                return _orarioDatabase.InsertAsync(orario);
                
            }
        }

   


        public Task<List<Orario>> GetOrarioByMat(string mat)
        {
            return _orarioDatabase.Table<Orario>().Where(i => i.orario.Equals(mat)).ToListAsync();
        }




        /*
        public  Task<List<Orario>> GetItemsNotDoneAsync()
        {
            //var data = await _orarioDatabase.QueryAsync<Orario>("SELECT * FROM [Item] WHERE [Done] = 0");
            //return new ObservableCollection<Orario>(data);

            return _orarioDatabase.QueryAsync<Orario>("SELECT * FROM [Orario] WHERE [giorno] = Lunedì");
        }
        */




       

        public Task<Orario> ControlSubjAsync(string giorno, string ora)
        {
            

            return _orarioDatabase.Table<Orario>().Where(i => i.giorno.Equals(giorno)&i.orario.Equals(ora)).FirstOrDefaultAsync();
            //return _orarioDatabase.Table<Orario>().Where(i => i.giorno.Equals(giorno)).FirstOrDefaultAsync();
        }

        public async Task DeleteOrarioAsync(string giorno, string ora)
        {
            var record = await _orarioDatabase.Table<Orario>().Where(i => i.giorno.Equals(giorno) & i.orario.Equals(ora)).FirstOrDefaultAsync();
            if (record != null)
            {
                // Delete record
                await _orarioDatabase.DeleteAsync(record);

            }

            return ;
                                                
        }
    }
}
