namespace EjemploDepuracionCodigoCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnrellenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvnumeros = new System.Windows.Forms.ListView();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lbvalores = new System.Windows.Forms.ListBox();
            this.btnfibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrellenar
            // 
            this.btnrellenar.Location = new System.Drawing.Point(235, 57);
            this.btnrellenar.Name = "btnrellenar";
            this.btnrellenar.Size = new System.Drawing.Size(75, 23);
            this.btnrellenar.TabIndex = 0;
            this.btnrellenar.Text = "rellenar";
            this.btnrellenar.UseVisualStyleBackColor = true;
            this.btnrellenar.Click += new System.EventHandler(this.btnrellenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consecutivo Ciclo mientras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "digite numero aqui:";
            // 
            // lvnumeros
            // 
            this.lvnumeros.HideSelection = false;
            this.lvnumeros.Location = new System.Drawing.Point(330, 88);
            this.lvnumeros.Name = "lvnumeros";
            this.lvnumeros.Size = new System.Drawing.Size(121, 155);
            this.lvnumeros.TabIndex = 3;
            this.lvnumeros.UseCompatibleStateImageBehavior = false;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(123, 60);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 4;
            // 
            // lbvalores
            // 
            this.lbvalores.FormattingEnabled = true;
            this.lbvalores.Location = new System.Drawing.Point(477, 88);
            this.lbvalores.Name = "lbvalores";
            this.lbvalores.Size = new System.Drawing.Size(120, 160);
            this.lbvalores.TabIndex = 5;
            // 
            // btnfibonacci
            // 
            this.btnfibonacci.Location = new System.Drawing.Point(235, 102);
            this.btnfibonacci.Name = "btnfibonacci";
            this.btnfibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnfibonacci.TabIndex = 6;
            this.btnfibonacci.Text = "fibonacci";
            this.btnfibonacci.UseVisualStyleBackColor = true;
            this.btnfibonacci.Click += new System.EventHandler(this.btnfibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 271);
            this.Controls.Add(this.btnfibonacci);
            this.Controls.Add(this.lbvalores);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lvnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrellenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrellenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvnumeros;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ListBox lbvalores;
        private System.Windows.Forms.Button btnfibonacci;
    }
}

