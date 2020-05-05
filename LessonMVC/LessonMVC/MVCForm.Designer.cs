namespace LessonMVC
{
    partial class MVCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button Button;

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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.TextBox.Location = new System.Drawing.Point(140, 10);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(140, 20);
            this.TextBox.TabIndex = 0;

            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(10, 10);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 355);
            this.ListBox.TabIndex = 1;

            this.Button.Location = new System.Drawing.Point(140, 40);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(140, 30);
            this.Button.TabIndex = 2;
            this.Button.Text = "Enter";
            this.Button.Click += new System.EventHandler(this.ButtonValue_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.TextBox);
            this.Name = "MVCForm";
            this.Text = "MVCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}