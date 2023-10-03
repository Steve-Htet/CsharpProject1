namespace csharpdemo1
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            btn_New = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btn_New
            // 
            btn_New.Anchor = AnchorStyles.None;
            btn_New.BackColor = Color.LightSteelBlue;
            btn_New.Location = new Point(396, 12);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(80, 23);
            btn_New.TabIndex = 0;
            btn_New.Text = "Add  Note";
            btn_New.UseVisualStyleBackColor = false;
            btn_New.Click += btn_New_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = Color.GhostWhite;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(466, 349);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(492, 423);
            Controls.Add(listBox1);
            Controls.Add(btn_New);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "form1";
            Text = "Diary";
            Load += form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_New;
        private ListBox listBox1;
    }
}