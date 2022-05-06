using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

          
                string query = @"UPDATE artigo set  descricao=@descricao, valor_unitario=@valor_unitario, stock=@stock WHERE id_artigo =@id_artigo ";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@descricao", _artigo.descricao );
                        cmd.Parameters.AddWithValue("@valor_unitario", _artigo.valor_unitario );
                        cmd.Parameters.AddWithValue("@stock", _artigo.stock );
                        cmd.Parameters.AddWithValue("@id_artigo ", _artigo.id_artigo );
                        try
                        {
                            registo = cmd.ExecuteNonQuery();
                            return (registo, null);
                        }
                        catch (Exception e)
                        {
                            return (-1, e.Message.ToString());
                        }
                    }
                }

       


        }


        public (int registo, string erro) desactivarartigo()
        {
            int registo = 0;

            string query = @"UPDATE artigo set  ativo=0 WHERE id_artigo =@id_artigo ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id_artigo ", _artigo.id_artigo);
                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, null);
                    }
                    catch (Exception e)
                    {
                        return (-1, e.Message.ToString());
                    }
                }
            }

        }

        public (int registo, string erro) atualizarArtigStock()
        {
            int registo = 0;

            string query = @"UPDATE artigo set  stock=@stock WHERE id_artigo =@id_artigo ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();
               
                    cmd.Parameters.AddWithValue("@stock", _artigo.stock);
                    cmd.Parameters.AddWithValue("@id_artigo ", _artigo.id_artigo);
                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, null);
                    }
                    catch (Exception e)
                    {
                        return (-1, e.Message.ToString());
                    }
                }
            }

        }

        public (int registo, string erro) inserirartigo()
        {
            int registo = 0;
          
                string query = "INSERT INTO artigo (descricao, valor_unitario, stock)" +
                                               "VALUES(@descricao, @valor_unitario, @stock)";
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
                            return (registo, null);
                        }
                        catch (Exception e)
                        {
                            return (0, e.Message.ToString());
                        }
                    }
                }
        

        }


        public List<artigo> listarEspecialidadesMedica()
        {
            List<artigo> ListarArtigo = new List<artigo>();

            string query = "SELECT * FROM artigo";

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
                                 double .Parse(sdr["valor_unitario"].ToString()),
                                        double.Parse(sdr["stock"].ToString())
                                    ));
                            }
                        }
                    }
                }
            }
            return ListarArtigo;
        }
    }
}
