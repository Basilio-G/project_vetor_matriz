namespace project_vetor_matriz
{
    partial class array_lista
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXBnum = new System.Windows.Forms.TextBox();
            this.BTadd = new System.Windows.Forms.Button();
            this.LBnum = new System.Windows.Forms.ListBox();
            this.BTlistar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vetor de 4 valores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "valor";
            // 
            // TXBnum
            // 
            this.TXBnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBnum.Location = new System.Drawing.Point(171, 107);
            this.TXBnum.Name = "TXBnum";
            this.TXBnum.Size = new System.Drawing.Size(178, 44);
            this.TXBnum.TabIndex = 1;
            // 
            // BTadd
            // 
            this.BTadd.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTadd.Location = new System.Drawing.Point(367, 107);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(164, 44);
            this.BTadd.TabIndex = 2;
            this.BTadd.Text = "Adicionar";
            this.BTadd.UseVisualStyleBackColor = true;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // LBnum
            // 
            this.LBnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnum.FormattingEnabled = true;
            this.LBnum.ItemHeight = 31;
            this.LBnum.Location = new System.Drawing.Point(107, 197);
            this.LBnum.Name = "LBnum";
            this.LBnum.Size = new System.Drawing.Size(330, 159);
            this.LBnum.TabIndex = 3;
            // 
            // BTlistar
            // 
            this.BTlistar.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTlistar.Location = new System.Drawing.Point(185, 381);
            this.BTlistar.Name = "BTlistar";
            this.BTlistar.Size = new System.Drawing.Size(164, 44);
            this.BTlistar.TabIndex = 2;
            this.BTlistar.Text = "Listar";
            this.BTlistar.UseVisualStyleBackColor = true;
            this.BTlistar.Click += new System.EventHandler(this.BTlistar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.LBnum);
            this.Controls.Add(this.BTlistar);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.TXBnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXBnum;
        private System.Windows.Forms.Button BTadd;
        private System.Windows.Forms.ListBox LBnum;
        private System.Windows.Forms.Button BTlistar;
    }
}

