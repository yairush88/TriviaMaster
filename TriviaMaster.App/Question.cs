namespace TriviaMaster.App
{
    public class Question(string text, List<string> answers, int correctAnswerIndex)
    {
        public string Text { get; } = text;
        public List<string> Answers { get; } = answers;
        public int CorrectAnswerIndex { get; } = correctAnswerIndex;
    }
}
