using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace lab1
{
    public class DBManager
    {
        private string dbFile = "Shop.sqlite";
        private string connectionString;

        public DBManager()
        {
            connectionString = "Data Source=" + dbFile;
        }

        public void InitializeDatabase()
        {
            try
            {
                bool dbExists = File.Exists(dbFile);

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    RunSql(connection, "PRAGMA foreign_keys = ON;");
                    RunSql(connection, "PRAGMA case_sensitive_like = ON;");

                    if (!dbExists)
                    {
                        RunSql(connection, @"
                            CREATE TABLE Category (
                            ID_cat INT PRIMARY KEY NOT NULL,
                            name TEXT NOT NULL,
                            description TEXT
                            );");

                        RunSql(connection, @"
                            CREATE TABLE Product (
                            ID_prod INT PRIMARY KEY NOT NULL,
                            name TEXT NOT NULL,
                            price REAL NOT NULL,
                            unit TEXT NOT NULL,
                            category INT,
                            FOREIGN KEY (category) REFERENCES Category(ID_cat)
                            );");

                        RunSql(connection, @"
                            CREATE TRIGGER Update_cat_ID AFTER UPDATE ON Category
                            BEGIN
                                UPDATE Product SET category = new.ID_cat WHERE category = old.ID_cat;
                            END;");

                        RunSql(connection, @"
                            CREATE TRIGGER Delete_category AFTER DELETE ON Category
                            BEGIN
                                UPDATE Product SET Category = NULL WHERE Category = old.ID_cat;
                            END;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка створення БД. " + ex.Message);
            }
        }

        private void RunSql(SqliteConnection connection, string sql)
        {
            SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public void InsertCategory(int id, string name, string description)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                RunSql(connection, "PRAGMA foreign_keys = ON;");

                string sql = "INSERT INTO Category (ID_cat, name, description) VALUES (" + id + ", '" + name + "', '" + description + "');";
                RunSql(connection, sql);
            }
        }

        public void InsertProduct(int id, string name, double price, string unit, int categoryId)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                RunSql(connection, "PRAGMA foreign_keys = ON;");

                string sql = "INSERT INTO Product (ID_prod, name, price, unit, category) VALUES (" + id + ", '" + name + "', " + price.ToString(CultureInfo.InvariantCulture) + ", '" + unit + "', " + categoryId + ");";
                RunSql(connection, sql);
            }
        }

        public void UpdateCategoryId(int oldId, int newId)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                RunSql(connection, "PRAGMA foreign_keys = ON;");

                string sql = "UPDATE Category SET ID_cat = " + newId + " WHERE ID_cat = " + oldId + ";";
                RunSql(connection, sql);
            }
        }

        public void DeleteCategory(int categoryId)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                RunSql(connection, "PRAGMA foreign_keys = ON;");

                string sql = "DELETE FROM Category WHERE ID_cat = " + categoryId + ";";
                RunSql(connection, sql);
            }
        }

        public DataTable GetCategories()
        {
            DataTable table = new DataTable();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand("SELECT * FROM Category;", connection);
                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            return table;
        }

        public DataTable GetProducts()
        {
            DataTable table = new DataTable();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand("SELECT * FROM Product;", connection);
                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            return table;
        }
    }
}