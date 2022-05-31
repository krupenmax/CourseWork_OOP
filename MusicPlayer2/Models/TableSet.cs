using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicPlayer2
{
    public class TableSet
    {
        public DataSet Data = new DataSet();

        public void BuildClientTable()
        {
            DataTable table = new DataTable("Users");
            DataColumn column = new DataColumn()
            {
                DataType = System.Type.GetType("System.Int16"),
                ColumnName = "userID",
                Unique = true,
            };
            table.Columns.Add(column);

            column = new DataColumn()
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "login",
                Unique = true,
            };
            table.Columns.Add(column);
            

            column = new DataColumn()
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "password",
                ReadOnly = true,
            };

            table.Columns.Add(column);

            column = new DataColumn()
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "firstName",
            };
            table.Columns.Add(column);

            column = new DataColumn()
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "secondName",
            };
            table.Columns.Add(column);

            Data.Tables.Add(table);
        }
    }
}
