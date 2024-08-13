﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using TriviaMaster.Common;

namespace TriviaMaster.Main
{
    public partial class MainWindow : Window
    {
        private List<Question> _currentQuestions;
        private int _currentQuestionIndex;
        private int _correctAnswers;
        private string _selectedTopic;
        private readonly DispatcherTimer _timer;
        private int _timeLeft;

        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft--;
                LblTimer.Text = $"זמן שנותר: {_timeLeft} שניות";
            }
            else
            {
                _timer.Stop();
                HighlightCorrectAnswerWithTimeout();
                NextQuestionWithDelay();
            }
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
                // Show the timer and question number at the beginning of each question
                LblTimer.Visibility = Visibility.Visible;
                LblQuestionNumber.Visibility = Visibility.Visible;

                var question = _currentQuestions[_currentQuestionIndex];
                LblQuestionNumber.Text = $"שאלה {_currentQuestionIndex + 1} מתוך {_currentQuestions.Count}";
                LblTimer.Text = $"זמן שנותר: 15 שניות";
                LblQuestion.Text = question.Text;

                BtnAnswer1.Content = question.Answers[0];
                BtnAnswer2.Content = question.Answers[1];
                BtnAnswer3.Content = question.Answers[2];
                BtnAnswer4.Content = question.Answers[3];

                ResetButtonColors();
                EnableAnswerButtons(true);

                _timeLeft = 15;
                _timer.Start();
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
            _timer.Stop();
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
            Button correctButton = GetButtonByIndex(correctIndex);
            correctButton.Background = new SolidColorBrush(Colors.Green);
        }

        private void HighlightCorrectAnswerWithTimeout()
        {
            int correctIndex = _currentQuestions[_currentQuestionIndex].CorrectAnswerIndex;
            Button correctButton = GetButtonByIndex(correctIndex);
            correctButton.Background = new SolidColorBrush(Colors.Orange); // Use orange for timeout correct answer
        }

        private Button GetButtonByIndex(int index)
        {
            return index switch
            {
                0 => BtnAnswer1,
                1 => BtnAnswer2,
                2 => BtnAnswer3,
                3 => BtnAnswer4,
                _ => null,
            };
        }

        private async void NextQuestionWithDelay()
        {
            await Task.Delay(2000);
            _currentQuestionIndex++;
            DisplayQuestion();
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
            // Hide the question panel and show the results panel
            QuestionPanel.Visibility = Visibility.Collapsed;
            ResultPanel.Visibility = Visibility.Visible;

            // Hide the timer and question number
            LblTimer.Visibility = Visibility.Collapsed;
            LblQuestionNumber.Visibility = Visibility.Collapsed;

            // Display the results
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
