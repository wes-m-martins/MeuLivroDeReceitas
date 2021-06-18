
namespace MeuLivroDeReceitas
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeAtu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dateTimeCria = new System.Windows.Forms.DateTimePicker();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimeAtu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Controls.Add(this.dateTimeCria);
            this.panel1.Controls.Add(this.txtTempo);
            this.panel1.Controls.Add(this.txtReceita);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 243);
            this.panel1.TabIndex = 1;
            // 
            // dateTimeAtu
            // 
            this.dateTimeAtu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimeAtu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAtu.Location = new System.Drawing.Point(408, 39);
            this.dateTimeAtu.Name = "dateTimeAtu";
            this.dateTimeAtu.Size = new System.Drawing.Size(136, 23);
            this.dateTimeAtu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Atualização :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de Criação : ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(210, 194);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 37);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar Alteração";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(408, 194);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(136, 36);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "Apagar Receita";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(70, 68);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(474, 120);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descriçâo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo de Preparo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Receita : ";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(10, 194);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(124, 37);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // dateTimeCria
            // 
            this.dateTimeCria.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimeCria.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCria.Location = new System.Drawing.Point(115, 39);
            this.dateTimeCria.Name = "dateTimeCria";
            this.dateTimeCria.Size = new System.Drawing.Size(166, 23);
            this.dateTimeCria.TabIndex = 2;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(443, 10);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(101, 23);
            this.txtTempo.TabIndex = 1;
            // 
            // txtReceita
            // 
            this.txtReceita.Location = new System.Drawing.Point(70, 10);
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(252, 23);
            this.txtReceita.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 266);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(546, 150);
            this.grid.TabIndex = 2;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 428);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtReceita;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DateTimePicker dateTimeCria;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeAtu;
        private System.Windows.Forms.Label label5;
    }
}

