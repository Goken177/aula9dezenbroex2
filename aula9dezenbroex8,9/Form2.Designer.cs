namespace excer9dezenbro8
{
    partial class Form2
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
            this.botaodia = new System.Windows.Forms.Button();
            this.botaomes = new System.Windows.Forms.Button();
            this.botaoano = new System.Windows.Forms.Button();
            this.labelfrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaodia
            // 
            this.botaodia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.botaodia.Location = new System.Drawing.Point(73, 131);
            this.botaodia.Name = "botaodia";
            this.botaodia.Size = new System.Drawing.Size(132, 77);
            this.botaodia.TabIndex = 0;
            this.botaodia.Text = "dia";
            this.botaodia.UseVisualStyleBackColor = false;
            this.botaodia.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaomes
            // 
            this.botaomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botaomes.Location = new System.Drawing.Point(323, 131);
            this.botaomes.Name = "botaomes";
            this.botaomes.Size = new System.Drawing.Size(126, 77);
            this.botaomes.TabIndex = 1;
            this.botaomes.Text = "mês";
            this.botaomes.UseVisualStyleBackColor = false;
            this.botaomes.Click += new System.EventHandler(this.botaomes_Click);
            // 
            // botaoano
            // 
            this.botaoano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.botaoano.Location = new System.Drawing.Point(569, 131);
            this.botaoano.Name = "botaoano";
            this.botaoano.Size = new System.Drawing.Size(121, 77);
            this.botaoano.TabIndex = 2;
            this.botaoano.Text = "ano";
            this.botaoano.UseVisualStyleBackColor = false;
            this.botaoano.Click += new System.EventHandler(this.botaoano_Click);
            // 
            // labelfrase
            // 
            this.labelfrase.AutoSize = true;
            this.labelfrase.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfrase.Location = new System.Drawing.Point(69, 297);
            this.labelfrase.Name = "labelfrase";
            this.labelfrase.Size = new System.Drawing.Size(60, 21);
            this.labelfrase.TabIndex = 3;
            this.labelfrase.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelfrase);
            this.Controls.Add(this.botaoano);
            this.Controls.Add(this.botaomes);
            this.Controls.Add(this.botaodia);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaodia;
        private System.Windows.Forms.Button botaomes;
        private System.Windows.Forms.Button botaoano;
        private System.Windows.Forms.Label labelfrase;
    }
}