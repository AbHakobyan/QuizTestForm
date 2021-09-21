
namespace QuizTestForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Question = new System.Windows.Forms.Label();
            this.checkBox_answer1 = new System.Windows.Forms.CheckBox();
            this.checkBox_answer2 = new System.Windows.Forms.CheckBox();
            this.checkBox_answer3 = new System.Windows.Forms.CheckBox();
            this.checkBox_answer4 = new System.Windows.Forms.CheckBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previos = new System.Windows.Forms.Button();
            this.button_Finish = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Question
            // 
            this.label_Question.BackColor = System.Drawing.Color.Firebrick;
            this.label_Question.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Question.ForeColor = System.Drawing.Color.Snow;
            this.label_Question.Location = new System.Drawing.Point(12, 437);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(997, 155);
            this.label_Question.TabIndex = 1;
            this.label_Question.Text = "Question";
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_answer1
            // 
            this.checkBox_answer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_answer1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_answer1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_answer1.Location = new System.Drawing.Point(12, 595);
            this.checkBox_answer1.Name = "checkBox_answer1";
            this.checkBox_answer1.Size = new System.Drawing.Size(504, 142);
            this.checkBox_answer1.TabIndex = 3;
            this.checkBox_answer1.Tag = "1";
            this.checkBox_answer1.Text = "checkBox_answer1";
            this.checkBox_answer1.UseVisualStyleBackColor = false;
            this.checkBox_answer1.Click += new System.EventHandler(this.CheckCheckBoxAnswers);
            // 
            // checkBox_answer2
            // 
            this.checkBox_answer2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_answer2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_answer2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_answer2.Location = new System.Drawing.Point(12, 743);
            this.checkBox_answer2.Name = "checkBox_answer2";
            this.checkBox_answer2.Size = new System.Drawing.Size(504, 148);
            this.checkBox_answer2.TabIndex = 4;
            this.checkBox_answer2.Tag = "2";
            this.checkBox_answer2.Text = "checkBox_answer2";
            this.checkBox_answer2.UseVisualStyleBackColor = false;
            this.checkBox_answer2.Click += new System.EventHandler(this.CheckCheckBoxAnswers);
            // 
            // checkBox_answer3
            // 
            this.checkBox_answer3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_answer3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_answer3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_answer3.Location = new System.Drawing.Point(522, 595);
            this.checkBox_answer3.Name = "checkBox_answer3";
            this.checkBox_answer3.Size = new System.Drawing.Size(487, 142);
            this.checkBox_answer3.TabIndex = 5;
            this.checkBox_answer3.Tag = "3";
            this.checkBox_answer3.Text = "checkBox_answer3";
            this.checkBox_answer3.UseVisualStyleBackColor = false;
            this.checkBox_answer3.CheckStateChanged += new System.EventHandler(this.CheckCheckBoxAnswers);
            // 
            // checkBox_answer4
            // 
            this.checkBox_answer4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_answer4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_answer4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_answer4.Location = new System.Drawing.Point(522, 743);
            this.checkBox_answer4.Name = "checkBox_answer4";
            this.checkBox_answer4.Size = new System.Drawing.Size(487, 148);
            this.checkBox_answer4.TabIndex = 6;
            this.checkBox_answer4.Tag = "4";
            this.checkBox_answer4.Text = "checkBox_answer4";
            this.checkBox_answer4.UseVisualStyleBackColor = false;
            this.checkBox_answer4.Click += new System.EventHandler(this.CheckCheckBoxAnswers);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Next.Location = new System.Drawing.Point(295, 897);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(146, 29);
            this.button_Next.TabIndex = 7;
            this.button_Next.Tag = "next";
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_NextPrevios_Click);
            // 
            // button_Previos
            // 
            this.button_Previos.BackColor = System.Drawing.Color.DarkBlue;
            this.button_Previos.Location = new System.Drawing.Point(23, 897);
            this.button_Previos.Name = "button_Previos";
            this.button_Previos.Size = new System.Drawing.Size(169, 29);
            this.button_Previos.TabIndex = 8;
            this.button_Previos.Tag = "previos";
            this.button_Previos.Text = "Previos";
            this.button_Previos.UseVisualStyleBackColor = false;
            this.button_Previos.Click += new System.EventHandler(this.button_NextPrevios_Click);
            // 
            // button_Finish
            // 
            this.button_Finish.BackColor = System.Drawing.Color.Green;
            this.button_Finish.Location = new System.Drawing.Point(850, 897);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(159, 29);
            this.button_Finish.TabIndex = 9;
            this.button_Finish.Tag = "finish";
            this.button_Finish.Text = "Finish";
            this.button_Finish.UseVisualStyleBackColor = false;
            this.button_Finish.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Red;
            this.button_Reset.Location = new System.Drawing.Point(557, 897);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(149, 29);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Tag = "reset";
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1021, 931);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Finish);
            this.Controls.Add(this.button_Previos);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.checkBox_answer4);
            this.Controls.Add(this.checkBox_answer3);
            this.Controls.Add(this.checkBox_answer2);
            this.Controls.Add(this.checkBox_answer1);
            this.Controls.Add(this.label_Question);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.CheckBox checkBox_answer1;
        private System.Windows.Forms.CheckBox checkBox_answer2;
        private System.Windows.Forms.CheckBox checkBox_answer3;
        private System.Windows.Forms.CheckBox checkBox_answer4;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Previos;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Button button_Reset;
    }
}

