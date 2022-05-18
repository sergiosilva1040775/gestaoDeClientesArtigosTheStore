using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestaoDeClientesArtigosTheStore.DAL
{
    public class funcionarioDAL


    {
        private string connStr = BaseDAL.connStr;


        Models.funcionario _funcionario;
        public Models.funcionario funcionario
        {
            get { return this._funcionario; }
            set { this._funcionario = value; }
        }


        public (int registo, string erro) inserirFuncionario()
        {
            int registo = 0;

            string query = "INSERT INTO funcionario (numfuncionario, pass, nome,	contacto, ativo )" +
                                           "VALUES(@numfuncionario, @pass, @nome,	@contacto,  1)";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@numfuncionario", _funcionario.numfuncionario);
                    cmd.Parameters.AddWithValue("@pass", _funcionario.pass);
                    cmd.Parameters.AddWithValue("@nome", _funcionario.nome);                
                    cmd.Parameters.AddWithValue("@contacto", _funcionario.contacto);

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Funcionario adicionado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }
       
        public (int registo, string erro) actualizarFuncionario()
        {
            int registo = 0;

             string query = "UPDATE funcionario set  numfuncionario=@numfuncionario, pass=@pass, nome=@nome , contacto=@contacto WHERE id = @id;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@numfuncionario", _funcionario.numfuncionario);
                    cmd.Parameters.AddWithValue("@pass", _funcionario.pass);
                    cmd.Parameters.AddWithValue("@nome", _funcionario.nome);
                    cmd.Parameters.AddWithValue("@contacto", _funcionario.contacto);
                    cmd.Parameters.AddWithValue("@id", _funcionario.id );

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Funcionario adicionado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }

        public (int registo, string erro) desactivarFuncionario()
        {
            int registo = 0;

            string query = "UPDATE funcionario set  ativo=0 WHERE id = @id;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

     
                    cmd.Parameters.AddWithValue("@id", _funcionario.id);

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Funcionario adicionado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }

        public List<funcionario> listarFuncionarioActivos()
        {
            List<funcionario> ListarFuncionario = new List<funcionario>();

            string query = "SELECT * FROM  funcionario Where ativo = 1";

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
                                ListarFuncionario.Add(new funcionario(
                                    Int32.Parse(sdr["id"].ToString()),
                                    Int32.Parse(sdr["numfuncionario"].ToString()), "",
                                    sdr["nome"].ToString(),
                                    sdr["contacto"].ToString()));
                            }
                        }
                    }
                }
            }
            return ListarFuncionario;
        }

    }
}
