namespace pjt_iniciacao_217
{
    partial class frm_TelaInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaInicio));
            this.Termos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkTermo = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoSangue = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.cep = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.TextEndereco = new System.Windows.Forms.Label();
            this.agendamento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Termos
            // 
            this.Termos.AutoSize = true;
            this.Termos.BackColor = System.Drawing.Color.Transparent;
            this.Termos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Termos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Termos.Cursor = System.Windows.Forms.Cursors.Default;
            this.Termos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Termos.Location = new System.Drawing.Point(238, 589);
            this.Termos.Name = "Termos";
            this.Termos.Size = new System.Drawing.Size(411, 24);
            this.Termos.TabIndex = 4;
            this.Termos.Text = "Concordo com os termos de autorização e de responsabilidade";
            this.Termos.UseVisualStyleBackColor = false;
            this.Termos.CheckedChanged += new System.EventHandler(this.Termos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agendamento: Banco de Sangue";
            // 
            // linkTermo
            // 
            this.linkTermo.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkTermo.AutoSize = true;
            this.linkTermo.BackColor = System.Drawing.Color.Transparent;
            this.linkTermo.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkTermo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTermo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkTermo.Location = new System.Drawing.Point(655, 592);
            this.linkTermo.Name = "linkTermo";
            this.linkTermo.Size = new System.Drawing.Size(57, 17);
            this.linkTermo.TabIndex = 6;
            this.linkTermo.TabStop = true;
            this.linkTermo.Text = "Termos";
            this.linkTermo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTermo_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome completo";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(92, 141);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(233, 26);
            this.nome.TabIndex = 8;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de Nascimento";
            // 
            // nascimento
            // 
            this.nascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.nascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimento.Location = new System.Drawing.Point(92, 220);
            this.nascimento.Name = "nascimento";
            this.nascimento.Size = new System.Drawing.Size(97, 20);
            this.nascimento.TabIndex = 10;
            this.nascimento.ValueChanged += new System.EventHandler(this.nascimento_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Sanguineo";
            // 
            // tipoSangue
            // 
            this.tipoSangue.Cursor = System.Windows.Forms.Cursors.Default;
            this.tipoSangue.FormattingEnabled = true;
            this.tipoSangue.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B-",
            "B+",
            "AB+",
            "AB-"});
            this.tipoSangue.Location = new System.Drawing.Point(92, 297);
            this.tipoSangue.Name = "tipoSangue";
            this.tipoSangue.Size = new System.Drawing.Size(121, 21);
            this.tipoSangue.TabIndex = 12;
            this.tipoSangue.SelectedIndexChanged += new System.EventHandler(this.tipoSangue_SelectedIndexChanged);
            // 
            // txtCep
            // 
            this.txtCep.AutoSize = true;
            this.txtCep.BackColor = System.Drawing.Color.Transparent;
            this.txtCep.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(679, 125);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(136, 22);
            this.txtCep.TabIndex = 13;
            this.txtCep.Text = "CEP (xxxxx-xx)";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.BackColor = System.Drawing.Color.Transparent;
            this.txtEstado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(683, 265);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(89, 22);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.Text = "ESTADO";
            // 
            // txtCidade
            // 
            this.txtCidade.AutoSize = true;
            this.txtCidade.BackColor = System.Drawing.Color.Transparent;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(681, 335);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(84, 22);
            this.txtCidade.TabIndex = 15;
            this.txtCidade.Text = "CIDADE";
            // 
            // txtBairro
            // 
            this.txtBairro.AutoSize = true;
            this.txtBairro.BackColor = System.Drawing.Color.Transparent;
            this.txtBairro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(681, 405);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(85, 22);
            this.txtBairro.TabIndex = 16;
            this.txtBairro.Text = "BAIRRO";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(685, 290);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 20);
            this.estado.TabIndex = 18;
            this.estado.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(685, 360);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(100, 20);
            this.cidade.TabIndex = 19;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(685, 430);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(100, 20);
            this.bairro.TabIndex = 21;
            this.bairro.TextChanged += new System.EventHandler(this.bairro_TextChanged);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastro.Enabled = false;
            this.btnCadastro.Location = new System.Drawing.Point(888, 584);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(101, 28);
            this.btnCadastro.TabIndex = 23;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(683, 150);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(103, 20);
            this.cep.TabIndex = 24;
            this.cep.TextChanged += new System.EventHandler(this.cep_TextChanged);
            this.cep.Leave += new System.EventHandler(this.cep_Leave);
            // 
            // Endereco
            // 
            this.Endereco.Location = new System.Drawing.Point(683, 220);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(102, 20);
            this.Endereco.TabIndex = 25;
            this.Endereco.TextChanged += new System.EventHandler(this.Endereco_TextChanged);
            // 
            // TextEndereco
            // 
            this.TextEndereco.AutoSize = true;
            this.TextEndereco.BackColor = System.Drawing.Color.Transparent;
            this.TextEndereco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEndereco.Location = new System.Drawing.Point(682, 195);
            this.TextEndereco.Name = "TextEndereco";
            this.TextEndereco.Size = new System.Drawing.Size(119, 22);
            this.TextEndereco.TabIndex = 26;
            this.TextEndereco.Text = "ENDEREÇO";
            // 
            // agendamento
            // 
            this.agendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.agendamento.Location = new System.Drawing.Point(92, 385);
            this.agendamento.Name = "agendamento";
            this.agendamento.Size = new System.Drawing.Size(97, 20);
            this.agendamento.TabIndex = 10;
            this.agendamento.TabStop = false;
            this.agendamento.ValueChanged += new System.EventHandler(this.agendamento_ValueChanged_1);
            this.agendamento.VisibleChanged += new System.EventHandler(this.agendamento_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Data de Agendamento";
            // 
            // frm_TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 629);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agendamento);
            this.Controls.Add(this.TextEndereco);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.tipoSangue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkTermo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Termos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_TelaInicio";
            this.Text = "UNI-GGDI ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Termos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkTermo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker nascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoSangue;
        private System.Windows.Forms.Label txtCep;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Label txtCidade;
        private System.Windows.Forms.Label txtBairro;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.Label TextEndereco;
        private System.Windows.Forms.DateTimePicker agendamento;
        private System.Windows.Forms.Label label5;
    }
}

