using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;

namespace ProductApp.Model
{
    public class DbContext
    {

        static LiteDatabase _instance;
        public DbContext(string fileNameOrConnectionString)
        {
            _instance = new LiteDatabase(fileNameOrConnectionString);
        }

        public LiteDatabase GetInstance()
        {
            return _instance;
        }
    }
}
