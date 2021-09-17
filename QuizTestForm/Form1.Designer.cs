
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
            this.button_answer1 = new System.Windows.Forms.Button();
            this.button_answer2 = new System.Windows.Forms.Button();
            this.button_answer3 = new System.Windows.Forms.Button();
            this.button_answer4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(997, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Question
            // 
            this.label_Question.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Question.Location = new System.Drawing.Point(12, 444);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(997, 212);
            this.label_Question.TabIndex = 1;
            this.label_Question.Text = "Question";
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_answer1
            // 
            this.button_answer1.BackColor = System.Drawing.Color.Chartreuse;
            this.button_answer1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_answer1.Location = new System.Drawing.Point(51, 681);
            this.button_answer1.Name = "button_answer1";
            this.button_answer1.Size = new System.Drawing.Size(416, 114);
            this.button_answer1.TabIndex = 2;
            this.button_answer1.Tag = "1";
            this.button_answer1.Text = "button_answer1";
            this.button_answer1.UseVisualStyleBackColor = false;
            this.button_answer1.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // button_answer2
            // 
            this.button_answer2.BackColor = System.Drawing.Color.Chartreuse;
            this.button_answer2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_answer2.Location = new System.Drawing.Point(51, 830);
            this.button_answer2.Name = "button_answer2";
            this.button_answer2.Size = new System.Drawing.Size(416, 123);
            this.button_answer2.TabIndex = 2;
            this.button_answer2.Tag = "2";
            this.button_answer2.Text = "button_answer2";
            this.button_answer2.UseVisualStyleBackColor = false;
            this.button_answer2.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // button_answer3
            // 
            this.button_answer3.BackColor = System.Drawing.Color.Chartreuse;
            this.button_answer3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_answer3.Location = new System.Drawing.Point(561, 681);
            this.button_answer3.Name = "button_answer3";
            this.button_answer3.Size = new System.Drawing.Size(436, 114);
            this.button_answer3.TabIndex = 2;
            this.button_answer3.Tag = "3";
            this.button_answer3.Text = "button_Answer3";
            this.button_answer3.UseVisualStyleBackColor = false;
            this.button_answer3.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // button_answer4
            // 
            this.button_answer4.BackColor = System.Drawing.Color.Chartreuse;
            this.button_answer4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_answer4.Location = new System.Drawing.Point(561, 830);
            this.button_answer4.Name = "button_answer4";
            this.button_answer4.Size = new System.Drawing.Size(436, 123);
            this.button_answer4.TabIndex = 2;
            this.button_answer4.Tag = "4";
            this.button_answer4.Text = "button_answer4";
            this.button_answer4.UseVisualStyleBackColor = false;
            this.button_answer4.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1021, 965);
            this.Controls.Add(this.button_answer2);
            this.Controls.Add(this.button_answer4);
            this.Controls.Add(this.button_answer3);
            this.Controls.Add(this.button_answer1);
            this.Controls.Add(this.label_Question);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Button button_answer1;
        private System.Windows.Forms.Button button_answer2;
        private System.Windows.Forms.Button button_answer3;
        private System.Windows.Forms.Button button_answer4;
    }
}

