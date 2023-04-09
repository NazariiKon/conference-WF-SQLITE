using Microsoft.VisualBasic.ApplicationServices;

namespace conferencesProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private Label labelAcademicDegree;
        private TextBox textBoxAcademicDegree;
        private Label labelAcademicTitle;
        private TextBox textBoxAcademicTitle;
        private Label labelResearchArea;
        private TextBox textBoxResearchArea;
        private Label labelPlaceWork;
        private TextBox textBoxPlaceWork;
        private Label labelPosition;
        private TextBox textBoxPosition;
        private Label labelCountry;
        private TextBox textBoxCountry;
        private Label labelPostalCode;
        private TextBox textBoxPostalCode;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelHomePhone;
        private TextBox textBoxHomePhone;
        private Label labelEmail;
        private TextBox textBoxEmail;

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
            labelName = new Label();
            textBoxName = new TextBox();
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            labelAcademicDegree = new Label();
            textBoxAcademicDegree = new TextBox();
            labelAcademicTitle = new Label();
            textBoxAcademicTitle = new TextBox();
            labelResearchArea = new Label();
            textBoxResearchArea = new TextBox();
            labelPlaceWork = new Label();
            textBoxPlaceWork = new TextBox();
            labelPosition = new Label();
            textBoxPosition = new TextBox();
            labelCountry = new Label();
            textBoxCountry = new TextBox();
            labelPostalCode = new Label();
            textBoxPostalCode = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelHomePhone = new Label();
            textBoxHomePhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(38, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Ім'я:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(183, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(324, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(12, 48);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(80, 20);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Призвіще:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(183, 45);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.ReadOnly = true;
            textBoxSurname.Size = new Size(324, 27);
            textBoxSurname.TabIndex = 3;
            // 
            // labelAcademicDegree
            // 
            labelAcademicDegree.AutoSize = true;
            labelAcademicDegree.Location = new Point(12, 114);
            labelAcademicDegree.Name = "labelAcademicDegree";
            labelAcademicDegree.Size = new Size(134, 20);
            labelAcademicDegree.TabIndex = 4;
            labelAcademicDegree.Text = "Науковий ступінь:";
            // 
            // textBoxAcademicDegree
            // 
            textBoxAcademicDegree.Location = new Point(183, 111);
            textBoxAcademicDegree.Name = "textBoxAcademicDegree";
            textBoxAcademicDegree.ReadOnly = true;
            textBoxAcademicDegree.Size = new Size(324, 27);
            textBoxAcademicDegree.TabIndex = 5;
            // 
            // labelAcademicTitle
            // 
            labelAcademicTitle.AutoSize = true;
            labelAcademicTitle.Location = new Point(12, 147);
            labelAcademicTitle.Name = "labelAcademicTitle";
            labelAcademicTitle.Size = new Size(107, 20);
            labelAcademicTitle.TabIndex = 6;
            labelAcademicTitle.Text = "Вчене звання:";
            // 
            // textBoxAcademicTitle
            // 
            textBoxAcademicTitle.Location = new Point(183, 144);
            textBoxAcademicTitle.Name = "textBoxAcademicTitle";
            textBoxAcademicTitle.ReadOnly = true;
            textBoxAcademicTitle.Size = new Size(324, 27);
            textBoxAcademicTitle.TabIndex = 7;
            // 
            // labelResearchArea
            // 
            labelResearchArea.AutoSize = true;
            labelResearchArea.Location = new Point(12, 180);
            labelResearchArea.Name = "labelResearchArea";
            labelResearchArea.Size = new Size(154, 20);
            labelResearchArea.TabIndex = 8;
            labelResearchArea.Text = "Науковий напрямок:";
            // 
            // textBoxResearchArea
            // 
            textBoxResearchArea.Location = new Point(183, 177);
            textBoxResearchArea.Name = "textBoxResearchArea";
            textBoxResearchArea.ReadOnly = true;
            textBoxResearchArea.Size = new Size(324, 27);
            textBoxResearchArea.TabIndex = 9;
            // 
            // labelPlaceWork
            // 
            labelPlaceWork.AutoSize = true;
            labelPlaceWork.Location = new Point(12, 81);
            labelPlaceWork.Name = "labelPlaceWork";
            labelPlaceWork.Size = new Size(108, 20);
            labelPlaceWork.TabIndex = 2;
            labelPlaceWork.Text = "Місце роботи:";
            // 
            // textBoxPlaceWork
            // 
            textBoxPlaceWork.Location = new Point(183, 78);
            textBoxPlaceWork.Name = "textBoxPlaceWork";
            textBoxPlaceWork.ReadOnly = true;
            textBoxPlaceWork.Size = new Size(324, 27);
            textBoxPlaceWork.TabIndex = 3;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(12, 213);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(63, 20);
            labelPosition.TabIndex = 9;
            labelPosition.Text = "Посада:";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(183, 210);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.ReadOnly = true;
            textBoxPosition.Size = new Size(324, 27);
            textBoxPosition.TabIndex = 10;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(12, 246);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(59, 20);
            labelCountry.TabIndex = 11;
            labelCountry.Text = "Країна:";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(183, 243);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.ReadOnly = true;
            textBoxCountry.Size = new Size(324, 27);
            textBoxCountry.TabIndex = 12;
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(12, 279);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(55, 20);
            labelPostalCode.TabIndex = 13;
            labelPostalCode.Text = "Індекс:";
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(183, 276);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.ReadOnly = true;
            textBoxPostalCode.Size = new Size(324, 27);
            textBoxPostalCode.TabIndex = 14;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(12, 312);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 20);
            labelAddress.TabIndex = 15;
            labelAddress.Text = "Адреса:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(183, 309);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(324, 27);
            textBoxAddress.TabIndex = 16;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(12, 345);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(76, 20);
            labelPhone.TabIndex = 12;
            labelPhone.Text = "Телефон: ";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(183, 342);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(324, 27);
            textBoxPhone.TabIndex = 13;
            // 
            // labelHomePhone
            // 
            labelHomePhone.AutoSize = true;
            labelHomePhone.Location = new Point(12, 378);
            labelHomePhone.Name = "labelHomePhone";
            labelHomePhone.Size = new Size(84, 20);
            labelHomePhone.TabIndex = 14;
            labelHomePhone.Text = "Домашній:";
            // 
            // textBoxHomePhone
            // 
            textBoxHomePhone.Location = new Point(183, 375);
            textBoxHomePhone.Name = "textBoxHomePhone";
            textBoxHomePhone.ReadOnly = true;
            textBoxHomePhone.Size = new Size(324, 27);
            textBoxHomePhone.TabIndex = 15;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 411);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(183, 408);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(324, 27);
            textBoxEmail.TabIndex = 17;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelHomePhone);
            Controls.Add(textBoxHomePhone);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelSurname);
            Controls.Add(textBoxSurname);
            Controls.Add(labelAcademicDegree);
            Controls.Add(textBoxAcademicDegree);
            Controls.Add(labelAcademicTitle);
            Controls.Add(textBoxAcademicTitle);
            Controls.Add(labelResearchArea);
            Controls.Add(textBoxResearchArea);
            Controls.Add(labelPlaceWork);
            Controls.Add(textBoxPlaceWork);
            Controls.Add(labelPosition);
            Controls.Add(textBoxPosition);
            Controls.Add(labelCountry);
            Controls.Add(textBoxCountry);
            Controls.Add(labelPostalCode);
            Controls.Add(textBoxPostalCode);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Name = "Form3";
            Text = "Користувач:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}