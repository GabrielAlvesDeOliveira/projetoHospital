using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Correios.Net;

namespace pjt_iniciacao_217
{
    public partial class frm_TelaInicio : Form
    {
        public frm_TelaInicio()
        {
            InitializeComponent();
        }

        public void verdadeiro()
        {
            if (Termos.Checked != false && nome.Text != "" && tipoSangue.Text != "" && cep.Text != "" && Endereco.Text != "" && estado.Text != "" && cidade.Text != "" && bairro.Text != "" && nascimento.MaxDate == DateTime.Today.AddYears(-16) && agendamento.Checked) 
            {
                btnCadastro.Enabled = true;
            }
            else
            {
                btnCadastro.Enabled = false;
            }
        }

        private void linkTermo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1EKrZVlSOy7RFJEFWeC4_ZmEcKU-Hozj-/view?ths=true");
        }

        private void Termos_CheckedChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void cep_Leave(object sender, EventArgs e)
        {            
            using (var ws = new WSCorreios.AtendeClienteClient())
                {
                try{ 
                    var resultado = ws.consultaCEP(cep.Text);
                    Endereco.Text = resultado.end;
                    cidade.Text = resultado.cidade;
                    bairro.Text = resultado.bairro;
                    estado.Text = resultado.uf;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void tipoSangue_SelectedIndexChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void cep_TextChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void nascimento_ValueChanged_1(object sender, EventArgs e)
        {

            nascimento.MinDate = DateTime.Today.AddYears(-69);
            nascimento.MaxDate = DateTime.Today.AddYears(-16);

            verdadeiro();
        }

        private void agendamento_ValueChanged_1(object sender, EventArgs e)
        {

            agendamento.MaxDate = DateTime.Today.AddYears(1);
            agendamento.MinDate = DateTime.Today.AddDays(7);
            verdadeiro();
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {

            /*SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NP7A0NA;Initial Catalog=tempdb;Integrated Security=True");

            string sql = "INSERT INTO bs(nome, nascimento, sangue, endereco, agendado) VALUES(@nome, @nascimento, @sangue, @endereco, @agendado)";

            try
            {
                SqlCommand bd = new SqlCommand(sql, conn);

                bd.Parameters.Add(new SqlParameter("@nome", this.nome.Text));
                bd.Parameters.Add(new SqlParameter("@nascimento", this.nascimento.Value));
                bd.Parameters.Add(new SqlParameter("@sangue", this.tipoSangue.Text));
                bd.Parameters.Add(new SqlParameter("@endereco", this.Endereco.Text + ", "+ this.bairro.Text + ", " + this.cidade.Text + ", " + this.estado.Text + ", " + this.cep.Text));
                bd.Parameters.Add(new SqlParameter("@agendado", this.agendamento.Value));

                conn.Open();

                bd.ExecuteNonQuery();

                conn.Close();
            */
                MessageBox.Show(nome.Text + " você marcou seus dados para doar sangue no dia " + agendamento.Text + ", comparecer entre 8hrs e 14hrs no Banco de Sangue da Uni-GGDI", "AGENDADO");
            /*
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ocorreu um erro" + ex, "ERROR");
            }*/
        }
            
        private void Endereco_TextChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void estado_TextChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void cidade_TextChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }

        private void bairro_TextChanged(object sender, EventArgs e)
        {
            verdadeiro();
        }
    }
}

