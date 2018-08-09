using TutorialTestSoftware;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialTestSoftware
{
    public class ClienteModel
    {

        public int ID { get; set; }
        public string NOME { get; set; }
        public string ENDERECO { get; set; }
        public string CEP { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TELEFONE { get; set; }



        //Metodo para add novo Cliente
        public int Create(ClienteModel clienteModel)
        {
            int i = 0;

            string sql = "INSERT INTO CLIENTE(NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) VALUES(@NOME, @ENDERECO, @CEP, @BAIRRO, @CIDADE, @UF, @TELEFONE)";
            DAL dal = new DAL();
            try
            {
                SqlCommand com = new SqlCommand(sql, dal.conectar());

                // com.Parameters.AddWithValue("@Id", pessoaModel.PessoaID);
                com.Parameters.AddWithValue("@NOME", clienteModel.NOME);
                com.Parameters.AddWithValue("@ENDERECO", clienteModel.ENDERECO);
                com.Parameters.AddWithValue("@CEP", clienteModel.CEP);
                com.Parameters.AddWithValue("@BAIRRO", clienteModel.BAIRRO);
                com.Parameters.AddWithValue("@CIDADE", clienteModel.CIDADE);
                com.Parameters.AddWithValue("@UF", clienteModel.UF);
                com.Parameters.AddWithValue("@TELEFONE", clienteModel.TELEFONE);

                i = com.ExecuteNonQuery();
          
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir novo Cliente!" + ex.Message.ToString());
            }
            finally
            {
                dal.fecharConexao();
            }

            return i;

        }

        //Metodo para add novo Cliente
        public int Update(ClienteModel clienteModel)
        {
            int i = 0;

            string sql = "UPDATE CLIENTE SET NOME=@NOME,ENDERECO=@ENDERECO, CEP=@CEP, BAIRRO=@BAIRRO, CIDADE=@CIDADE, UF=@UF, TELEFONE=@TELEFONE WHERE ID=@ID"; 
              
            DAL dal = new DAL();
            try
            {
                SqlCommand com = new SqlCommand(sql, dal.conectar());

                
                com.Parameters.AddWithValue("@NOME", clienteModel.NOME);
                com.Parameters.AddWithValue("@ENDERECO", clienteModel.ENDERECO);
                com.Parameters.AddWithValue("@CEP", clienteModel.CEP);
                com.Parameters.AddWithValue("@BAIRRO", clienteModel.BAIRRO);
                com.Parameters.AddWithValue("@CIDADE", clienteModel.CIDADE);
                com.Parameters.AddWithValue("@UF", clienteModel.UF);
                com.Parameters.AddWithValue("@TELEFONE", clienteModel.TELEFONE);
                com.Parameters.AddWithValue("@ID", clienteModel.ID);

                i = com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao Alterar o Cliente!" + ex.Message.ToString());
            }
            finally
            {
                dal.fecharConexao();
            }

            return i;

        }

        //Metodo para add novo Cliente
        public int Delete(ClienteModel clienteModel)
        {
            int i = 0;

            string sql = "DELETE CLIENTE WHERE ID=@ID";

            DAL dal = new DAL();
            try
            {
                SqlCommand com = new SqlCommand(sql, dal.conectar());

                com.Parameters.AddWithValue("@ID", clienteModel.ID);

                i = com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Deletar Cliente!" + ex.Message.ToString());
            }
            finally
            {
                dal.fecharConexao();
            }

            return i;

        }


    }
}
