
namespace Interdiciplinar
{
    partial class txt_cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.btnTelaEstoque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema DLEA";
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTelaCadastro.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTelaCadastro.Location = new System.Drawing.Point(136, 208);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(199, 42);
            this.btnTelaCadastro.TabIndex = 1;
            this.btnTelaCadastro.Text = "Tela de cadastro";
            this.btnTelaCadastro.UseVisualStyleBackColor = false;
            this.btnTelaCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTelaEstoque
            // 
            this.btnTelaEstoque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTelaEstoque.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaEstoque.Location = new System.Drawing.Point(136, 266);
            this.btnTelaEstoque.Name = "btnTelaEstoque";
            this.btnTelaEstoque.Size = new System.Drawing.Size(199, 42);
            this.btnTelaEstoque.TabIndex = 2;
            this.btnTelaEstoque.Text = "Tela de estoque";
            this.btnTelaEstoque.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(32, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione para onde deseja ser direcionado";
            // 
            // txt_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interdiciplinar.Properties.Resources.limpezaInicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTelaEstoque);
            this.Controls.Add(this.btnTelaCadastro);
            this.Controls.Add(this.label1);
            this.Name = "txt_cadastro";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTelaCadastro;
        private System.Windows.Forms.Button btnTelaEstoque;
        private System.Windows.Forms.Label label2;
    }
}