namespace TriviaMaster.App;
public partial class Form1 : Form
{
    private List<Question> questions;
    private int currentQuestionIndex = 0;
    private int correctAnswers = 0;

    public Form1()
    {
        InitializeComponent();
        SetupInitialView();
    }

    private void SetupInitialView()
    {
        btnHoliday.Visible = true;
        btnIsrael.Visible = true;
        btnJerusalem.Visible = true;
        lblQuestion.Visible = false;
        groupBoxAnswers.Visible = false;
        btnNext.Visible = false;
        lblScore.Visible = false;
        btnRetry.Visible = false;
    }

    private void StartGame(string topic)
    {
        InitializeQuestions(topic);
        currentQuestionIndex = 0;
        correctAnswers = 0;
        lblScore.Text = "����: 0 ���� 10";

        btnHoliday.Visible = false;
        btnIsrael.Visible = false;
        btnJerusalem.Visible = false;
        lblQuestion.Visible = true;
        groupBoxAnswers.Visible = true;
        btnNext.Visible = true;
        lblScore.Visible = true;

        DisplayQuestion();
    }

    private void InitializeQuestions(string topic)
    {
        var allQuestions = new List<Question>();

        switch (topic)
        {
            case "���� ������� �������":
                allQuestions = GetHolidayQuestions();
                break;
            case "����� �������":
                allQuestions = GetIsraelQuestions();
                break;
            case "�������":
                allQuestions = GetJerusalemQuestions();
                break;
        }

        // Randomly select 10 questions
        var random = new Random();
        questions = allQuestions.OrderBy(q => random.Next()).Take(10).ToList();
    }

    private List<Question> GetHolidayQuestions()
    {
        return
        [
            new Question("��� ��� ��� ������� �������?", ["��� ����", "�����", "�����", "�����"], 2),
                new Question("��� ��� ��� ������ �� �����?", ["�����", "���", "������", "�����"], 1),
                new Question("����� �� ������ ����?", ["�����", "�����", "���", "������"], 2),
                new Question("��� ��� ��� ������� ����� ����� ����?", ["���", "������", "��� ����", "�����"], 2),
                new Question("���� �� ���� ����� ����?", ["�����", "�����", "���", "�����"], 1),
                new Question("����� �� ������ �� ���� ���� �������?", ["��� ����", "��� �����", "�����", "���� ����"], 0),
                new Question("����� �� ������ �������?", ["���", "��� �����", "�����", "�����"], 1),
                new Question("����� �� ������ ����� ����?", ["���", "�����", "������", "�����"], 1),
                new Question("��� ��� ��� ������� ����� ����� ������?", ["�����", "���", "�����", "������"], 0),
                new Question("����� �� ������ �� �� �� ����?", ["���", "�����", "�����", "������"], 1),
                new Question("����� �� ������ �� ��� ����?", ["�����", "���", "�����", "������"], 3),
                new Question("��� ��� ��� ����� ���� �����?", ["�����", "���", "�����", "�����"], 0),
                new Question("��� ��� ��� ������ ����� ���?", ["���", "�����", "�����", "������"], 1),
                new Question("����� �� ������� �� ����� ��� �����?", ["���� ���", "��� �����", "�����", "���"], 0),
                new Question("��� ��� ��� ������ ������?", ["���", "�����", "�����", "�����"], 1),
                new Question("����� �� ������ ����� ����?", ["������", "�����", "���", "�����"], 1),
                new Question("��� ��� ��� ������ ���� �����?", ["�����", "������", "�����", "���"], 2),
                new Question("��� ��� ����� ����� ���� �������?", ["���", "������", "�����", "�����"], 1),
                new Question("��� ��� ��� ������ ������?", ["�����", "�����", "���", "�����"], 0),
                new Question("����� �� ������ ����� ���� ����?", ["��� ����", "�����", "���", "�����"], 0),
            ];
    }

    private List<Question> GetIsraelQuestions()
    {
        return
        [
            new Question("��� ������ ����� �����?", ["1948", "1956", "1967", "1973"], 0),
                new Question("�� ��� ��� ������ ������ �� �����?", ["��� ��-������", "����� ����", "���� ����", "���� ����"], 0),
                new Question("����� ��� ����� ���� ����� �� �����?", ["1979", "1981", "1973", "1982"], 0),
                new Question("���� ��� ��� ���� �����?", ["�� ����", "����", "�������", "��� ���"], 2),
                new Question("��� ��� ����� ����� ������?", ["�� ����", "�� �����", "�� ������", "�� ����"], 2),
                new Question("�� ��� ����� ������ �� �����?", ["���� �����", "���� ��-���", "����� ���", "����� ����"], 0),
                new Question("��� ���� ������� ����� ������?", ["��� ���", "����", "������", "���� ����"], 1),
                new Question("����� ��� ����� ���� �����?", ["1976", "1982", "1973", "1967"], 0),
                new Question("��� ���� ������ ������?", ["������", "�����", "�����", "�����"], 2),
                new Question("����� ��� ���� ����� ���?", ["�������", "����", "�� ����", "���"], 0),
                new Question("���� �� ���� ����� �� ����?", ["�� ���", "��� ������", "��� �����", "�� ����"], 1),
                new Question("��� ���� ������ �� �����?", ["����", "���� ���", "������", "����"], 2),
                new Question("���� ����� ������� ���� �������?", ["���� ������", "����� �����", "���� ����� ������", "����� �������"], 0),
                new Question("�� ��� �����\"� ������ ��� �����?", ["��� �����", "��� ����", "���� ����", "���� ����"], 3),
                new Question("����� ��� ����� ����� ��� ��������?", ["1973", "1967", "1982", "1956"], 0),
                new Question("��� ���� ������ ����� ������?", ["����", "�� ����", "�������", "����� �����"], 2),
                new Question("��� �����?", ["���� ������", "���� ������", "������� �� �����", "����� �������"], 2),
                new Question("���� ����� ������� ���� ������� ����� ������ �����?", ["���� ������� ������� �����", "���� ������� �����", "���� ������� ������ ����� �������", "���� ������� ����� ���"], 0),
                new Question("��� ���� ������� ������ ����� ���� �����?", ["�������", "�����", "���", "���"], 1),
                new Question("��� ������� �������?", ["����� ����", "����� ������", "����� ����� ������ ������", "��� �����"], 2),
            ];
    }

    private List<Question> GetJerusalemQuestions()
    {
        return
        [
            new Question("����� ��� ����� �������?", ["1967", "1948", "1956", "1973"], 0),
                new Question("��� ����� ������?", ["��� ����� ���� ������", "��� ���� �� �� ����", "��� ������ ���� ������", "���� ������"], 1),
                new Question("����� ��� ����� �������?", ["3000 ����\"�", "2000 ����\"�", "1000 ����\"�", "700 ����\"�"], 0),
                new Question("��� �� ����?", ["�� ����� ����", "�� ����� ��������", "�� ����� ����", "�� ����� ����"], 1),
                new Question("���� ��� ���� ����� ���� ������?", ["��� ������", "��� ���", "��� ���", "��� ����"], 2),
                new Question("�� ��� ���� ������ ���� �� ���� �������?", ["���", "����", "������", "������"], 2),
                new Question("��� ���� ����?", ["�����", "����", "���� ��� �� �� ����", "���"], 2),
                new Question("��� ���� ������ ��������?", ["��� ���� �����", "��� �����", "��� �������", "��� ���"], 0),
                new Question("����� ��� ���� ��� ����� ����?", ["70 ������", "100 ������", "586 ����\"�", "132 ������"], 0),
                new Question("��� �� ���� ����� ��������?", ["�����", "������", "�����", "����"], 2),
                new Question("���� ��� ����� \"��� ���\"?", ["�����", "�������", "��� ���", "���"], 1),
                new Question("��� ��� ����?", ["����� ��������", "��� ���� ������", "������", "��"], 0),
                new Question("��� ������ �������?", ["����� ��������", "����", "����", "������"], 0),
                new Question("����� ��� ����� ����� ��������?", ["1949", "1966", "1958", "1967"], 2),
                new Question("��� �� ����� ���� ��������?", ["���� ���", "���� �������", "���� �����", "���� ����"], 3),
                new Question("��� ���� ����� ����� ������?", ["��� ����", "��� ����", "������� �����", "��� ���"], 2),
                new Question("����� ��� ���� ��� ���� ��� ����� ��������?", ["1948", "1950", "1949", "1951"], 2),
                new Question("��� ��� ������?", ["�� ������", "�� ����", "������� ���", "�� �� ����� ��� �����"], 3),
                new Question("��� �� ���?", ["������� �����", "���� ���", "����������", "������"], 0),
                new Question("��� ��� ����� ��������?", ["��� ���", "��� ����", "����", "��� �����"], 2),
            ];
    }

    private void DisplayQuestion()
    {
        var question = questions[currentQuestionIndex];
        lblQuestion.Text = question.Text;

        for (int i = 0; i < question.Answers.Count; i++)
        {
            var radioButton = groupBoxAnswers.Controls[i] as RadioButton;
            radioButton.Text = question.Answers[i];
            radioButton.ForeColor = Color.Black;
            radioButton.Checked = false;

            // Align radio buttons to the right
            radioButton.RightToLeft = RightToLeft.Yes;
            radioButton.TextAlign = ContentAlignment.MiddleLeft;
            radioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
    }


    private void btnNext_Click(object sender, EventArgs e)
    {
        var selectedRadioButton = groupBoxAnswers.Controls
            .OfType<RadioButton>()
            .FirstOrDefault(r => r.Checked);

        if (selectedRadioButton == null)
        {
            MessageBox.Show("��� ��� �����.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedIndex = groupBoxAnswers.Controls.IndexOf(selectedRadioButton);
        var correctIndex = questions[currentQuestionIndex].CorrectAnswerIndex;

        if (selectedIndex == correctIndex)
        {
            selectedRadioButton.ForeColor = Color.Green;
            correctAnswers++;
        }
        else
        {
            selectedRadioButton.ForeColor = Color.Red;
            groupBoxAnswers.Controls[correctIndex].ForeColor = Color.Green;
        }

        lblScore.Text = $"����: {correctAnswers} ���� 10";

        btnNext.Enabled = false;
        currentQuestionIndex++;

        if (currentQuestionIndex < questions.Count)
        {
            var timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                btnNext.Enabled = true;
                DisplayQuestion();
            };
            timer.Start();
        }
        else
        {
            MessageBox.Show($"����� �� �����! ����: {correctAnswers} ���� {questions.Count}", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNext.Visible = false;
            btnRetry.Visible = true;
        }
    }

    private void btnRetry_Click(object sender, EventArgs e)
    {
        btnRetry.Visible = false;
        btnNext.Enabled = true;
        SetupInitialView();
    }

    private void btnHoliday_Click(object sender, EventArgs e)
    {
        StartGame("���� ������� �������");
    }

    private void btnIsrael_Click(object sender, EventArgs e)
    {
        StartGame("����� �������");
    }

    private void btnJerusalem_Click(object sender, EventArgs e)
    {
        StartGame("�������");
    }

    private void groupBoxAnswers_Enter(object sender, EventArgs e)
    {

    }
}

