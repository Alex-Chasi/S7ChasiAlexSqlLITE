using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace S7ChasiAlexSqlLITE
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();

    }
}
