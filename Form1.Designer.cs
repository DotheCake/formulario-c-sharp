namespace aula2
{
    partial class Form1
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
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_celular = new System.Windows.Forms.TextBox();
            this.txtbox_rg = new System.Windows.Forms.TextBox();
            this.txtbox_cpf = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(482, 174);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(334, 26);
            this.txtbox_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(421, 180);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(419, 221);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 20);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-Mail:";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(414, 313);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(62, 20);
            this.lbl_celular.TabIndex = 3;
            this.lbl_celular.Text = "Celular:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(432, 270);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(44, 20);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF:";
            this.lbl_cpf.Click += new System.EventHandler(this.lbl_cpf_Click);
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(649, 270);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(42, 20);
            this.lbl_rg.TabIndex = 5;
            this.lbl_rg.Text = "R.G:";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(482, 215);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(332, 26);
            this.txtbox_email.TabIndex = 6;
            // 
            // txtbox_celular
            // 
            this.txtbox_celular.Location = new System.Drawing.Point(482, 307);
            this.txtbox_celular.Name = "txtbox_celular";
            this.txtbox_celular.Size = new System.Drawing.Size(145, 26);
            this.txtbox_celular.TabIndex = 7;
            // 
            // txtbox_rg
            // 
            this.txtbox_rg.Location = new System.Drawing.Point(697, 264);
            this.txtbox_rg.Name = "txtbox_rg";
            this.txtbox_rg.Size = new System.Drawing.Size(117, 26);
            this.txtbox_rg.TabIndex = 8;
            // 
            // txtbox_cpf
            // 
            this.txtbox_cpf.Location = new System.Drawing.Point(482, 264);
            this.txtbox_cpf.Name = "txtbox_cpf";
            this.txtbox_cpf.Size = new System.Drawing.Size(147, 26);
            this.txtbox_cpf.TabIndex = 9;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(525, 361);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(244, 32);
            this.btn_enviar.TabIndex = 10;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 687);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txtbox_cpf);
            this.Controls.Add(this.txtbox_rg);
            this.Controls.Add(this.txtbox_celular);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtbox_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_celular;
        private System.Windows.Forms.TextBox txtbox_rg;
        private System.Windows.Forms.TextBox txtbox_cpf;
        private System.Windows.Forms.Button btn_enviar;
    }
}

