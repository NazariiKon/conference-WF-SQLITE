namespace conferencesProject
{
    partial class Form2
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
            usersListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            labelTopic = new Label();
            textBoxTopic = new TextBox();
            labelAmount = new Label();
            textBoxAmount = new TextBox();
            labelDatePaid = new Label();
            dateTimePickerPaid = new DateTimePicker();
            labelDateDue = new Label();
            dateTimePickerDue = new DateTimePicker();
            labelFirstReminder = new Label();
            dateTimePickerFirstReminder = new DateTimePicker();
            labelSecondReminder = new Label();
            dateTimePickerSecondReminder = new DateTimePicker();
            labelArrival = new Label();
            dateTimePickerArrival = new DateTimePicker();
            labelDeparture = new Label();
            dateTimePickerDeparture = new DateTimePicker();
            labelReceiptDate = new Label();
            dateTimePickerReceipt = new DateTimePicker();
            labelNote = new Label();
            textBoxNote = new TextBox();
            SuspendLayout();
            // 
            // usersListBox
            // 
            usersListBox.FormattingEnabled = true;
            usersListBox.ItemHeight = 20;
            usersListBox.Location = new Point(466, 52);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(322, 324);
            usersListBox.TabIndex = 0;
            usersListBox.MouseDoubleClick += usersListBox_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(463, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 39);
            label1.TabIndex = 2;
            label1.Text = "Учасники:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(197, 39);
            label2.TabIndex = 3;
            label2.Text = "Інформація:";
            // 
            // labelTopic
            // 
            labelTopic.Location = new Point(12, 52);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(48, 23);
            labelTopic.TabIndex = 4;
            labelTopic.Text = "Тема:";
            // 
            // textBoxTopic
            // 
            textBoxTopic.Location = new Point(66, 52);
            textBoxTopic.Name = "textBoxTopic";
            textBoxTopic.ReadOnly = true;
            textBoxTopic.Size = new Size(394, 27);
            textBoxTopic.TabIndex = 5;
            // 
            // labelAmount
            // 
            labelAmount.Location = new Point(12, 88);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(100, 23);
            labelAmount.TabIndex = 6;
            labelAmount.Text = "Сума внеску:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(215, 85);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.ReadOnly = true;
            textBoxAmount.Size = new Size(245, 27);
            textBoxAmount.TabIndex = 7;
            // 
            // labelDatePaid
            // 
            labelDatePaid.Location = new Point(12, 123);
            labelDatePaid.Name = "labelDatePaid";
            labelDatePaid.Size = new Size(177, 23);
            labelDatePaid.TabIndex = 8;
            labelDatePaid.Text = "Дата внеску:";
            // 
            // dateTimePickerPaid
            // 
            dateTimePickerPaid.Enabled = false;
            dateTimePickerPaid.Location = new Point(215, 118);
            dateTimePickerPaid.Name = "dateTimePickerPaid";
            dateTimePickerPaid.Size = new Size(245, 27);
            dateTimePickerPaid.TabIndex = 9;
            // 
            // labelDateDue
            // 
            labelDateDue.Location = new Point(12, 156);
            labelDateDue.Name = "labelDateDue";
            labelDateDue.Size = new Size(177, 23);
            labelDateDue.TabIndex = 10;
            labelDateDue.Text = "Дата внеску, що дійшов:";
            // 
            // dateTimePickerDue
            // 
            dateTimePickerDue.Enabled = false;
            dateTimePickerDue.Location = new Point(215, 151);
            dateTimePickerDue.Name = "dateTimePickerDue";
            dateTimePickerDue.Size = new Size(245, 27);
            dateTimePickerDue.TabIndex = 11;
            // 
            // labelFirstReminder
            // 
            labelFirstReminder.Location = new Point(12, 189);
            labelFirstReminder.Name = "labelFirstReminder";
            labelFirstReminder.Size = new Size(197, 23);
            labelFirstReminder.TabIndex = 12;
            labelFirstReminder.Text = "Дата першого сповіщення:";
            // 
            // dateTimePickerFirstReminder
            // 
            dateTimePickerFirstReminder.Enabled = false;
            dateTimePickerFirstReminder.Location = new Point(215, 184);
            dateTimePickerFirstReminder.Name = "dateTimePickerFirstReminder";
            dateTimePickerFirstReminder.Size = new Size(245, 27);
            dateTimePickerFirstReminder.TabIndex = 13;
            // 
            // labelSecondReminder
            // 
            labelSecondReminder.Location = new Point(12, 222);
            labelSecondReminder.Name = "labelSecondReminder";
            labelSecondReminder.Size = new Size(197, 23);
            labelSecondReminder.TabIndex = 14;
            labelSecondReminder.Text = "Дата другого сповіщення:";
            // 
            // dateTimePickerSecondReminder
            // 
            dateTimePickerSecondReminder.Enabled = false;
            dateTimePickerSecondReminder.Location = new Point(215, 217);
            dateTimePickerSecondReminder.Name = "dateTimePickerSecondReminder";
            dateTimePickerSecondReminder.Size = new Size(245, 27);
            dateTimePickerSecondReminder.TabIndex = 15;
            // 
            // labelArrival
            // 
            labelArrival.Location = new Point(12, 255);
            labelArrival.Name = "labelArrival";
            labelArrival.Size = new Size(197, 23);
            labelArrival.TabIndex = 16;
            labelArrival.Text = "Дата приїзду:";
            // 
            // dateTimePickerArrival
            // 
            dateTimePickerArrival.Enabled = false;
            dateTimePickerArrival.Location = new Point(215, 250);
            dateTimePickerArrival.Name = "dateTimePickerArrival";
            dateTimePickerArrival.Size = new Size(245, 27);
            dateTimePickerArrival.TabIndex = 17;
            // 
            // labelDeparture
            // 
            labelDeparture.Location = new Point(12, 288);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new Size(177, 23);
            labelDeparture.TabIndex = 18;
            labelDeparture.Text = "Дата від'їзду:";
            // 
            // dateTimePickerDeparture
            // 
            dateTimePickerDeparture.Enabled = false;
            dateTimePickerDeparture.Location = new Point(215, 283);
            dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            dateTimePickerDeparture.Size = new Size(245, 27);
            dateTimePickerDeparture.TabIndex = 19;
            // 
            // labelReceiptDate
            // 
            labelReceiptDate.Location = new Point(12, 321);
            labelReceiptDate.Name = "labelReceiptDate";
            labelReceiptDate.Size = new Size(197, 23);
            labelReceiptDate.TabIndex = 20;
            labelReceiptDate.Text = "Дата надходження:";
            // 
            // dateTimePickerReceipt
            // 
            dateTimePickerReceipt.Enabled = false;
            dateTimePickerReceipt.Location = new Point(215, 316);
            dateTimePickerReceipt.Name = "dateTimePickerReceipt";
            dateTimePickerReceipt.Size = new Size(245, 27);
            dateTimePickerReceipt.TabIndex = 21;
            // 
            // labelNote
            // 
            labelNote.Location = new Point(12, 352);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(177, 23);
            labelNote.TabIndex = 22;
            labelNote.Text = "Відмітка:";
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(215, 349);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.ReadOnly = true;
            textBoxNote.Size = new Size(245, 27);
            textBoxNote.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usersListBox);
            Controls.Add(labelTopic);
            Controls.Add(textBoxTopic);
            Controls.Add(labelAmount);
            Controls.Add(textBoxAmount);
            Controls.Add(labelDatePaid);
            Controls.Add(dateTimePickerPaid);
            Controls.Add(labelDateDue);
            Controls.Add(dateTimePickerDue);
            Controls.Add(labelFirstReminder);
            Controls.Add(dateTimePickerFirstReminder);
            Controls.Add(labelSecondReminder);
            Controls.Add(dateTimePickerSecondReminder);
            Controls.Add(labelArrival);
            Controls.Add(dateTimePickerArrival);
            Controls.Add(labelDeparture);
            Controls.Add(dateTimePickerDeparture);
            Controls.Add(labelReceiptDate);
            Controls.Add(dateTimePickerReceipt);
            Controls.Add(labelNote);
            Controls.Add(textBoxNote);
            Name = "Form2";
            Text = "Конференція";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox usersListBox;
        private Label label1;
        private Label label2;
        private Label labelTopic;
        private TextBox textBoxTopic;
        private Label labelAmount;
        private TextBox textBoxAmount;
        private Label labelDatePaid;
        private DateTimePicker dateTimePickerPaid;
        private Label labelDateDue;
        private DateTimePicker dateTimePickerDue;
        private Label labelFirstReminder;
        private DateTimePicker dateTimePickerFirstReminder;
        private Label labelSecondReminder;
        private DateTimePicker dateTimePickerSecondReminder;
        private Label labelArrival;
        private DateTimePicker dateTimePickerArrival;
        private Label labelDeparture;
        private DateTimePicker dateTimePickerDeparture;
        private Label labelReceiptDate;
        private DateTimePicker dateTimePickerReceipt;
        private Label labelNote;
        private TextBox textBoxNote;
    }
}