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
        private List<Question> _currentQuestions;
        private int _currentQuestionIndex;
        private int _correctAnswers;
        private string _selectedTopic;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadQuestions(string topic)
        {
            _selectedTopic = topic;
            _currentQuestions = QuestionRepository.GetRandomQuestions(topic);
            _currentQuestionIndex = 0;
            _correctAnswers = 0;

            TopicSelectionPanel.Visibility = Visibility.Collapsed;
            QuestionPanel.Visibility = Visibility.Visible;
            ResultPanel.Visibility = Visibility.Collapsed;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (_currentQuestionIndex < _currentQuestions.Count)
            {
                var question = _currentQuestions[_currentQuestionIndex];
                LblQuestion.Text = question.Text;

                BtnAnswer1.Content = question.Answers[0];
                BtnAnswer2.Content = question.Answers[1];
                BtnAnswer3.Content = question.Answers[2];
                BtnAnswer4.Content = question.Answers[3];

                ResetButtonColors();
                EnableAnswerButtons(true);
            }
            else
            {
                ShowResults();
            }
        }

        private void ResetButtonColors()
        {
            BtnAnswer1.ClearValue(BackgroundProperty);
            BtnAnswer2.ClearValue(BackgroundProperty);
            BtnAnswer3.ClearValue(BackgroundProperty);
            BtnAnswer4.ClearValue(BackgroundProperty);
        }

        private async void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int selectedAnswerIndex = int.Parse(button.Tag.ToString());
            EnableAnswerButtons(false);

            if (_currentQuestions[_currentQuestionIndex].IsCorrect(selectedAnswerIndex))
            {
                button.Background = new SolidColorBrush(Colors.Green);
                _correctAnswers++;
            }
            else
            {
                button.Background = new SolidColorBrush(Colors.Red);
                HighlightCorrectAnswer();
            }

            await Task.Delay(2000);

            _currentQuestionIndex++;
            DisplayQuestion();
        }

        private void HighlightCorrectAnswer()
        {
            int correctIndex = _currentQuestions[_currentQuestionIndex].CorrectAnswerIndex;

            switch (correctIndex)
            {
                case 0:
                    BtnAnswer1.Background = new SolidColorBrush(Colors.Green);
                    break;
                case 1:
                    BtnAnswer2.Background = new SolidColorBrush(Colors.Green);
                    break;
                case 2:
                    BtnAnswer3.Background = new SolidColorBrush(Colors.Green);
                    break;
                case 3:
                    BtnAnswer4.Background = new SolidColorBrush(Colors.Green);
                    break;
            }
        }

        private void EnableAnswerButtons(bool isEnabled)
        {
            BtnAnswer1.IsEnabled = isEnabled;
            BtnAnswer2.IsEnabled = isEnabled;
            BtnAnswer3.IsEnabled = isEnabled;
            BtnAnswer4.IsEnabled = isEnabled;
        }

        private void ShowResults()
        {
            QuestionPanel.Visibility = Visibility.Collapsed;
            ResultPanel.Visibility = Visibility.Visible;

            LblResult.Text = $"סיום משחק! ענית נכון על {_correctAnswers} מתוך {_currentQuestions.Count} שאלות.";
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            ResultPanel.Visibility = Visibility.Collapsed;
            TopicSelectionPanel.Visibility = Visibility.Visible;
        }

        private void PlayAgainButton_Click(object sender, RoutedEventArgs e)
        {
            LoadQuestions(_selectedTopic);
        }

        private void TopicButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            LoadQuestions(button.Content.ToString());
        }
    }
}
