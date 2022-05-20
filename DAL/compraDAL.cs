using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace gestaoDeClientesArtigosTheStore.DAL
{
    public class compraDAL


    {
        private string connStr = BaseDAL.connStr;
        Models.cliente _cliente;
        public Models.cliente cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }
        Models.compra _compra;
        public Models.compra compra
        {
            get { return this._compra; }
            set { this._compra = value; }
        }

        public List<compra > listarComprasComprador()
        {
            List<compra> ListarCompra = new List<compra>();

            string query = "SELECT * FROM  compras  where id_cliente = @id_cliente";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", _cliente.id);
                    //cmd.Connection = conn;
                    conn.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                ListarCompra.Add(new compra(
                                    sdr["id_compras"].ToString(),
                                     Int32.Parse(sdr["valor"].ToString()),
                                    sdr["data"].ToString(),
                                     Int32.Parse(sdr["pontos"].ToString())));
                            }
                        }
                    }
                }
            }
            return ListarCompra;
        }



        public (int registo, string erro) inserirCompra()
        {
            int registo = 0;

            string query = "INSERT INTO  compras (id_compras, data	, id_cliente, id_funcionario )" +
                                           "VALUES(@id_compras, @data, @id_cliente, @id_funcionario)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id_compras", _compra.id_compras);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@id_cliente", _compra.id_cliente );
                    cmd.Parameters.AddWithValue("@id_funcionario", _compra.id_funcionario );

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }


        public (int registo, string erro) actualizarPontosValor()
        {
            int registo = 0;

            string query = "UPDATE compras set  id_compras=@id_compras";
            query = query + ", valor=@valor";
            query = query + ", pontos=@pontos";            
            query = query + " WHERE id_compras = @id_compras;";


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();          
                    cmd.Parameters.AddWithValue("@valor", _compra.valor );
                    cmd.Parameters.AddWithValue("@pontos", _compra.pontos );               
                    cmd.Parameters.AddWithValue("@id_compras", _compra.id_compras );
                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }


    }
}
