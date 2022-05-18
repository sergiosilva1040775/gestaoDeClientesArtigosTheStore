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
        public Models.compra _compra
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
                                    Int32.Parse(sdr["id_compras"].ToString()),
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


    }
}
