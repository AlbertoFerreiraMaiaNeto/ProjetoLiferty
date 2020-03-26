namespace ProjetoLifety
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.linkLbl_cadastrar = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lbl_Liferty = new System.Windows.Forms.Label();
            this.lbl_subLiferty = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.mskTxt_senha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_email
            // 
            this.txtBox_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_email.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBox_email.Location = new System.Drawing.Point(292, 188);
            this.txtBox_email.Multiline = true;
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(200, 21);
            this.txtBox_email.TabIndex = 0;
            this.txtBox_email.Click += new System.EventHandler(this.txtBox_email_Click);
            // 
            // linkLbl_cadastrar
            // 
            this.linkLbl_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLbl_cadastrar.AutoSize = true;
            this.linkLbl_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.linkLbl_cadastrar.DisabledLinkColor = System.Drawing.Color.Tan;
            this.linkLbl_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_cadastrar.ForeColor = System.Drawing.SystemColors.Info;
            this.linkLbl_cadastrar.LinkColor = System.Drawing.Color.Black;
            this.linkLbl_cadastrar.Location = new System.Drawing.Point(289, 251);
            this.linkLbl_cadastrar.Name = "linkLbl_cadastrar";
            this.linkLbl_cadastrar.Size = new System.Drawing.Size(52, 13);
            this.linkLbl_cadastrar.TabIndex = 2;
            this.linkLbl_cadastrar.TabStop = true;
            this.linkLbl_cadastrar.Text = "Cadastrar";
            this.linkLbl_cadastrar.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLbl_cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_cadastrar_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.Location = new System.Drawing.Point(289, 270);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(108, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Esqueci minha senha";
            // 
            // lbl_Liferty
            // 
            this.lbl_Liferty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Liferty.AutoSize = true;
            this.lbl_Liferty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_Liferty.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Liferty.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_Liferty.Location = new System.Drawing.Point(292, 71);
            this.lbl_Liferty.Name = "lbl_Liferty";
            this.lbl_Liferty.Size = new System.Drawing.Size(200, 60);
            this.lbl_Liferty.TabIndex = 4;
            this.lbl_Liferty.Text = "LIFERTY";
            // 
            // lbl_subLiferty
            // 
            this.lbl_subLiferty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_subLiferty.AutoSize = true;
            this.lbl_subLiferty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.lbl_subLiferty.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subLiferty.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_subLiferty.Location = new System.Drawing.Point(310, 120);
            this.lbl_subLiferty.Name = "lbl_subLiferty";
            this.lbl_subLiferty.Size = new System.Drawing.Size(154, 20);
            this.lbl_subLiferty.TabIndex = 5;
            this.lbl_subLiferty.Text = "Vida e Fertilidade";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_entrar.BackColor = System.Drawing.Color.Teal;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_entrar.Location = new System.Drawing.Point(428, 259);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(64, 24);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // mskTxt_senha
            // 
            this.mskTxt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskTxt_senha.Location = new System.Drawing.Point(292, 228);
            this.mskTxt_senha.Name = "mskTxt_senha";
            this.mskTxt_senha.Size = new System.Drawing.Size(200, 20);
            this.mskTxt_senha.TabIndex = 7;
            this.mskTxt_senha.UseSystemPasswordChar = true;
            this.mskTxt_senha.Click += new System.EventHandler(this.mskTxt_senha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ProjetoLifety.Properties.Resources.ctt;
            this.pictureBox1.Location = new System.Drawing.Point(261, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ProjetoLifety.Properties.Resources.ctu1;
            this.pictureBox2.Location = new System.Drawing.Point(259, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskTxt_senha);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lbl_subLiferty);
            this.Controls.Add(this.lbl_Liferty);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLbl_cadastrar);
            this.Controls.Add(this.txtBox_email);
            this.Name = "Form1";
            this.Text = "Liferty";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.LinkLabel linkLbl_cadastrar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lbl_Liferty;
        private System.Windows.Forms.Label lbl_subLiferty;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.MaskedTextBox mskTxt_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

