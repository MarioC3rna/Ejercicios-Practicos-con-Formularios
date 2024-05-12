namespace P1AFormNaser.Formularios
{
    partial class FMRIngreso
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.facu = new System.Windows.Forms.ComboBox();
            this.bsuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(41, 38);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ingrese numero 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(41, 85);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "ingrese numero 2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(79, 133);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(50, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "resultado";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(153, 27);
            this.txt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 29);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(153, 74);
            this.txt2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(120, 29);
            this.txt2.TabIndex = 4;
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(153, 133);
            this.resultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(120, 29);
            this.resultado.TabIndex = 5;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(174, 247);
            this.suma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(73, 36);
            this.suma.TabIndex = 6;
            this.suma.Text = "Carreras";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // facu
            // 
            this.facu.FormattingEnabled = true;
            this.facu.Location = new System.Drawing.Point(142, 196);
            this.facu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facu.Name = "facu";
            this.facu.Size = new System.Drawing.Size(143, 21);
            this.facu.TabIndex = 7;
            this.facu.SelectedIndexChanged += new System.EventHandler(this.facu_SelectedIndexChanged);
            // 
            // bsuma
            // 
            this.bsuma.Location = new System.Drawing.Point(318, 126);
            this.bsuma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bsuma.Name = "bsuma";
            this.bsuma.Size = new System.Drawing.Size(73, 36);
            this.bsuma.TabIndex = 8;
            this.bsuma.Text = "SUMAR";
            this.bsuma.UseVisualStyleBackColor = true;
            this.bsuma.Click += new System.EventHandler(this.bsuma_Click);
            // 
            // FMRIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 327);
            this.Controls.Add(this.bsuma);
            this.Controls.Add(this.facu);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FMRIngreso";
            this.Text = "FMRIngreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.ComboBox facu;
        private System.Windows.Forms.Button bsuma;
    }
}