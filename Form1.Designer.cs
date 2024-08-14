namespace WindowsFormsApp1
{
    partial class Tabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuada));
            this.multiplicar = new System.Windows.Forms.Button();
            this.minMultiplicandotextBox = new System.Windows.Forms.TextBox();
            this.resultadoListView = new System.Windows.Forms.ListView();
            this.maxMultiplicandotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxMultiplicadortextBox = new System.Windows.Forms.TextBox();
            this.minMultiplicadortextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(379, 150);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(133, 47);
            this.multiplicar.TabIndex = 0;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // minMultiplicandotextBox
            // 
            this.minMultiplicandotextBox.Location = new System.Drawing.Point(12, 43);
            this.minMultiplicandotextBox.Name = "minMultiplicandotextBox";
            this.minMultiplicandotextBox.Size = new System.Drawing.Size(232, 20);
            this.minMultiplicandotextBox.TabIndex = 1;
            this.minMultiplicandotextBox.TextChanged += new System.EventHandler(this.minMultiplicandotextBox_TextChanged);
            // 
            // resultadoListView
            // 
            this.resultadoListView.HideSelection = false;
            this.resultadoListView.Location = new System.Drawing.Point(12, 203);
            this.resultadoListView.Name = "resultadoListView";
            this.resultadoListView.Size = new System.Drawing.Size(500, 213);
            this.resultadoListView.TabIndex = 2;
            this.resultadoListView.UseCompatibleStateImageBehavior = false;
            // 
            // maxMultiplicandotextBox
            // 
            this.maxMultiplicandotextBox.Location = new System.Drawing.Point(280, 43);
            this.maxMultiplicandotextBox.Name = "maxMultiplicandotextBox";
            this.maxMultiplicandotextBox.Size = new System.Drawing.Size(232, 20);
            this.maxMultiplicandotextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mínimo multiplicando";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Máximo multiplicando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Máximo multiplicador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mínimo multiplicador";
            // 
            // maxMultiplicadortextBox
            // 
            this.maxMultiplicadortextBox.Location = new System.Drawing.Point(280, 91);
            this.maxMultiplicadortextBox.Name = "maxMultiplicadortextBox";
            this.maxMultiplicadortextBox.Size = new System.Drawing.Size(232, 20);
            this.maxMultiplicadortextBox.TabIndex = 7;
            // 
            // minMultiplicadortextBox
            // 
            this.minMultiplicadortextBox.Location = new System.Drawing.Point(12, 91);
            this.minMultiplicadortextBox.Name = "minMultiplicadortextBox";
            this.minMultiplicadortextBox.Size = new System.Drawing.Size(232, 20);
            this.minMultiplicadortextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxMultiplicadortextBox);
            this.Controls.Add(this.minMultiplicadortextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxMultiplicandotextBox);
            this.Controls.Add(this.resultadoListView);
            this.Controls.Add(this.minMultiplicandotextBox);
            this.Controls.Add(this.multiplicar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabuada";
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.TextBox minMultiplicandotextBox;
        private System.Windows.Forms.ListView resultadoListView;
        private System.Windows.Forms.TextBox maxMultiplicandotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxMultiplicadortextBox;
        private System.Windows.Forms.TextBox minMultiplicadortextBox;
        private System.Windows.Forms.Label label5;
    }
}

