using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.DAL
{

    public class artigoDAL
    {
        private string connStr = BaseDAL.connStr;

        Models.artigo _artigo;
        public Models.artigo artigo
        {
            get { return this._artigo; }
            set { this._artigo = value; }
        }

        public (int registo, string erro) atualizarArtigoInformacaoGeral()
        {
            int registo = 0;


            string query = "UPDATE artigo set  descricao=@descricao, valor_unitario=@valor_unitario, stock=@stock WHERE id_artigo = @id_artigo;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@descricao", _artigo.descricao);
                    cmd.Parameters.AddWithValue("@valor_unitario", _artigo.valor_unitario);    
                    cmd.Parameters.AddWithValue("@stock", _artigo.stock);
                    cmd.Parameters.AddWithValue("@id_artigo", _artigo.id_artigo);             
                    cmd.Connection = conn;
                    conn.Open();
                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Artigo actualizado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (-1, e.Message.ToString());
                    }
                }
            }




        }


        public (int registo, string erro) desactivarArtigo()
        {
            int registo = 0;

            string query = @"UPDATE artigo set  ativo=0 WHERE id_artigo =@id_artigo ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id_artigo", _artigo.id_artigo);
                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Artigo desativado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (-1, e.Message.ToString());
                    }
                }
            }

        }

   
        public (int registo, string erro) inserirArtigo()
        {
            int registo = 0;

            string query = "INSERT INTO artigo (descricao, valor_unitario, stock, ativo )" +
                                           "VALUES(@descricao, @valor_unitario, @stock, 1)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@descricao", _artigo.descricao);
                    cmd.Parameters.AddWithValue("@valor_unitario", _artigo.valor_unitario);
                    cmd.Parameters.AddWithValue("@stock", _artigo.stock);
                    cmd.Parameters.AddWithValue("@id_artigo ", _artigo.id_artigo);

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


        public List<artigo> listarArtigosActivos()
        {
            List<artigo> ListarArtigo = new List<artigo>();

            string query = "SELECT * FROM artigo Where ativo = 1";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    //cmd.Connection = conn;
                    conn.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                ListarArtigo.Add(new artigo(
                                    Int32.Parse(sdr["id_artigo"].ToString()),
                                    sdr["descricao"].ToString(),
                                 double.Parse(sdr["valor_unitario"].ToString()),
                                        double.Parse(sdr["stock"].ToString())
                                    ));
                            }
                        }
                    }
                }
            }
            return ListarArtigo;
        }


        public (int registo, string erro) atualizarArtigStock()
        {
            double stockanterior = 0;
            double stockActualizado = 0;

            string query = "SELECT stock FROM artigo Where ativo = 1 And id_artigo = @id_artigo;";


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                 
                    cmd.Parameters.AddWithValue("@id_artigo", _artigo.id_artigo);
 
                    conn.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                stockanterior = double .Parse( sdr["stock"].ToString());
                             
                            }
                        }
                    }


                    stockActualizado = stockanterior - _artigo.stock;

                    int registo = 0;


                    string query_update = "UPDATE artigo set stock = @stock  where id_artigo = @id_artigo;";


                    using (MySqlConnection conn_update = new MySqlConnection(connStr))
                    {
                        using (MySqlCommand cmd_update = new MySqlCommand(query_update))
                        {
                            cmd_update.Connection = conn_update;
                            conn_update.Open();
                            cmd_update.Parameters.AddWithValue("@id_artigo", _artigo.id_artigo );
                            cmd_update.Parameters.AddWithValue("@stock", stockActualizado);
                            try
                            {
                                registo = cmd_update.ExecuteNonQuery();
                                return (registo, "Stock actualizado com sucesso");

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



        public artigo listarArtigosActivosById()
        {
          

            string query = "SELECT * FROM artigo Where ativo = 1 And id_artigo = @id_artigo;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_artigo", _artigo.id_artigo);
                    //cmd.Connection = conn;
                    conn.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                artigo.id_artigo = Int32.Parse(sdr["id_artigo"].ToString());
                                artigo.descricao = sdr["descricao"].ToString();
                                artigo.valor_unitario = double.Parse(sdr["valor_unitario"].ToString());
                                artigo.stock = double.Parse(sdr["stock"].ToString());
                                
                            }
                        }
                    }
                }
            }
            return artigo;
        }

    }
}
