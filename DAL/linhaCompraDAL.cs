using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace gestaoDeClientesArtigosTheStore.DAL
{
    public class linhaCompraDAL


    {
        private string connStr = BaseDAL.connStr;

        Models.linhaCompra _linhaCompra;
        public Models.linhaCompra linhaCompra
        {
            get { return this._linhaCompra; }
            set { this._linhaCompra = value; }
        }

        public List<linhaCompra> listarlinhaCompraById()
        {
            List<linhaCompra> ListarlinhaCompra = new List<linhaCompra>();

            string query = "SELECT A.*, (B.descricao) as ART FROM  linhascompras  as A,artigo as B  where A.id_compra = @id_compra And A.artigo = B.id_artigo ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_compra", _linhaCompra.id_compra);
                    //cmd.Connection = conn;
                    conn.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                ListarlinhaCompra.Add(new linhaCompra(Double.Parse(sdr["qdd"].ToString()), Int32 .Parse(sdr["artigo"].ToString()), sdr["ART"].ToString(), Double.Parse(sdr["total"].ToString())));
                            }
                        }
                    }
                }
            }
            return ListarlinhaCompra;
        }

    }
}
