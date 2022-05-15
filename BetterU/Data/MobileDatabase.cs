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
            _database.CreateTableAsync<Notifications>().Wait();
            _database.CreateTableAsync<Moods>().Wait();
        }
        public Task<List<Moods>> GetCountVBAsync()
        {
            return _database.QueryAsync<Moods>(
            "select * from Moods m where m.Value = 1");
        }
        public Task<List<Moods>> GetCountBAsync()
        {
            return _database.QueryAsync<Moods>(
            "select * from Moods m where m.Value = 2");
        }
        public Task<List<Moods>> GetCountSSAsync()
        {
            return _database.QueryAsync<Moods>(
            "select * from Moods m where m.Value = 3");
        }
        public Task<List<Moods>> GetCountQGAsync()
        {
            return _database.QueryAsync<Moods>(
            "select * from Moods m where m.Value = 4");
        }
        public Task<List<Moods>> GetCountFAsync()
        {
            return _database.QueryAsync<Moods>(
            "select * from Moods m where m.Value = 5");
        }

        public Task<List<Tasks>> GetCompleteTasksAsync()
        {
            return _database.QueryAsync<Tasks>(
            "select * from Tasks t where t.Complete = true");
        }

        public Task<List<Tasks>> GetUncompleteTasksAsync()
        {
            return _database.QueryAsync<Tasks>(
            "select * from Tasks t where t.Complete = false");
        }

        public Task<List<Tasks>> GetTasksAsync()
        {
            // return _database.Table<Tasks>().ToListAsync();

            DateTime thisDay = DateTime.Today;

            return _database.Table<Tasks>()
            .Where(i => i.Date == thisDay).ToListAsync(); 
            
        }

         public Task<List<Tasks>> GetTasksOverdueAsync()
        {
            // return _database.Table<Tasks>().ToListAsync();

            DateTime thisDay = DateTime.Today;

            return _database.Table<Tasks>()
            .Where(i => i.Date != thisDay && i.Complete==false).ToListAsync();

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
        
         public Task<int> SaveMoodsAsync(Moods mood)
        {

            if (mood.ID != 0)
            {
                return _database.UpdateAsync(mood);
            }
            else
            {
                return _database.InsertAsync(mood);
            }
        }
        public Task<int> SaveNotifAsync(Notifications notif)
        {

            if (notif.ID != 0)
            {
                return _database.UpdateAsync(notif);
            }
            else
            {
                return _database.InsertAsync(notif);
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
