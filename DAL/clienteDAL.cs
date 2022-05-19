using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace gestaoDeClientesArtigosTheStore.DAL
{

    public class clienteDAL
    {
        private string connStr = BaseDAL.connStr;


        Models.cliente _cliente;
        public Models.cliente cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }


        //public (int registo, string erro) inserirCliente()
        //{
        //    int registo = 0;
        //    string query = "INSERT INTO clientes ( nome, morada,	 telefone, e_mail,contribuinte, localidade, num_cartao, fotografia, pass, ativo)" +
        //                                   "VALUES( @nome, @morada,	 @telefone, @e_mail,@contribuinte, @localidade, @num_cartao, @fotografia, @pass,  1)";
        //    using (MySqlConnection conn = new MySqlConnection(connStr))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(query))
        //        {
        //            cmd.Connection = conn;
        //            conn.Open();
        //            cmd.Parameters.AddWithValue("@nome", _cliente .nome );
        //            cmd.Parameters.AddWithValue("@morada", _cliente.morada);
        //            cmd.Parameters.AddWithValue("@telefone", _cliente.telefone );
        //            cmd.Parameters.AddWithValue("@e_mail", _cliente.e_mail);
        //            cmd.Parameters.AddWithValue("@contribuinte", _cliente.contribuinte  );
        //            cmd.Parameters.AddWithValue("@localidade", _cliente.localidade );
        //            cmd.Parameters.AddWithValue("@num_cartao", _cliente.num_cartao );
        //            cmd.Parameters.AddWithValue("@fotografia", _cliente.fotografia);
        //            try
        //            {
        //                registo = cmd.ExecuteNonQuery();
        //                return (registo, "Cliente adicionado com sucesso");
        //            }
        //            catch (Exception e)
        //            {
        //                return (0, e.Message.ToString());
        //            }
        //        }
        //    }
        //}

        public (int registo, string erro) actualizarCliente()
        {
            int registo = 0;

            string query = "UPDATE clientes set  nome=@nome";               
            query = query + ", nome=@nome";
            query = query + ", morada=@nome";
            query = query + ", telefone=@telefone";
            query = query + ", e_mail=@e_mail";
            query = query + ", contribuinte=@contribuinte";
            query = query + ", localidade=@localidade";
            query = query + " WHERE id = @id;";


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@nome", _cliente.nome);
                    cmd.Parameters.AddWithValue("@morada", _cliente.morada);
                    cmd.Parameters.AddWithValue("@telefone", _cliente.telefone);
                    cmd.Parameters.AddWithValue("@e_mail", _cliente.e_mail);
                    cmd.Parameters.AddWithValue("@contribuinte", _cliente.contribuinte);
                    cmd.Parameters.AddWithValue("@localidade", _cliente.localidade);
                    cmd.Parameters.AddWithValue("@id", _cliente.id );
                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Cliente actualizado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }

        public (int registo, string erro) desactivarCliente()
        {
            int registo = 0;

            string query = "UPDATE clientes set  ativo=0 WHERE id = @id;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", _cliente.id);

                    try
                    {
                        registo = cmd.ExecuteNonQuery();
                        return (registo, "Cliente desativado com sucesso");
                    }
                    catch (Exception e)
                    {
                        return (0, e.Message.ToString());
                    }
                }
            }


        }

        public List<cliente> listarClientesActivos()
        {
            List<cliente> ListarCliente = new List<cliente>();

            string query = "SELECT * FROM  clientes Where ativo = 1";

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
                                ListarCliente.Add(new cliente(
                                    Int32.Parse(sdr["id"].ToString()),
                                    sdr["nome"].ToString(),
                                    sdr["morada"].ToString(),
                                    sdr["telefone"].ToString(),
                                    sdr["e_mail"].ToString(),
                                    sdr["contribuinte"].ToString(),
                                    sdr["localidade"].ToString(), 
                                Int32.Parse(sdr["num_cartao"].ToString()), 
                                sdr["fotografia"].ToString()));
                            }

                   


                        }
                    }
                }
            }
            return ListarCliente;
        }


        public string obterClienteByContacto()
        {
            string resultadoId = "";

            string query = "SELECT * FROM  clientes Where ativo = 1 And telefone=@telefone";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@telefone", _cliente.telefone);
                    //cmd.Connection = conn;
                    conn.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {

                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                resultadoId = sdr["id"].ToString();
                            }
                        }
                    }
                }
            }
            return resultadoId;
        }


    }
}
