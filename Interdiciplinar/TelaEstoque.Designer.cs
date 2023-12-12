namespace Interdiciplinar
{
    partial class TelaEstoque
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
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAlterarEstoque = new System.Windows.Forms.Button();
            this.txtProdt = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 161);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.Size = new System.Drawing.Size(560, 269);
            this.dgvEstoque.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAlterarEstoque);
            this.groupBox2.Controls.Add(this.txtProdt);
            this.groupBox2.Controls.Add(this.txtQntd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(188, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar Estoque";
            // 
            // btnAlterarEstoque
            // 
            this.btnAlterarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEstoque.Location = new System.Drawing.Point(55, 95);
            this.btnAlterarEstoque.Name = "btnAlterarEstoque";
            this.btnAlterarEstoque.Size = new System.Drawing.Size(96, 22);
            this.btnAlterarEstoque.TabIndex = 4;
            this.btnAlterarEstoque.Text = "Alterar";
            this.btnAlterarEstoque.UseVisualStyleBackColor = true;
            this.btnAlterarEstoque.Click += new System.EventHandler(this.btnAlterarEstoque_Click);
            // 
            // txtProdt
            // 
            this.txtProdt.Location = new System.Drawing.Point(106, 65);
            this.txtProdt.Name = "txtProdt";
            this.txtProdt.Size = new System.Drawing.Size(106, 24);
            this.txtProdt.TabIndex = 3;
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(106, 33);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(106, 24);
            this.txtQntd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade";
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(169)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(594, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TelaEstoque";
            this.Text = "TelaEstoque";
            this.Load += new System.EventHandler(this.TelaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarEstoque;
        private System.Windows.Forms.TextBox txtProdt;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.Label label2;
    }
}