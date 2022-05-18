using gestaoDeClientesArtigosTheStore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace gestaoDeClientesArtigosTheStore.DAL
{

    public class cartaoDAL
    {
        private string connStr = BaseDAL.connStr;

        Models.cliente _cliente;
        public Models.cliente cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }
        public Models.cartao _cartao
        {
            get { return this._cartao; }
            set { this._cartao = value; }
        }

        public (string erro, string descricaoErro, string numeroCartao, string numeroPontos) listarFuncionarioActivos()
        {
            List<cliente> ListarCliente = new List<cliente>();

            string query = "SELECT num_cartao, pontos	 FROM  cartao id_cliente = @id_cliente;

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



    }
}
