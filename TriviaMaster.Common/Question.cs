namespace TriviaMaster.Common
{
    public class Question(string Text, List<string> Answers, int CorrectAnswerIndex)
    {
        public string Text { get; } = Text;
        public List<string> Answers { get; } = Answers;
        public int CorrectAnswerIndex { get; } = CorrectAnswerIndex;

        public bool IsCorrect(int selectedAnswerIndex)
        {
            return selectedAnswerIndex == CorrectAnswerIndex;
        }
    }
}
