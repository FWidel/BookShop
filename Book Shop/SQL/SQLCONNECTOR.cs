using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Book_Shop.SQL
{
    class SQLCONNECTOR
    {
        public void SqlConnect()
        {
            using (var sqlConnection = new SqlConnection("Server=.;Database=BookShop;User Id=sa;Password = bookshop;"))
            {
                sqlConnection.Open();
                using (var command = new SqlCommand("SELECT * FROM BOOKS", sqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var BooksTitle = reader["Title"] as string;
                            MessageBox.Show(BooksTitle + " - Z bazy kurwa");
                        }
                    }
                }
            }
        }

    }
}
