namespace ProjetoLifety
{
    partial class Form_Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastrar));
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_nome = new System.Windows.Forms.TextBox();
            this.txtBox_especialidade = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_confsenha = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txtBox_senha = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_confsenha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtBox_email
            // 
            this.txtBox_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_email.Location = new System.Drawing.Point(227, 46);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(223, 20);
            this.txtBox_email.TabIndex = 0;
            // 
            // txtBox_nome
            // 
            this.txtBox_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_nome.Location = new System.Drawing.Point(227, 95);
            this.txtBox_nome.Name = "txtBox_nome";
            this.txtBox_nome.Size = new System.Drawing.Size(223, 20);
            this.txtBox_nome.TabIndex = 1;
            // 
            // txtBox_especialidade
            // 
            this.txtBox_especialidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_especialidade.Location = new System.Drawing.Point(227, 233);
            this.txtBox_especialidade.Name = "txtBox_especialidade";
            this.txtBox_especialidade.Size = new System.Drawing.Size(223, 20);
            this.txtBox_especialidade.TabIndex = 4;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_nome.Location = new System.Drawing.Point(306, 72);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_senha
            // 
            this.lbl_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_senha.Location = new System.Drawing.Point(300, 118);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(61, 20);
            this.lbl_senha.TabIndex = 6;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_confsenha
            // 
            this.lbl_confsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_confsenha.AutoSize = true;
            this.lbl_confsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.lbl_confsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confsenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_confsenha.Location = new System.Drawing.Point(266, 164);
            this.lbl_confsenha.Name = "lbl_confsenha";
            this.lbl_confsenha.Size = new System.Drawing.Size(144, 20);
            this.lbl_confsenha.TabIndex = 7;
            this.lbl_confsenha.Text = "Confirmar Senha";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Location = new System.Drawing.Point(302, 23);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(59, 20);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(275, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Especialidade";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.btn_Cadastrar.Location = new System.Drawing.Point(279, 278);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(117, 34);
            this.btn_Cadastrar.TabIndex = 10;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // txtBox_senha
            // 
            this.txtBox_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_senha.Location = new System.Drawing.Point(227, 141);
            this.txtBox_senha.Name = "txtBox_senha";
            this.txtBox_senha.Size = new System.Drawing.Size(223, 20);
            this.txtBox_senha.TabIndex = 11;
            this.txtBox_senha.UseSystemPasswordChar = true;
            // 
            // txtBox_confsenha
            // 
            this.txtBox_confsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_confsenha.Location = new System.Drawing.Point(227, 187);
            this.txtBox_confsenha.Name = "txtBox_confsenha";
            this.txtBox_confsenha.Size = new System.Drawing.Size(223, 20);
            this.txtBox_confsenha.TabIndex = 12;
            this.txtBox_confsenha.UseSystemPasswordChar = true;
            // 
            // Form_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 406);
            this.Controls.Add(this.txtBox_confsenha);
            this.Controls.Add(this.txtBox_senha);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_confsenha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txtBox_especialidade);
            this.Controls.Add(this.txtBox_nome);
            this.Controls.Add(this.txtBox_email);
            this.Name = "Form_Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_nome;
        private System.Windows.Forms.TextBox txtBox_especialidade;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_confsenha;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.MaskedTextBox txtBox_senha;
        private System.Windows.Forms.MaskedTextBox txtBox_confsenha;
    }
}