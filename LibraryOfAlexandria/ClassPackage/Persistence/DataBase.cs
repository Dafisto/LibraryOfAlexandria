using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
    
   
        //This will open a connection to the library database
        