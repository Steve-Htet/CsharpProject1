namespace csharpdemo1
{
    partial class statusform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statusform));
            save = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // save
            // 
            save.BackColor = Color.GhostWhite;
            save.Location = new Point(351, 300);
            save.Name = "save";
            save.Size = new Size(75, 27);
            save.TabIndex = 0;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(9, 8);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 285);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // statusform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(435, 334);
            Controls.Add(richTextBox1);
            Controls.Add(save);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "statusform";
            Text = "statusform";
            ResumeLayout(false);
        }

        #endregion

        private Button save;
        private RichTextBox richTextBox1;
    }
}