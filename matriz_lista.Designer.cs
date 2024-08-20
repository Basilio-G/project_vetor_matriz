namespace project_vetor_matriz
{
    partial class matriz_lista
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
            this.btlistar = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.txbnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmatriz = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btlistar
            // 
            this.btlistar.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlistar.Location = new System.Drawing.Point(306, 196);
            this.btlistar.Name = "btlistar";
            this.btlistar.Size = new System.Drawing.Size(160, 51);
            this.btlistar.TabIndex = 8;
            this.btlistar.Text = "Listar";
            this.btlistar.UseVisualStyleBackColor = true;
            this.btlistar.Click += new System.EventHandler(this.btlistar_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(306, 111);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(160, 51);
            this.btadd.TabIndex = 9;
            this.btadd.Text = "Adicionar";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txbnum
            // 
            this.txbnum.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnum.Location = new System.Drawing.Point(146, 111);
            this.txbnum.Name = "txbnum";
            this.txbnum.Size = new System.Drawing.Size(133, 51);
            this.txbnum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matriz [3,3]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valores da matriz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valores:";
            // 
            // lbmatriz
            // 
            this.lbmatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatriz.FormattingEnabled = true;
            this.lbmatriz.ItemHeight = 31;
            this.lbmatriz.Location = new System.Drawing.Point(19, 227);
            this.lbmatriz.Name = "lbmatriz";
            this.lbmatriz.Size = new System.Drawing.Size(260, 376);
            this.lbmatriz.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matriz_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbmatriz);
            this.Controls.Add(this.btlistar);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.txbnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "matriz_lista";
            this.Text = "matriz_lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlistar;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txbnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbmatriz;
        private System.Windows.Forms.Button button1;
    }
}