namespace TriviaMaster.Common
{
    public class Question
    {
        public string Text { get; }
        public List<string> Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string text, List<string> answers, int correctAnswerIndex)
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrect(int selectedAnswerIndex)
        {
            return selectedAnswerIndex == CorrectAnswerIndex;
        }
    }

}
