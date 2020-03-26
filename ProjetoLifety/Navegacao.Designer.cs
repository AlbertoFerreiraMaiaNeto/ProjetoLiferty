namespace ProjetoLifety
{
    partial class Navegacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegacao));
            this.btn_sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sair.BackColor = System.Drawing.Color.DarkRed;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Location = new System.Drawing.Point(739, 415);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(49, 23);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.médicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarPacientesToolStripMenuItem,
            this.novoPacienteToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // listarPacientesToolStripMenuItem
            // 
            this.listarPacientesToolStripMenuItem.Name = "listarPacientesToolStripMenuItem";
            this.listarPacientesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listarPacientesToolStripMenuItem.Text = "Listar Pacientes";
            this.listarPacientesToolStripMenuItem.Click += new System.EventHandler(this.listarPacientesToolStripMenuItem_Click);
            // 
            // novoPacienteToolStripMenuItem
            // 
            this.novoPacienteToolStripMenuItem.Name = "novoPacienteToolStripMenuItem";
            this.novoPacienteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novoPacienteToolStripMenuItem.Text = "Novo Paciente";
            this.novoPacienteToolStripMenuItem.Click += new System.EventHandler(this.novoPacienteToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarConsultasToolStripMenuItem,
            this.novaConsultaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // listarConsultasToolStripMenuItem
            // 
            this.listarConsultasToolStripMenuItem.Name = "listarConsultasToolStripMenuItem";
            this.listarConsultasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarConsultasToolStripMenuItem.Text = "Listar Consultas";
            this.listarConsultasToolStripMenuItem.Click += new System.EventHandler(this.listarConsultasToolStripMenuItem_Click);
            // 
            // novaConsultaToolStripMenuItem
            // 
            this.novaConsultaToolStripMenuItem.Name = "novaConsultaToolStripMenuItem";
            this.novaConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaConsultaToolStripMenuItem.Text = "Nova Consulta";
            this.novaConsultaToolStripMenuItem.Click += new System.EventHandler(this.novaConsultaToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMédicosToolStripMenuItem});
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.médicosToolStripMenuItem.Text = "Médicos";
            // 
            // listarMédicosToolStripMenuItem
            // 
            this.listarMédicosToolStripMenuItem.Name = "listarMédicosToolStripMenuItem";
            this.listarMédicosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listarMédicosToolStripMenuItem.Text = "Listar Médicos";
            // 
            // Navegacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Navegacao";
            this.Text = "Navegacao";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaConsultaToolStripMenuItem;
    }
}