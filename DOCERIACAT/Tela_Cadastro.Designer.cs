namespace DOCERIACAT
{
    partial class Tela_Cadastro
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbtelefone = new System.Windows.Forms.TextBox();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(160, 263);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 117);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefone";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "e-mail";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPF";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(29, 24);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(29, 78);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(212, 24);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(34, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "e-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(212, 78);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(505, 33);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(505, 78);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(505, 163);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(505, 120);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 23);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "INSERIR";
            this.btninserir.UseVisualStyleBackColor = true;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(70, 21);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(100, 20);
            this.txbnome.TabIndex = 9;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(272, 24);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(100, 20);
            this.txbemail.TabIndex = 10;
            // 
            // txbtelefone
            // 
            this.txbtelefone.Location = new System.Drawing.Point(84, 75);
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(100, 20);
            this.txbtelefone.TabIndex = 11;
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(272, 78);
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(100, 20);
            this.txbcpf.TabIndex = 12;
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DOCERIACAT.Properties.Resources.Inserir_um_subtítulo;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.txbtelefone);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.listView1);
            this.Name = "Tela_Cadastro";
            this.Text = "Tela_Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbtelefone;
        private System.Windows.Forms.TextBox txbcpf;
    }
}