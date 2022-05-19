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


        public (int registo, string erro) inserirlinhaCompra()
        {
            int registo = 0;

            string query = "INSERT INTO linhascompras (id_compra, qdd, artigo, total )" +
                                           "VALUES(@id_compra, @qdd, @artigo, @total)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id_compra", _linhaCompra.id_compra);
                    cmd.Parameters.AddWithValue("@qdd", _linhaCompra.qdd );
                    cmd.Parameters.AddWithValue("@artigo", _linhaCompra.artigo );
                    cmd.Parameters.AddWithValue("@total", _linhaCompra.total );

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Artigo adicionado com sucesso");
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
