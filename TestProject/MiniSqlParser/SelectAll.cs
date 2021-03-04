using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.MiniSqlParser
{
    public class SelectAll : IQuery
    {
        private string m_table;

        public string Table()
        {
            return m_table;
        }
        public SelectAll(string table)
        {
            m_table = table;
        }
        public string Run(Database database)
        {
            return database.SelectAll(m_table).ToString();
        }
    }
}
