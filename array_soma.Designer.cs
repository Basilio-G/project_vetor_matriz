namespace project_vetor_matriz
{
    partial class array_soma
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
            this.txbnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbsoma = new System.Windows.Forms.TextBox();
            this.btsoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores:";
            // 
            // txbnum
            // 
            this.txbnum.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnum.Location = new System.Drawing.Point(173, 114);
            this.txbnum.Name = "txbnum";
            this.txbnum.Size = new System.Drawing.Size(133, 51);
            this.txbnum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soma de 4 itens";
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(326, 114);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(160, 51);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "Adicionar";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // txbsoma
            // 
            this.txbsoma.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsoma.Location = new System.Drawing.Point(173, 195);
            this.txbsoma.Name = "txbsoma";
            this.txbsoma.ReadOnly = true;
            this.txbsoma.Size = new System.Drawing.Size(133, 51);
            this.txbsoma.TabIndex = 1;
            // 
            // btsoma
            // 
            this.btsoma.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsoma.Location = new System.Drawing.Point(326, 195);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(160, 51);
            this.btsoma.TabIndex = 2;
            this.btsoma.Text = "Somar";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.btsoma_Click);
            // 
            // array_soma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.txbsoma);
            this.Controls.Add(this.txbnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "array_soma";
            this.Text = "array_soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbsoma;
        private System.Windows.Forms.Button btsoma;
    }
}