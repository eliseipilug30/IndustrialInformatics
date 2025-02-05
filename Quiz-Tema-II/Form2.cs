using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_Tema_II
{
    public partial class Form2 : Form

    {
        private List<QuizQuestion> questions;
        private int currentQuestionIndex;
        private int totalQuestions;
        private int totaplQuestions;

        public Form2()
        {
            InitializeComponent();
            InitializeQuiz();

        }
        private void InitializeQuiz()
        {
            



            questions = new List<QuizQuestion>
            {
                new QuizQuestion("Care este capitala României?", new List<string> { "București", "Cluj-Napoca", "Iași", "Timișoara" }, 0),
                new QuizQuestion("Cine a fost Mihai Eminescu?", new List<string> { "un actor", "un inventator", "un poet", "un om de stiinta" }, 2),
                new QuizQuestion("Cine a pictat Mona Lisa?", new List<string> { "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" }, 0),

            };
            // Inițializează variabilele pentru quiz
            currentQuestionIndex = 0;
            totalQuestions = questions.Count;

            // Afișează prima întrebare
            ShowQuestion(currentQuestionIndex);



        }
        private void ShowQuestion(int index)
        {
            if (index >= 0 && index < totalQuestions)
            {
                // Afișează întrebarea și opțiunile de răspuns
                QuizQuestion question = questions[index];
                label1.Text = question.Text;
                radioButton1.Text = question.Answers[0];
                radioButton2.Text = question.Answers[1];
                radioButton3.Text = question.Answers[2];
                radioButton4.Text = question.Answers[3];

                // Resetează butoanele radio
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }



        public class QuizQuestion
        {
            public string Text { get; set; }
            public List<string> Answers { get; set; }
            public int CorrectAnswerIndex { get; set; }

            public QuizQuestion(string text, List<string> answers, int correctAnswerIndex)
            {
                Text = text;
                Answers = answers;
                CorrectAnswerIndex = correctAnswerIndex;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                QuizQuestion currentQuestion = questions[currentQuestionIndex];

                if (radioButton1.Checked && currentQuestion.CorrectAnswerIndex != 0 ||
        radioButton2.Checked && currentQuestion.CorrectAnswerIndex != 1 ||
        radioButton3.Checked && currentQuestion.CorrectAnswerIndex != 2 ||
        radioButton4.Checked && currentQuestion.CorrectAnswerIndex != 3)
                {
                    MessageBox.Show("Raspuns Incorect");
                }

                if (radioButton1.Checked && currentQuestion.CorrectAnswerIndex == 0 ||
           radioButton2.Checked && currentQuestion.CorrectAnswerIndex == 1 ||
           radioButton3.Checked && currentQuestion.CorrectAnswerIndex == 2 ||
           radioButton4.Checked && currentQuestion.CorrectAnswerIndex == 3)

                {
                    currentQuestionIndex++;
                    if (currentQuestionIndex < totalQuestions)
                    {
                        ShowQuestion(currentQuestionIndex);
                    }
                    else

                    {
                        progressBar.Value = 100;
                        MessageBox.Show("Quiz completat! Felicitări!");
                    }
                    progressBar.Value = (currentQuestionIndex * 100) / totalQuestions;
                  
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un răspuns înainte de a trece la următoarea întrebare.");
            }

        }



    }
}
