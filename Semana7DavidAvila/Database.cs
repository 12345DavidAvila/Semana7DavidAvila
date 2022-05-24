using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Semana7DavidAvila
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
