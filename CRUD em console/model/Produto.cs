using CRUD_em_console.util;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_em_console.model
{
    class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public int quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public void Cadastrar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = conectaBD.getConexao();
                string sql = "INSERT INTO prod(nome, valor, quantidade) VALUES('" + this.nome + "', " + this.valor + ", " + this.quantidade + ");";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();

            }catch(Exception e)
            {
                throw new Exception("Erro econtrado no cadastro de produto" + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}
