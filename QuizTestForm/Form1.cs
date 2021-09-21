using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace QuizTestForm
{
    public partial class Form1 : Form
    {
        string picturePath = @"C:\Users\oxotn\source\repos\QuizTestForm\QuizTestForm\Path.txt";
        List<string> list = new List<string>();
        int question = 1;
        int score;
        int percentage;
        int totalQuestion;
        int corrrectAnswer;
        
        List<int> count = new List<int>();
        public Form1()
        {
            InitializeComponent();
            AskQuestion(question);

            totalQuestion = 15;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            //var senderObject = (Button)sender;

            //int buttonTag = Convert.ToInt32(senderObject.Tag);

            //if (buttonTag == corrrectAnswer)
            //{
            //    score++;
            //}
            //if (question == totalQuestion)
            //{
            //    percentage = (int)Math.Round((double)(score * 100) / totalQuestion);

            //    MessageBox.Show("Quiz Ended!" + Environment.NewLine +
            //        "You have answered - " + score +
            //        " Question correctly " + Environment.NewLine +
            //        "Your total percentage is " + percentage + " %" + Environment.NewLine +
            //        "Click OK to Play again");

            //    score = 0;
            //    percentage = 0;
            //    question = 0;
            //    AskQuestion(question);
            //}

            //question++;
            //AskQuestion(question);
        }

        private void AskQuestion(int question)
        {
            StreamReader reader = new StreamReader(picturePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }
            reader.Close();
            switch (question)
            {
                case 1:pictureBox1.ImageLocation = list[question]; 
                    label_Question.Text = list[question + 1];
                    //button_answer1.Text = list[question + 2];
                    //button_answer2.Text = list[question + 3];
                    //button_answer3.Text = list[question + 4];
                    //button_answer4.Text = list[question + 5];
                    checkBox_answer1.Text = list[question + 2];
                    checkBox_answer2.Text = list[question + 3];
                    checkBox_answer3.Text = list[question + 4];
                    checkBox_answer4.Text = list[question + 5];
                    corrrectAnswer = Convert.ToInt32(list[question + 6]);

                    break;

                case 2:pictureBox1.ImageLocation = list[question + 6];
                    label_Question.Text = list[question + 7];
                    //button_answer1.Text = list[question + 8];
                    //button_answer2.Text = list[question + 9];
                    //button_answer3.Text = list[question + 10];
                    //button_answer4.Text = list[question + 11];
                    checkBox_answer1.Text = list[question + 8];
                    checkBox_answer2.Text = list[question + 9];
                    checkBox_answer3.Text = list[question + 10];
                    checkBox_answer4.Text = list[question + 11];
                    corrrectAnswer = Convert.ToInt32(list[question + 12]);
                    break;
                case 3:pictureBox1.ImageLocation = list[question + 12];
                    label_Question.Text = list[question + 13];
                    //button_answer1.Text = list[question + 14];
                    //button_answer2.Text = list[question + 15];
                    //button_answer3.Text = list[question + 16];
                    //button_answer4.Text = list[question + 17];
                    checkBox_answer1.Text = list[question + 14];
                    checkBox_answer2.Text = list[question + 15];
                    checkBox_answer3.Text = list[question + 16];
                    checkBox_answer4.Text = list[question + 17];
                    corrrectAnswer = Convert.ToInt32(list[question + 18]);
                    break;
                case 4:
                    pictureBox1.ImageLocation = list[question + 18];
                    label_Question.Text = list[question + 19];
                    //button_answer1.Text = list[question + 20];
                    //button_answer2.Text = list[question + 21];
                    //button_answer3.Text = list[question + 22];
                    //button_answer4.Text = list[question + 23];
                    checkBox_answer1.Text = list[question + 20];
                    checkBox_answer2.Text = list[question + 21];
                    checkBox_answer3.Text = list[question + 22];
                    checkBox_answer4.Text = list[question + 23];
                    corrrectAnswer = Convert.ToInt32(list[question + 24]);
                    break;
                case 5:
                    pictureBox1.ImageLocation = list[question + 24];
                    label_Question.Text = list[question + 25];
                    //button_answer1.Text = list[question + 26];
                    //button_answer2.Text = list[question + 27];
                    //button_answer3.Text = list[question + 28];
                    //button_answer4.Text = list[question + 29];
                    checkBox_answer1.Text = list[question + 26];
                    checkBox_answer2.Text = list[question + 27];
                    checkBox_answer3.Text = list[question + 28];
                    checkBox_answer4.Text = list[question + 29];
                    corrrectAnswer = Convert.ToInt32(list[question + 30]);
                    break;
                case 6:
                    pictureBox1.ImageLocation = list[question + 30];
                    label_Question.Text = list[question + 31];
                    //button_answer1.Text = list[question + 32];
                    //button_answer2.Text = list[question + 33];
                    //button_answer3.Text = list[question + 34];
                    //button_answer4.Text = list[question + 35];
                    checkBox_answer1.Text = list[question + 32];
                    checkBox_answer2.Text = list[question + 33];
                    checkBox_answer3.Text = list[question + 34];
                    checkBox_answer4.Text = list[question + 35];
                    corrrectAnswer = Convert.ToInt32(list[question + 36]);
                    break;
                case 7:
                    pictureBox1.ImageLocation = list[question + 36];
                    label_Question.Text = list[question + 37];
                    //button_answer1.Text = list[question + 38];
                    //button_answer2.Text = list[question + 39];
                    //button_answer3.Text = list[question + 40];
                    //button_answer4.Text = list[question + 41];
                    checkBox_answer1.Text = list[question + 38];
                    checkBox_answer2.Text = list[question + 39];
                    checkBox_answer3.Text = list[question + 40];
                    checkBox_answer4.Text = list[question + 41];
                    corrrectAnswer = Convert.ToInt32(list[question + 42]);
                    break;
                case 8:
                    pictureBox1.ImageLocation = list[question + 42];
                    label_Question.Text = list[question + 43];
                    //button_answer1.Text = list[question + 44];
                    //button_answer2.Text = list[question + 45];
                    //button_answer3.Text = list[question + 46];
                    //button_answer4.Text = list[question + 47];
                    checkBox_answer1.Text = list[question + 44];
                    checkBox_answer2.Text = list[question + 45];
                    checkBox_answer3.Text = list[question + 46];
                    checkBox_answer4.Text = list[question + 47];
                    corrrectAnswer = Convert.ToInt32(list[question + 48]);
                    break;
                case 9:
                    pictureBox1.ImageLocation = list[question + 48];
                    label_Question.Text = list[question + 49];
                    //button_answer1.Text = list[question + 50];
                    //button_answer2.Text = list[question + 51];
                    //button_answer3.Text = list[question + 52];
                    //button_answer4.Text = list[question + 53];
                    checkBox_answer1.Text = list[question + 50];
                    checkBox_answer2.Text = list[question + 51];
                    checkBox_answer3.Text = list[question + 52];
                    checkBox_answer4.Text = list[question + 53];
                    corrrectAnswer = Convert.ToInt32(list[question + 54]);
                    break;
                case 10:
                    pictureBox1.ImageLocation = list[question + 54];
                    label_Question.Text = list[question + 55];
                    //button_answer1.Text = list[question + 56];
                    //button_answer2.Text = list[question + 57];
                    //button_answer3.Text = list[question + 58];
                    //button_answer4.Text = list[question + 59];
                    checkBox_answer1.Text = list[question + 56];
                    checkBox_answer2.Text = list[question + 57];
                    checkBox_answer3.Text = list[question + 58];
                    checkBox_answer4.Text = list[question + 59];
                    corrrectAnswer = Convert.ToInt32(list[question + 60]);
                    break;
                case 11:
                    pictureBox1.ImageLocation = list[question + 60];
                    label_Question.Text = list[question + 61];
                    //button_answer1.Text = list[question + 62];
                    //button_answer2.Text = list[question + 63];
                    //button_answer3.Text = list[question + 64];
                    //button_answer4.Text = list[question + 65];
                    checkBox_answer1.Text = list[question + 62];
                    checkBox_answer2.Text = list[question + 63];
                    checkBox_answer3.Text = list[question + 64];
                    checkBox_answer4.Text = list[question + 65];
                    corrrectAnswer = Convert.ToInt32(list[question + 66]);
                    break;
                case 12:
                    pictureBox1.ImageLocation = list[question + 66];
                    label_Question.Text = list[question + 67];
                    //button_answer1.Text = list[question + 68];
                    //button_answer2.Text = list[question + 69];
                    //button_answer3.Text = list[question + 70];
                    //button_answer4.Text = list[question + 71];
                    checkBox_answer1.Text = list[question + 68];
                    checkBox_answer2.Text = list[question + 69];
                    checkBox_answer3.Text = list[question + 70];
                    checkBox_answer4.Text = list[question + 71];
                    corrrectAnswer = Convert.ToInt32(list[question + 72]);
                    break;
                case 13:
                    pictureBox1.ImageLocation = list[question + 72];
                    label_Question.Text = list[question + 73];
                    //button_answer1.Text = list[question + 74];
                    //button_answer2.Text = list[question + 75];
                    //button_answer3.Text = list[question + 76];
                    //button_answer4.Text = list[question + 77];
                    checkBox_answer1.Text = list[question + 74];
                    checkBox_answer2.Text = list[question + 75];
                    checkBox_answer3.Text = list[question + 76];
                    checkBox_answer4.Text = list[question + 77];
                    corrrectAnswer = Convert.ToInt32(list[question + 78]);
                    break;
                case 14:
                    pictureBox1.ImageLocation = list[question + 78];
                    label_Question.Text = list[question + 79];
                    //button_answer1.Text = list[question + 80];
                    //button_answer2.Text = list[question + 81];
                    //button_answer3.Text = list[question + 82];
                    //button_answer4.Text = list[question + 83];
                    checkBox_answer1.Text = list[question + 80];
                    checkBox_answer2.Text = list[question + 81];
                    checkBox_answer3.Text = list[question + 82];
                    checkBox_answer4.Text = list[question + 83];
                    corrrectAnswer = Convert.ToInt32(list[question + 84]);
                    break;
                case 15:
                    pictureBox1.ImageLocation = list[question + 84];
                    label_Question.Text = list[question + 85];
                    //button_answer1.Text = list[question + 86];
                    //button_answer2.Text = list[question + 87];
                    //button_answer3.Text = list[question + 88];
                    //button_answer4.Text = list[question + 89];
                    checkBox_answer1.Text = list[question + 86];
                    checkBox_answer2.Text = list[question + 87];
                    checkBox_answer3.Text = list[question + 88];
                    checkBox_answer4.Text = list[question + 89];
                    corrrectAnswer = Convert.ToInt32(list[question + 90]);
                    break;

            }
        }

        private void button_NextPrevios_Click(object sender, EventArgs e)
        {
            var check = (Button)sender;
            int checkAns1 = Convert.ToInt32(checkBox_answer1.Tag);
            int checkAns2 = Convert.ToInt32(checkBox_answer2.Tag);
            int checkAns3 = Convert.ToInt32(checkBox_answer3.Tag);
            int checkAns4 = Convert.ToInt32(checkBox_answer4.Tag);
            var box = new CheckBox();
            var selectitem = new ComboBox();
            

            string button = Convert.ToString(check.Tag);
            if (checkBox_answer1.Checked && checkBox_answer2.Checked && checkBox_answer3.Checked && checkBox_answer4.Checked)
            {
                MessageBox.Show("Please check 1 answer");
            }
            else if (checkBox_answer1.Checked && checkBox_answer2.Checked && checkBox_answer3.Checked || checkBox_answer4.Checked && checkBox_answer1.Checked && checkBox_answer3.Checked || checkBox_answer1.Checked && checkBox_answer2.Checked && checkBox_answer4.Checked )
            {
                MessageBox.Show("Please check 1 answer");
            }
            else if (checkBox_answer1.Checked && checkBox_answer2.Checked || checkBox_answer1.Checked && checkBox_answer3.Checked || checkBox_answer1.Checked && checkBox_answer4.Checked || checkBox_answer2.Checked && checkBox_answer3.Checked || checkBox_answer2.Checked && checkBox_answer4.Checked || checkBox_answer3.Checked && checkBox_answer4.Checked)
            {
                MessageBox.Show("Please check 1 answer");
            }
            else
            {
                if (question != totalQuestion && button == "next")
                {
                    if (checkBox_answer1.Checked)
                    {
                        if (checkAns1 == corrrectAnswer)
                        {
                            score++;
                        }
                    }
                    else if (checkBox_answer2.Checked)
                    {
                        if (checkAns2 == corrrectAnswer)
                        {
                            score++;
                        }
                    }
                    else if (checkBox_answer3.Checked)
                    {
                        if (checkAns3 == corrrectAnswer)
                        {
                            score++;
                        }
                    }
                    else if (checkBox_answer4.Checked)
                    {
                        if (checkAns4 == corrrectAnswer)
                        {
                            score++;
                        }
                    }
                    question++;
                    AskQuestion(question);
                    checkBox_answer1.Checked = false;
                    checkBox_answer2.Checked = false;
                    checkBox_answer3.Checked = false;
                    checkBox_answer4.Checked = false;
                    
                }
                else if (question != totalQuestion && button == "previos" && question > 1)
                {
                    //if (comboBox1=)
                    //{

                    //}
                    score--;
                    question--;
                    AskQuestion(question);
                    checkBox_answer1.Checked = false;
                    checkBox_answer2.Checked = false;
                    checkBox_answer3.Checked = false;
                    checkBox_answer4.Checked = false;
                }
            }
        }

        private void CheckCheckBoxAnswers(object sender,EventArgs e)
        {
            //count++;
            //var check = (CheckBox)sender;
            //int checkTag = Convert.ToInt32(check.Tag);
            //if (checkTag == corrrectAnswer && check.Checked)
            //{
            //    score++;
            //}
            //else if (score == 0 && checkTag != corrrectAnswer)
            //{
            //    score = 0;
            //}
            //else if (score > 0 && checkTag != corrrectAnswer)
            //{
            //    score--;
            //}
        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            percentage = (int)Math.Round((double)(score * 100) / totalQuestion);

                MessageBox.Show("Quiz Ended!" + Environment.NewLine +
                    "You have answered - " + score +
                    " Question correctly " + Environment.NewLine +
                    "Your total percentage is " + percentage + " %" + Environment.NewLine +
                    "Click OK to Play again");
            score = 0;
            percentage = 0;
            question = 1;
            checkBox_answer1.Checked = false;
            checkBox_answer2.Checked = false;
            checkBox_answer3.Checked = false;
            checkBox_answer4.Checked = false;
            AskQuestion(question);
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            score = 0;
            percentage = 0;
            question = 1;
            checkBox_answer1.Checked = false;
            checkBox_answer2.Checked = false;
            checkBox_answer3.Checked = false;
            checkBox_answer4.Checked = false;
            AskQuestion(question);
        }
    }
}
