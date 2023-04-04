namespace ProjetoExercs2023
{
    partial class frmgasolina
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
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblquantl = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.lblvalorp = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.txtvalorp = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(22, 40);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(140, 13);
            this.lbltipo.TabIndex = 0;
            this.lbltipo.Text = "Digite o tipo de combústivel:";
            // 
            // lblquantl
            // 
            this.lblquantl.AutoSize = true;
            this.lblquantl.Location = new System.Drawing.Point(25, 79);
            this.lblquantl.Name = "lblquantl";
            this.lblquantl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblquantl.Size = new System.Drawing.Size(0, 13);
            this.lblquantl.TabIndex = 1;
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Location = new System.Drawing.Point(25, 72);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(136, 13);
            this.lblquant.TabIndex = 2;
            this.lblquant.Text = "Digite a quantidade de litro:";
            // 
            // lblvalorp
            // 
            this.lblvalorp.AutoSize = true;
            this.lblvalorp.Location = new System.Drawing.Point(25, 109);
            this.lblvalorp.Name = "lblvalorp";
            this.lblvalorp.Size = new System.Drawing.Size(97, 13);
            this.lblvalorp.TabIndex = 3;
            this.lblvalorp.Text = "O valor a ser pago:";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(260, 31);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(143, 20);
            this.txttipo.TabIndex = 4;
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(260, 67);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(142, 20);
            this.txtquant.TabIndex = 5;
            // 
            // txtvalorp
            // 
            this.txtvalorp.Location = new System.Drawing.Point(262, 107);
            this.txtvalorp.Name = "txtvalorp";
            this.txtvalorp.Size = new System.Drawing.Size(139, 20);
            this.txtvalorp.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(32, 273);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(142, 47);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(281, 273);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(139, 46);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(520, 270);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(136, 49);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // frmgasolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalorp);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.lblvalorp);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.lblquantl);
            this.Controls.Add(this.lbltipo);
            this.Name = "frmgasolina";
            this.Text = "Gasolina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblquantl;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Label lblvalorp;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.TextBox txtvalorp;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}