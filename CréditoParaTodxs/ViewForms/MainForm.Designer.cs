
namespace ViewForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rendaTextBox = new System.Windows.Forms.TextBox();
            this.rendaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.limiteCreditoLabel = new System.Windows.Forms.Label();
            this.valorCreditoTextBox = new System.Windows.Forms.TextBox();
            this.valorCreditoLabel = new System.Windows.Forms.Label();
            this.propostasGroupBox = new System.Windows.Forms.GroupBox();
            this.proposta36RadioButton = new System.Windows.Forms.RadioButton();
            this.proposta24RadioButton = new System.Windows.Forms.RadioButton();
            this.proposta12RadioButton = new System.Windows.Forms.RadioButton();
            this.detalhesLabel = new System.Windows.Forms.Label();
            this.contratarButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.propostasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(592, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarProcessoToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // reiniciarProcessoToolStripMenuItem
            // 
            this.reiniciarProcessoToolStripMenuItem.Name = "reiniciarProcessoToolStripMenuItem";
            this.reiniciarProcessoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.reiniciarProcessoToolStripMenuItem.Text = "Reiniciar Processo";
            this.reiniciarProcessoToolStripMenuItem.Click += new System.EventHandler(this.reiniciarProcessoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(166, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // rendaTextBox
            // 
            this.rendaTextBox.Location = new System.Drawing.Point(192, 74);
            this.rendaTextBox.MaxLength = 10;
            this.rendaTextBox.Name = "rendaTextBox";
            this.rendaTextBox.Size = new System.Drawing.Size(122, 23);
            this.rendaTextBox.TabIndex = 1;
            this.rendaTextBox.TextChanged += new System.EventHandler(this.rendaTextBox_TextChanged);
            this.rendaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rendaTextBox_KeyPress);
            this.rendaTextBox.Leave += new System.EventHandler(this.rendaTextBox_Leave);
            // 
            // rendaLabel
            // 
            this.rendaLabel.AutoSize = true;
            this.rendaLabel.Location = new System.Drawing.Point(12, 77);
            this.rendaLabel.Name = "rendaLabel";
            this.rendaLabel.Size = new System.Drawing.Size(171, 15);
            this.rendaLabel.TabIndex = 2;
            this.rendaLabel.Text = "Informe sua Renda Mensal (R$)";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(0, 24);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(592, 32);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Simulação de Crédito";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limiteCreditoLabel
            // 
            this.limiteCreditoLabel.AutoSize = true;
            this.limiteCreditoLabel.Location = new System.Drawing.Point(79, 125);
            this.limiteCreditoLabel.Name = "limiteCreditoLabel";
            this.limiteCreditoLabel.Size = new System.Drawing.Size(360, 15);
            this.limiteCreditoLabel.TabIndex = 4;
            this.limiteCreditoLabel.Text = "Informe sua renda mensal para saber o limite de crédito disponível.";
            // 
            // valorCreditoTextBox
            // 
            this.valorCreditoTextBox.Enabled = false;
            this.valorCreditoTextBox.Location = new System.Drawing.Point(215, 172);
            this.valorCreditoTextBox.MaxLength = 10;
            this.valorCreditoTextBox.Name = "valorCreditoTextBox";
            this.valorCreditoTextBox.Size = new System.Drawing.Size(122, 23);
            this.valorCreditoTextBox.TabIndex = 2;
            this.valorCreditoTextBox.TextChanged += new System.EventHandler(this.valorCreditoTextBox_TextChanged);
            this.valorCreditoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorCreditoTextBox_KeyPress);
            this.valorCreditoTextBox.Leave += new System.EventHandler(this.valorCreditoTextBox_Leave);
            // 
            // valorCreditoLabel
            // 
            this.valorCreditoLabel.AutoSize = true;
            this.valorCreditoLabel.Enabled = false;
            this.valorCreditoLabel.Location = new System.Drawing.Point(12, 175);
            this.valorCreditoLabel.Name = "valorCreditoLabel";
            this.valorCreditoLabel.Size = new System.Drawing.Size(197, 15);
            this.valorCreditoLabel.TabIndex = 2;
            this.valorCreditoLabel.Text = "Qual valor gostaria de contratar (R$)";
            // 
            // propostasGroupBox
            // 
            this.propostasGroupBox.Controls.Add(this.proposta36RadioButton);
            this.propostasGroupBox.Controls.Add(this.proposta24RadioButton);
            this.propostasGroupBox.Controls.Add(this.proposta12RadioButton);
            this.propostasGroupBox.Enabled = false;
            this.propostasGroupBox.Location = new System.Drawing.Point(12, 220);
            this.propostasGroupBox.Name = "propostasGroupBox";
            this.propostasGroupBox.Size = new System.Drawing.Size(339, 105);
            this.propostasGroupBox.TabIndex = 3;
            this.propostasGroupBox.TabStop = false;
            this.propostasGroupBox.Text = "Estas são as propostas disponíveis para você:";
            // 
            // proposta36RadioButton
            // 
            this.proposta36RadioButton.AutoSize = true;
            this.proposta36RadioButton.Location = new System.Drawing.Point(6, 72);
            this.proposta36RadioButton.Name = "proposta36RadioButton";
            this.proposta36RadioButton.Size = new System.Drawing.Size(84, 19);
            this.proposta36RadioButton.TabIndex = 2;
            this.proposta36RadioButton.TabStop = true;
            this.proposta36RadioButton.Text = "Proposta36";
            this.proposta36RadioButton.UseVisualStyleBackColor = true;
            this.proposta36RadioButton.CheckedChanged += new System.EventHandler(this.propostaRadioButton_CheckedChanged);
            // 
            // proposta24RadioButton
            // 
            this.proposta24RadioButton.AutoSize = true;
            this.proposta24RadioButton.Location = new System.Drawing.Point(6, 47);
            this.proposta24RadioButton.Name = "proposta24RadioButton";
            this.proposta24RadioButton.Size = new System.Drawing.Size(84, 19);
            this.proposta24RadioButton.TabIndex = 1;
            this.proposta24RadioButton.TabStop = true;
            this.proposta24RadioButton.Text = "Proposta24";
            this.proposta24RadioButton.UseVisualStyleBackColor = true;
            this.proposta24RadioButton.CheckedChanged += new System.EventHandler(this.propostaRadioButton_CheckedChanged);
            // 
            // proposta12RadioButton
            // 
            this.proposta12RadioButton.AutoSize = true;
            this.proposta12RadioButton.Location = new System.Drawing.Point(6, 22);
            this.proposta12RadioButton.Name = "proposta12RadioButton";
            this.proposta12RadioButton.Size = new System.Drawing.Size(84, 19);
            this.proposta12RadioButton.TabIndex = 0;
            this.proposta12RadioButton.TabStop = true;
            this.proposta12RadioButton.Text = "Proposta12";
            this.proposta12RadioButton.UseVisualStyleBackColor = true;
            this.proposta12RadioButton.CheckedChanged += new System.EventHandler(this.propostaRadioButton_CheckedChanged);
            // 
            // detalhesLabel
            // 
            this.detalhesLabel.AutoSize = true;
            this.detalhesLabel.Location = new System.Drawing.Point(12, 356);
            this.detalhesLabel.Name = "detalhesLabel";
            this.detalhesLabel.Size = new System.Drawing.Size(186, 15);
            this.detalhesLabel.TabIndex = 4;
            this.detalhesLabel.Text = "Detalhes da proposta selecionada.";
            this.detalhesLabel.Visible = false;
            // 
            // contratarButton
            // 
            this.contratarButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contratarButton.Location = new System.Drawing.Point(0, 421);
            this.contratarButton.Name = "contratarButton";
            this.contratarButton.Size = new System.Drawing.Size(592, 23);
            this.contratarButton.TabIndex = 5;
            this.contratarButton.Text = "Contratar";
            this.contratarButton.UseVisualStyleBackColor = true;
            this.contratarButton.Click += new System.EventHandler(this.contratarButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 444);
            this.Controls.Add(this.contratarButton);
            this.Controls.Add(this.propostasGroupBox);
            this.Controls.Add(this.detalhesLabel);
            this.Controls.Add(this.limiteCreditoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.valorCreditoLabel);
            this.Controls.Add(this.rendaLabel);
            this.Controls.Add(this.valorCreditoTextBox);
            this.Controls.Add(this.rendaTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CréditoParaTodxs";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.propostasGroupBox.ResumeLayout(false);
            this.propostasGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarProcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.TextBox rendaTextBox;
        private System.Windows.Forms.Label rendaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label limiteCreditoLabel;
        private System.Windows.Forms.TextBox valorCreditoTextBox;
        private System.Windows.Forms.Label valorCreditoLabel;
        private System.Windows.Forms.GroupBox propostasGroupBox;
        private System.Windows.Forms.RadioButton proposta12RadioButton;
        private System.Windows.Forms.RadioButton proposta36RadioButton;
        private System.Windows.Forms.RadioButton proposta24RadioButton;
        private System.Windows.Forms.Label detalhesLabel;
        private System.Windows.Forms.Button contratarButton;
    }
}

