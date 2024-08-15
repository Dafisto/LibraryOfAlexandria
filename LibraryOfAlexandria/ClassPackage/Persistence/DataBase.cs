using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfAlexandria.ClassPackage.Domain;

namespace LibraryOfAlexandria.ClassPackage.Persistence
{
    internal class DataBase
    {
        private readonly SQLiteAsyncConnection connection;

        //constructor for database connection
        public DataBase(string dbPath)
        {            
            connection = new SQLiteAsyncConnection(dbPath);
        }
        public DataBase()
        {
        }
        public Task<List<Books>> GetItemsAsync() // Item = table name
        {
            return connection.Table<Books>().ToListAsync(); // fetches all data and returns the items as a list
        }
    }
}
    
   
        //This will open a connection to the library database
        