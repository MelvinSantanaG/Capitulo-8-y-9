
namespace Capitulo_8_y_9.Capitulo_9.Exercise_4
{
    partial class Capitulo9Ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capitulo9Ejercicio4));
            this.DisplayButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.OptionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(13, 12);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(69, 23);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(13, 48);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumberTextBox.TabIndex = 1;
            // 
            // OptionListBox
            // 
            this.OptionListBox.FormattingEnabled = true;
            this.OptionListBox.ItemHeight = 15;
            this.OptionListBox.Location = new System.Drawing.Point(13, 78);
            this.OptionListBox.Name = "OptionListBox";
            this.OptionListBox.Size = new System.Drawing.Size(120, 94);
            this.OptionListBox.TabIndex = 2;
            // 
            // Capitulo9Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(346, 178);
            this.Controls.Add(this.OptionListBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.DisplayButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capitulo9Ejercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.ListBox OptionListBox;
    }
}