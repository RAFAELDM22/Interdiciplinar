namespace Interdiciplinar
{
    partial class TelaRegistro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCompras = new System.Windows.Forms.Label();
            this.txtVendas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(2, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 401);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.txtVendas);
            this.panel1.Controls.Add(this.txtCompras);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 29);
            this.panel1.TabIndex = 2;
            // 
            // txtCompras
            // 
            this.txtCompras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCompras.AutoSize = true;
            this.txtCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompras.ForeColor = System.Drawing.Color.White;
            this.txtCompras.Location = new System.Drawing.Point(155, 0);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(105, 25);
            this.txtCompras.TabIndex = 0;
            this.txtCompras.Text = "Compras";
            this.txtCompras.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVendas
            // 
            this.txtVendas.AutoSize = true;
            this.txtVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendas.ForeColor = System.Drawing.Color.White;
            this.txtVendas.Location = new System.Drawing.Point(317, 0);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(91, 25);
            this.txtVendas.TabIndex = 1;
            this.txtVendas.Text = "Vendas";
            this.txtVendas.Click += new System.EventHandler(this.txtVendas_Click);
            // 
            // TelaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TelaRegistro";
            this.Text = "TelaRegistro";
            this.Load += new System.EventHandler(this.TelaRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtVendas;
        private System.Windows.Forms.Label txtCompras;
    }
}