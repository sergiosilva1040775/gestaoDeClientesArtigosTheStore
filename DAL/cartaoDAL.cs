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

        public ( string numeroCartao, string numeroPontos) obterPontosCartao()
        {
            List<cliente> ListarCliente = new List<cliente>();
            string numeroCartao="X";
            string numeroPontos = "X";
            string query = "SELECT num_cartao, pontos	 FROM  cartao where id_cliente = @id_cliente";

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
                                numeroCartao = sdr["num_cartao"].ToString();
                                numeroPontos = sdr["pontos"].ToString();
                                   }
                        }
                    }
                }
            }
            return ( numeroCartao, numeroPontos);
        }



    }
}
