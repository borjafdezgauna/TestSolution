using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.MiniSqlParser
{
    public interface IQuery
    {
        string Run(Database database);
    }
}
