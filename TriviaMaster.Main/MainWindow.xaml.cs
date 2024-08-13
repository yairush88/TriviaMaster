using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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

                ResetButtonColors();
                EnableAnswerButtons(true);
            }
            else
            {
                MessageBox.Show($"סיום משחק! ענית נכון על {correctAnswers} מתוך {currentQuestions.Count} שאלות.");
                // Optionally reset or show a restart button
            }
        }

        private void ResetButtonColors()
        {
            btnAnswer1.ClearValue(BackgroundProperty);
            btnAnswer2.ClearValue(BackgroundProperty);
            btnAnswer3.ClearValue(BackgroundProperty);
            btnAnswer4.ClearValue(BackgroundProperty);
        }

        private async void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int selectedAnswerIndex = int.Parse(button.Tag.ToString());
            EnableAnswerButtons(false);

            if (currentQuestions[currentQuestionIndex].IsCorrect(selectedAnswerIndex))
            {
                button.Background = new SolidColorBrush(Colors.Green);
                correctAnswers++;
            }
            else
            {
                button.Background = new SolidColorBrush(Colors.Red);
                HighlightCorrectAnswer();
            }

            // Wait for 2 seconds before moving to the next question
            await Task.Delay(2000);

            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void HighlightCorrectAnswer()
        {
            int correctIndex = currentQuestions[currentQuestionIndex].CorrectAnswerIndex;

            switch (correctIndex)
            {
                case 0:
                    btnAnswer1.Background = new SolidColorBrush(Colors.Green);
                    break;
                case 1:
                    btnAnswer2.Background = new SolidColorBrush(Colors.Green);
                    break;
                case 2:
                    btnAnswer3.Background = new SolidColorBrush(Colors.Green);
                    break;
                case 3:
                    btnAnswer4.Background = new SolidColorBrush(Colors.Green);
                    break;
            }
        }

        private void EnableAnswerButtons(bool isEnabled)
        {
            btnAnswer1.IsEnabled = isEnabled;
            btnAnswer2.IsEnabled = isEnabled;
            btnAnswer3.IsEnabled = isEnabled;
            btnAnswer4.IsEnabled = isEnabled;
        }

        private void TopicButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string selectedTopic = button.Content.ToString();
            LoadQuestions(selectedTopic);
        }
    }
}
