
namespace Capitulo_8_y_9
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Capitulo8Button = new System.Windows.Forms.Button();
            this.Capitulo9Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Capitulo8Button
            // 
            this.Capitulo8Button.Location = new System.Drawing.Point(12, 10);
            this.Capitulo8Button.Name = "Capitulo8Button";
            this.Capitulo8Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo8Button.TabIndex = 0;
            this.Capitulo8Button.Text = "Capitulo 8";
            this.Capitulo8Button.UseVisualStyleBackColor = true;
            this.Capitulo8Button.Click += new System.EventHandler(this.Capitulo8Button_Click);
            // 
            // Capitulo9Button
            // 
            this.Capitulo9Button.Location = new System.Drawing.Point(112, 10);
            this.Capitulo9Button.Name = "Capitulo9Button";
            this.Capitulo9Button.Size = new System.Drawing.Size(75, 23);
            this.Capitulo9Button.TabIndex = 1;
            this.Capitulo9Button.Text = "Capitulo 9";
            this.Capitulo9Button.UseVisualStyleBackColor = true;
            this.Capitulo9Button.Click += new System.EventHandler(this.Capitulo9Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(199, 45);
            this.Controls.Add(this.Capitulo9Button);
            this.Controls.Add(this.Capitulo8Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capitulo8Button;
        private System.Windows.Forms.Button Capitulo9Button;
    }
}

