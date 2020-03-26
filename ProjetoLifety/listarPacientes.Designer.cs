namespace ProjetoLifety
{
    partial class listarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listarPacientes));
            this.txtBox_pesquisar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_pesquisar
            // 
            this.txtBox_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBox_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pesquisar.Location = new System.Drawing.Point(12, 47);
            this.txtBox_pesquisar.Multiline = true;
            this.txtBox_pesquisar.Name = "txtBox_pesquisar";
            this.txtBox_pesquisar.Size = new System.Drawing.Size(363, 33);
            this.txtBox_pesquisar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 403);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pesquisar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_pesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pesquisar.Location = new System.Drawing.Point(381, 47);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(110, 33);
            this.btn_pesquisar.TabIndex = 6;
            this.btn_pesquisar.Text = "pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_deletar.ForeColor = System.Drawing.Color.Black;
            this.btn_deletar.Location = new System.Drawing.Point(497, 48);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(115, 33);
            this.btn_deletar.TabIndex = 7;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            // 
            // listarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 520);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBox_pesquisar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "listarPacientes";
            this.Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_deletar;
    }
}