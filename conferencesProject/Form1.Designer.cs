namespace conferencesProject
{
    partial class Form1
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
            conferencesListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // conferencesListBox
            // 
            conferencesListBox.FormattingEnabled = true;
            conferencesListBox.ItemHeight = 20;
            conferencesListBox.Location = new Point(12, 52);
            conferencesListBox.Name = "conferencesListBox";
            conferencesListBox.Size = new Size(552, 364);
            conferencesListBox.TabIndex = 0;
            conferencesListBox.MouseDoubleClick += conferencesListBox_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(212, 39);
            label1.TabIndex = 1;
            label1.Text = "Конференції:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 438);
            Controls.Add(label1);
            Controls.Add(conferencesListBox);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox conferencesListBox;
        private Label label1;
    }
}