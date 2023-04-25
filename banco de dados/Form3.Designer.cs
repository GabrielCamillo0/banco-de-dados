
namespace banco_de_dados
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeABox = new System.Windows.Forms.TextBox();
            this.alunorgmBox = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cursoBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label1.Location = new System.Drawing.Point(71, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome do Aluno ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o RGM";
            // 
            // nomeABox
            // 
            this.nomeABox.Enabled = false;
            this.nomeABox.Location = new System.Drawing.Point(237, 242);
            this.nomeABox.Multiline = true;
            this.nomeABox.Name = "nomeABox";
            this.nomeABox.Size = new System.Drawing.Size(175, 22);
            this.nomeABox.TabIndex = 3;
            this.nomeABox.TextChanged += new System.EventHandler(this.nomeABox_TextChanged);
            // 
            // alunorgmBox
            // 
            this.alunorgmBox.Enabled = false;
            this.alunorgmBox.Location = new System.Drawing.Point(196, 325);
            this.alunorgmBox.Multiline = true;
            this.alunorgmBox.Name = "alunorgmBox";
            this.alunorgmBox.Size = new System.Drawing.Size(216, 22);
            this.alunorgmBox.TabIndex = 4;
            this.alunorgmBox.TextChanged += new System.EventHandler(this.alunorgmBox_TextChanged);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(531, 159);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 5;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "CURSO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cursoBox
            // 
            this.cursoBox.Location = new System.Drawing.Point(237, 162);
            this.cursoBox.Multiline = true;
            this.cursoBox.Name = "cursoBox";
            this.cursoBox.Size = new System.Drawing.Size(175, 22);
            this.cursoBox.TabIndex = 20;
            this.cursoBox.TextChanged += new System.EventHandler(this.cursoBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cursoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.alunorgmBox);
            this.Controls.Add(this.nomeABox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeABox;
        private System.Windows.Forms.TextBox alunorgmBox;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cursoBox;
        private System.Windows.Forms.Button button3;
    }
}