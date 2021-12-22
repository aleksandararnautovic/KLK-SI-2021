namespace StudentDesktop
{
    partial class StudentApp
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIndexNumber = new System.Windows.Forms.Label();
            this.textBoxIndexNumber = new System.Windows.Forms.TextBox();
            this.labelPointsESPB = new System.Windows.Forms.Label();
            this.textBoxPointsESPB = new System.Windows.Forms.TextBox();
            this.labelStudyYear = new System.Windows.Forms.Label();
            this.textBoxStudyYear = new System.Windows.Forms.TextBox();
            this.labelAverageMark = new System.Windows.Forms.Label();
            this.textBoxAverageMark = new System.Windows.Forms.TextBox();
            this.labelIsBudget = new System.Windows.Forms.Label();
            this.radioButtonIsBudget = new System.Windows.Forms.RadioButton();
            this.buttonInsertStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(33, 312);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(558, 180);
            this.listBoxStudents.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Ime:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(191, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(400, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelIndexNumber
            // 
            this.labelIndexNumber.AutoSize = true;
            this.labelIndexNumber.Location = new System.Drawing.Point(30, 62);
            this.labelIndexNumber.Name = "labelIndexNumber";
            this.labelIndexNumber.Size = new System.Drawing.Size(90, 17);
            this.labelIndexNumber.TabIndex = 3;
            this.labelIndexNumber.Text = "Broj indeksa:";
            this.labelIndexNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIndexNumber
            // 
            this.textBoxIndexNumber.Location = new System.Drawing.Point(191, 62);
            this.textBoxIndexNumber.Name = "textBoxIndexNumber";
            this.textBoxIndexNumber.Size = new System.Drawing.Size(400, 22);
            this.textBoxIndexNumber.TabIndex = 4;
            // 
            // labelPointsESPB
            // 
            this.labelPointsESPB.AutoSize = true;
            this.labelPointsESPB.Location = new System.Drawing.Point(30, 104);
            this.labelPointsESPB.Name = "labelPointsESPB";
            this.labelPointsESPB.Size = new System.Drawing.Size(87, 17);
            this.labelPointsESPB.TabIndex = 5;
            this.labelPointsESPB.Text = "ESPB poeni:";
            this.labelPointsESPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPointsESPB
            // 
            this.textBoxPointsESPB.Location = new System.Drawing.Point(191, 99);
            this.textBoxPointsESPB.Name = "textBoxPointsESPB";
            this.textBoxPointsESPB.Size = new System.Drawing.Size(400, 22);
            this.textBoxPointsESPB.TabIndex = 6;
            // 
            // labelStudyYear
            // 
            this.labelStudyYear.AutoSize = true;
            this.labelStudyYear.Location = new System.Drawing.Point(30, 139);
            this.labelStudyYear.Name = "labelStudyYear";
            this.labelStudyYear.Size = new System.Drawing.Size(101, 17);
            this.labelStudyYear.TabIndex = 7;
            this.labelStudyYear.Text = "GodinaStudija:";
            // 
            // textBoxStudyYear
            // 
            this.textBoxStudyYear.Location = new System.Drawing.Point(191, 139);
            this.textBoxStudyYear.Name = "textBoxStudyYear";
            this.textBoxStudyYear.Size = new System.Drawing.Size(400, 22);
            this.textBoxStudyYear.TabIndex = 8;
            // 
            // labelAverageMark
            // 
            this.labelAverageMark.AutoSize = true;
            this.labelAverageMark.Location = new System.Drawing.Point(30, 177);
            this.labelAverageMark.Name = "labelAverageMark";
            this.labelAverageMark.Size = new System.Drawing.Size(56, 17);
            this.labelAverageMark.TabIndex = 9;
            this.labelAverageMark.Text = "Prosek:";
            // 
            // textBoxAverageMark
            // 
            this.textBoxAverageMark.Location = new System.Drawing.Point(191, 174);
            this.textBoxAverageMark.Name = "textBoxAverageMark";
            this.textBoxAverageMark.Size = new System.Drawing.Size(400, 22);
            this.textBoxAverageMark.TabIndex = 10;
            // 
            // labelIsBudget
            // 
            this.labelIsBudget.AutoSize = true;
            this.labelIsBudget.Location = new System.Drawing.Point(30, 218);
            this.labelIsBudget.Name = "labelIsBudget";
            this.labelIsBudget.Size = new System.Drawing.Size(85, 17);
            this.labelIsBudget.TabIndex = 11;
            this.labelIsBudget.Text = "Na budžetu:";
            // 
            // radioButtonIsBudget
            // 
            this.radioButtonIsBudget.AutoSize = true;
            this.radioButtonIsBudget.Location = new System.Drawing.Point(191, 214);
            this.radioButtonIsBudget.Name = "radioButtonIsBudget";
            this.radioButtonIsBudget.Size = new System.Drawing.Size(47, 21);
            this.radioButtonIsBudget.TabIndex = 12;
            this.radioButtonIsBudget.TabStop = true;
            this.radioButtonIsBudget.Text = "Da";
            this.radioButtonIsBudget.UseVisualStyleBackColor = true;
            // 
            // buttonInsertStudent
            // 
            this.buttonInsertStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertStudent.Location = new System.Drawing.Point(344, 218);
            this.buttonInsertStudent.Name = "buttonInsertStudent";
            this.buttonInsertStudent.Size = new System.Drawing.Size(247, 77);
            this.buttonInsertStudent.TabIndex = 13;
            this.buttonInsertStudent.Text = "DODAJ";
            this.buttonInsertStudent.UseVisualStyleBackColor = true;
            this.buttonInsertStudent.Click += new System.EventHandler(this.buttonInsertStudent_Click);
            // 
            // StudentApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 489);
            this.Controls.Add(this.buttonInsertStudent);
            this.Controls.Add(this.radioButtonIsBudget);
            this.Controls.Add(this.labelIsBudget);
            this.Controls.Add(this.textBoxAverageMark);
            this.Controls.Add(this.labelAverageMark);
            this.Controls.Add(this.textBoxStudyYear);
            this.Controls.Add(this.labelStudyYear);
            this.Controls.Add(this.textBoxPointsESPB);
            this.Controls.Add(this.labelPointsESPB);
            this.Controls.Add(this.textBoxIndexNumber);
            this.Controls.Add(this.labelIndexNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "StudentApp";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.StudentApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIndexNumber;
        private System.Windows.Forms.TextBox textBoxIndexNumber;
        private System.Windows.Forms.Label labelPointsESPB;
        private System.Windows.Forms.TextBox textBoxPointsESPB;
        private System.Windows.Forms.Label labelStudyYear;
        private System.Windows.Forms.TextBox textBoxStudyYear;
        private System.Windows.Forms.Label labelAverageMark;
        private System.Windows.Forms.TextBox textBoxAverageMark;
        private System.Windows.Forms.Label labelIsBudget;
        private System.Windows.Forms.RadioButton radioButtonIsBudget;
        private System.Windows.Forms.Button buttonInsertStudent;
    }
}

