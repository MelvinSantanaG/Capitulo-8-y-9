
namespace Capitulo_8_y_9.Capitulo_8
{
    partial class Capitulo8EjerciciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo8EjerciciosForm));
            this.Capitulo8Ejercicio3Button = new System.Windows.Forms.Button();
            this.Capitulo8Ejercicio5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Capitulo8Ejercicio3Button
            // 
            this.Capitulo8Ejercicio3Button.Location = new System.Drawing.Point(62, 10);
            this.Capitulo8Ejercicio3Button.Name = "Capitulo8Ejercicio3Button";
            this.Capitulo8Ejercicio3Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo8Ejercicio3Button.TabIndex = 0;
            this.Capitulo8Ejercicio3Button.Text = "Capitulo 3";
            this.Capitulo8Ejercicio3Button.UseVisualStyleBackColor = true;
            this.Capitulo8Ejercicio3Button.Click += new System.EventHandler(this.Chapter8Exercise3Button_Click);
            // 
            // Capitulo8Ejercicio5Button
            // 
            this.Capitulo8Ejercicio5Button.Location = new System.Drawing.Point(62, 50);
            this.Capitulo8Ejercicio5Button.Name = "Capitulo8Ejercicio5Button";
            this.Capitulo8Ejercicio5Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo8Ejercicio5Button.TabIndex = 1;
            this.Capitulo8Ejercicio5Button.Text = "Capitulo 5";
            this.Capitulo8Ejercicio5Button.UseVisualStyleBackColor = true;
            this.Capitulo8Ejercicio5Button.Click += new System.EventHandler(this.Chapter8Exercise5Button_Click);
            // 
            // Capitulo8EjerciciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(199, 80);
            this.Controls.Add(this.Capitulo8Ejercicio5Button);
            this.Controls.Add(this.Capitulo8Ejercicio3Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo8EjerciciosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capitulo8Ejercicio3Button;
        private System.Windows.Forms.Button Capitulo8Ejercicio5Button;
    }
}