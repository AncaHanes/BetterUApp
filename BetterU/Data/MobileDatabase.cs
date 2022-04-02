using BetterU.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BetterU.Data
{
    public class MobileDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public MobileDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Tasks>().Wait();
        }

        public Task<List<Tasks>> GetTasksAsync()
        {
             return _database.Table<Tasks>().ToListAsync();

            // String d = DateTime.Today.ToString();

          //  return _database.Table<Tasks>()
            //.Where(i => i.Date.ToString == d)
            //.FirstOrDefaultAsync();


        }

        public Task<Tasks> GetTasksAsync(int id)
        {

            return _database.Table<Tasks>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }

        public Task<int> SaveTasksAsync(Tasks task)
        {

            if (task.ID != 0)
            {
                return _database.UpdateAsync(task);
            }
            else
            {
                return _database.InsertAsync(task);
            }
        }

        public Task<int> SavePassAsync(RegUserTable pass)
        {

            if (pass.UserId != 0)
            {
                return _database.UpdateAsync(pass);
            }
            else
            {
                return _database.InsertAsync(pass);
            }
        }



        public Task<int> DeleteTasksAsync(Tasks task)
        {
            return _database.DeleteAsync(task);
        }

    }
}
