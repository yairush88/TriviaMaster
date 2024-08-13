using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TriviaMaster.Common;

namespace TriviaMaster.Main
{
    public partial class MainWindow : Window
    {
        private List<Question> currentQuestions;
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadQuestions(string topic)
        {
            // Get 10 random questions based on the selected topic
            currentQuestions = QuestionRepository.GetRandomQuestions(topic);
            currentQuestionIndex = 0;
            correctAnswers = 0;

            // Hide the topic selection panel and show the question panel
            topicSelectionPanel.Visibility = Visibility.Collapsed;
            questionPanel.Visibility = Visibility.Visible;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < currentQuestions.Count)
            {
                var question = currentQuestions[currentQuestionIndex];
                lblQuestion.Text = question.Text;

                btnAnswer1.Content = question.Answers[0];
                btnAnswer2.Content = question.Answers[1];
                btnAnswer3.Content = question.Answers[2];
                btnAnswer4.Content = question.Answers[3];
            }
            else
            {
                MessageBox.Show($"סיום משחק! ענית נכון על {correctAnswers} מתוך {currentQuestions.Count} שאלות.");
                // Optionally reset or show a restart button
            }
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int selectedAnswerIndex = int.Parse(button.Tag.ToString());

            if (currentQuestions[currentQuestionIndex].IsCorrect(selectedAnswerIndex))
            {
                correctAnswers++;
            }

            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void TopicButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string selectedTopic = button.Content.ToString();
            LoadQuestions(selectedTopic);
        }
    }
}
