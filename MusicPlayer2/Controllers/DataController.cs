using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericParsing;

namespace MusicPlayer2
{
    public class DataController
    {
        Database database = new Database();
        public void GetData()
        {
            database.tableSet.BuildClientTable();

            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("../../Models/Docs/Users.txt");
                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    database.tableSet.Data.Tables["Users"].Rows.Add(new object[] { parser["userID"], parser["login"],
                        parser["password"], parser["firstName"], parser["secondName"]});
                }
            }
        }

        public Database GetDatabase()
        {
            return database;
        }
    }
}
