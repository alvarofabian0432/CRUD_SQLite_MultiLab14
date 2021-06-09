using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteLab14.Datos
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
