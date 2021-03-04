using System;
using System.Collections.Generic;
using System.Text;
using TestProject.MiniSqlParser;

namespace TestProject
{
    public class Table
    {

    }
    public class Database
    {
        public Table SelectAll(string table)
        {
            return null;
        }

        public Table SelectColumns(string table, List<string> columnNames)
        {
            return null;
        }

        public string RunMiniSqlQuery(string query)
        {
            IQuery queryObject = MiniSqlParser.Parser.Parse(query);

            return queryObject.Run(this);
        }
    }
}
