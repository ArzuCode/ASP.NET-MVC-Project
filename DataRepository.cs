//using System.Collections.Generic;
//using System.Data.SqlClient;

//namespace FammsMVC.Models
//{
//    public class DataRepository
//    {
//        private readonly string _connectionString;

//        public DataRepository(string connectionString)
//        {
//            _connectionString = connectionString;
//        }

//        public List<Product> GetProducts()
//        {
//            List<Product> products = new List<Product>();

//            using (SqlConnection connection = new SqlConnection(_connectionString))
//            {
//                string query = "SELECT * FROM Products";
//                SqlCommand command = new SqlCommand(query, connection);

//                connection.Open();
//                SqlDataReader reader = command.ExecuteReader();

//                while (reader.Read())
//                {
//                    Product product = new Product
//                    {
//                        Id = (int)reader["Id"],
//                        Name = (string)reader["Name"],
//                        Price = (decimal)reader["Price"],
//                        ImagePath = (string)reader["ImagePath"]
//                    };

//                    products.Add(product);
//                }
//            }

//            return products;
//        }
//    }
//}