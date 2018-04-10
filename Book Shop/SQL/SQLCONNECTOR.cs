using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Drawing;
namespace Book_Shop.SQL
{
    class SQLCONNECTOR
    {
        public Store store = new Store();


        public void SqlConnect()
        {
            store.Items = new List<Item>();

            using (var sqlConnection = new SqlConnection("Server=.;Database=BookShop;User Id=sa;Password = bookshop;"))
            {
                sqlConnection.Open();
                using (var command = new SqlCommand("SELECT * FROM BOOKS", sqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item tempItem = new Item();
                            tempItem.Title = reader["Title"] as string;
                            tempItem.Prize = Convert.ToDouble(reader["Price"]);
                            string imageName = reader["BookImage"] as string;
                            tempItem.BookImage = Properties.Resources.ResourceManager.GetObject(imageName) as Bitmap;
                            tempItem.Author = reader["Author"] as string;
                            tempItem.Description = reader["BookDescription"] as string;
                            tempItem.Owner = new Vendor();
                            tempItem.Sold = Convert.ToBoolean(reader["Sold"]);

                            store.Items.Add(tempItem);
                        }
                    }
                }
            }
        }

    }
}
