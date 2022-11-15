
namespace Crud2.Main
{
    partial class OcupacaoConsultaForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigocboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigocboTextBox = new System.Windows.Forms.TextBox();
            this.consultarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NovoOcupacaoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AlterarOcupacaoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExcluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.codigocboDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(409, 272);
            this.dataGridView1.TabIndex = 1;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigocboDataGridViewTextBoxColumn
            // 
            this.codigocboDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codigocboDataGridViewTextBoxColumn.DataPropertyName = "Codigocbo";
            this.codigocboDataGridViewTextBoxColumn.HeaderText = "CODIGO CBO";
            this.codigocboDataGridViewTextBoxColumn.Name = "codigocboDataGridViewTextBoxColumn";
            this.codigocboDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigocboDataGridViewTextBoxColumn.Width = 99;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Crud2.Main.Domain.Ocupacao);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(194, 15);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NomeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO CBO:";
            // 
            // CodigocboTextBox
            // 
            this.CodigocboTextBox.Location = new System.Drawing.Point(194, 42);
            this.CodigocboTextBox.Name = "CodigocboTextBox";
            this.CodigocboTextBox.Size = new System.Drawing.Size(209, 20);
            this.CodigocboTextBox.TabIndex = 3;
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(317, 12);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(86, 23);
            this.consultarButton.TabIndex = 4;
            this.consultarButton.Text = "CONSULTAR";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoOcupacaoToolStripButton,
            this.AlterarOcupacaoToolStripButton,
            this.ExcluirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(409, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NovoOcupacaoToolStripButton
            // 
            this.NovoOcupacaoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NovoOcupacaoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NovoOcupacaoToolStripButton.Name = "NovoOcupacaoToolStripButton";
            this.NovoOcupacaoToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.NovoOcupacaoToolStripButton.Text = "Novo";
            this.NovoOcupacaoToolStripButton.Click += new System.EventHandler(this.NovoOcupacaoToolStripButton_Click);
            // 
            // AlterarOcupacaoToolStripButton
            // 
            this.AlterarOcupacaoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlterarOcupacaoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarOcupacaoToolStripButton.Name = "AlterarOcupacaoToolStripButton";
            this.AlterarOcupacaoToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.AlterarOcupacaoToolStripButton.Text = "Alterar";
            this.AlterarOcupacaoToolStripButton.Click += new System.EventHandler(this.AlterarOcupacaoToolStripButton_Click);
            // 
            // ExcluirToolStripButton
            // 
            this.ExcluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            this.ExcluirToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.ExcluirToolStripButton.Text = "Excluir";
            this.ExcluirToolStripButton.Click += new System.EventHandler(this.ExcluirToolStripButton_Click);
            // 
            // OcupacaoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.CodigocboTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OcupacaoConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Ocupação";
            this.Load += new System.EventHandler(this.OcupacaoConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigocboTextBox;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocboDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NovoOcupacaoToolStripButton;
        private System.Windows.Forms.ToolStripButton AlterarOcupacaoToolStripButton;
        private System.Windows.Forms.ToolStripButton ExcluirToolStripButton;
    }
}

