
namespace Tela_Cadastro_Visitante
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstVisitantes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioNome = new System.Windows.Forms.RadioButton();
            this.radioRG = new System.Windows.Forms.RadioButton();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(420, 5, 420, 5);
            this.label1.Size = new System.Drawing.Size(1041, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa de Visitantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lstVisitantes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 441);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(67, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 17);
            this.panel2.TabIndex = 4;
            // 
            // lstVisitantes
            // 
            this.lstVisitantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstVisitantes.FullRowSelect = true;
            this.lstVisitantes.HideSelection = false;
            this.lstVisitantes.Location = new System.Drawing.Point(7, 89);
            this.lstVisitantes.Name = "lstVisitantes";
            this.lstVisitantes.Size = new System.Drawing.Size(996, 337);
            this.lstVisitantes.TabIndex = 3;
            this.lstVisitantes.UseCompatibleStateImageBehavior = false;
            this.lstVisitantes.View = System.Windows.Forms.View.Details;
            this.lstVisitantes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstVisitantes_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visitantes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Location = new System.Drawing.Point(256, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(747, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(626, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioNome);
            this.groupBox1.Controls.Add(this.radioRG);
            this.groupBox1.Location = new System.Drawing.Point(7, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(239, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(131, 44);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Placa Veículo";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(131, 20);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Empresa";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.Location = new System.Drawing.Point(4, 44);
            this.radioNome.Margin = new System.Windows.Forms.Padding(0);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(58, 19);
            this.radioNome.TabIndex = 1;
            this.radioNome.Text = "Nome";
            this.radioNome.UseVisualStyleBackColor = true;
            // 
            // radioRG
            // 
            this.radioRG.AutoSize = true;
            this.radioRG.Location = new System.Drawing.Point(4, 20);
            this.radioRG.Margin = new System.Windows.Forms.Padding(0);
            this.radioRG.Name = "radioRG";
            this.radioRG.Size = new System.Drawing.Size(40, 19);
            this.radioRG.TabIndex = 0;
            this.radioRG.Text = "RG";
            this.radioRG.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(13, 514);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(91, 35);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(934, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(130, 514);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 559);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pesquisa de Visitantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioNome;
        private System.Windows.Forms.RadioButton radioRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListView lstVisitantes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
    }
}

