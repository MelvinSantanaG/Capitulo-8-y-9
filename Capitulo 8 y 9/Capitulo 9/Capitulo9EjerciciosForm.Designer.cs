
namespace Capitulo_8_y_9.Capitulo_9
{
    partial class Capitulo9EjerciciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo9EjerciciosForm));
            this.Capitulo9Ejercicio1Button = new System.Windows.Forms.Button();
            this.Capitulo9Ejercicio2Button = new System.Windows.Forms.Button();
            this.Capitulo9Ejercicio3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Capitulo9Ejercicio1Button
            // 
            this.Capitulo9Ejercicio1Button.Location = new System.Drawing.Point(62, 10);
            this.Capitulo9Ejercicio1Button.Name = "Capitulo9Ejercicio1Button";
            this.Capitulo9Ejercicio1Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo9Ejercicio1Button.TabIndex = 0;
            this.Capitulo9Ejercicio1Button.Text = "Ejercicio 1";
            this.Capitulo9Ejercicio1Button.UseVisualStyleBackColor = true;
            this.Capitulo9Ejercicio1Button.Click += new System.EventHandler(this.Capitulo9Ejercicio1Button_Click);
            // 
            // Capitulo9Ejercicio2Button
            // 
            this.Capitulo9Ejercicio2Button.Location = new System.Drawing.Point(62, 50);
            this.Capitulo9Ejercicio2Button.Name = "Capitulo9Ejercicio2Button";
            this.Capitulo9Ejercicio2Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo9Ejercicio2Button.TabIndex = 1;
            this.Capitulo9Ejercicio2Button.Text = "Ejercicio 3";
            this.Capitulo9Ejercicio2Button.UseVisualStyleBackColor = true;
            this.Capitulo9Ejercicio2Button.Click += new System.EventHandler(this.Capitulo9Ejercicio3Button_Click);
            // 
            // Capitulo9Ejercicio3Button
            // 
            this.Capitulo9Ejercicio3Button.Location = new System.Drawing.Point(62, 90);
            this.Capitulo9Ejercicio3Button.Name = "Capitulo9Ejercicio3Button";
            this.Capitulo9Ejercicio3Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo9Ejercicio3Button.TabIndex = 2;
            this.Capitulo9Ejercicio3Button.Text = "Ejercicio 4";
            this.Capitulo9Ejercicio3Button.UseVisualStyleBackColor = true;
            this.Capitulo9Ejercicio3Button.Click += new System.EventHandler(this.Capitulo9Ejercicio4Button_Click);
            // 
            // Capitulo9EjerciciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(201, 125);
            this.Controls.Add(this.Capitulo9Ejercicio3Button);
            this.Controls.Add(this.Capitulo9Ejercicio2Button);
            this.Controls.Add(this.Capitulo9Ejercicio1Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo9EjerciciosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capitulo9Ejercicio1Button;
        private System.Windows.Forms.Button Capitulo9Ejercicio2Button;
        private System.Windows.Forms.Button Capitulo9Ejercicio3Button;
    }
}