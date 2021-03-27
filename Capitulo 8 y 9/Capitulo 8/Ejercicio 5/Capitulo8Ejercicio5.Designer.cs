
namespace Capitulo_8_y_9.Capitulo_8.Exercise_5
{
    partial class Capitulo8Ejercicio5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo8Ejercicio5));
            this.StringButton = new System.Windows.Forms.Button();
            this.ResultadoLabel1 = new System.Windows.Forms.Label();
            this.ResultadoLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StringButton
            // 
            this.StringButton.Location = new System.Drawing.Point(100, 13);
            this.StringButton.Name = "StringButton";
            this.StringButton.Size = new System.Drawing.Size(75, 23);
            this.StringButton.TabIndex = 0;
            this.StringButton.Text = "String";
            this.StringButton.UseVisualStyleBackColor = true;
            this.StringButton.Click += new System.EventHandler(this.StringButton_Click);
            // 
            // ResultadoLabel1
            // 
            this.ResultadoLabel1.AutoSize = true;
            this.ResultadoLabel1.Location = new System.Drawing.Point(100, 53);
            this.ResultadoLabel1.Name = "ResultadoLabel1";
            this.ResultadoLabel1.Size = new System.Drawing.Size(0, 15);
            this.ResultadoLabel1.TabIndex = 1;
            // 
            // ResultadoLabel2
            // 
            this.ResultadoLabel2.AutoSize = true;
            this.ResultadoLabel2.Location = new System.Drawing.Point(100, 90);
            this.ResultadoLabel2.Name = "ResultadoLabel2";
            this.ResultadoLabel2.Size = new System.Drawing.Size(0, 15);
            this.ResultadoLabel2.TabIndex = 2;
            // 
            // Capitulo8Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(275, 116);
            this.Controls.Add(this.ResultadoLabel2);
            this.Controls.Add(this.ResultadoLabel1);
            this.Controls.Add(this.StringButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo8Ejercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StringButton;
        private System.Windows.Forms.Label ResultadoLabel1;
        private System.Windows.Forms.Label ResultadoLabel2;
    }
}