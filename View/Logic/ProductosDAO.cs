using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductosDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        public ProductosDAO()
        {
            this.connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True";
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {
                string command = "INSERT INTO Productos(nombre, precio, codigo) " +
                "VALUES(@nombre, @precio, @codigo)";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(sqlConnection != null && 
                    sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public void ModificarProducto(Producto producto)
        {
            try
            {
                string command = "UPDATE Productos SET nombre = @nombre, precio = @precio, codigo = @codigo WHERE id = @id";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                sqlCommand.Parameters.AddWithValue("id", producto.Id);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public void EliminarProductoPorId(int id)
        {
            try
            {
                string command = $"DELETE FROM Productos WHERE id = @id";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public List<Producto> ListarProductos()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Producto> productos = new List<Producto>();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;
                    if(reader["descripcion"] != DBNull.Value)
                        descripcion = (string)reader["descripcion"];
                    float precio = (float) Convert.ToDouble(reader["precio"]);

                    Producto prod = new Producto(id, codigo, nombre, precio);
                    productos.Add(prod);
                }

                return productos;
            }
        }

        public Producto ListarPorId(int id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos WHERE id =@id";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();


                Producto producto = null;
                if (reader.Read())
                {
                    int idAux = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;
                    if (reader["descripcion"] != DBNull.Value)
                        descripcion = (string)reader["descripcion"];
                    float precio = (float)Convert.ToDouble(reader["precio"]);

                    producto = new Producto(idAux, codigo, nombre, precio);
                }
                return producto;

            }
        }
    }
}
