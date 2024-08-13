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
        lblScore.Text = "נכון: 0 מתוך 10";

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
            case "חגים ומועדים יהודיים":
                allQuestions = GetHolidayQuestions();
                break;
            case "ישראל וציונות":
                allQuestions = GetIsraelQuestions();
                break;
            case "ירושלים":
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
            new Question("מהו החג שבו מדליקים חנוכייה?", ["ראש השנה", "פורים", "חנוכה", "סוכות"], 2),
                new Question("מהו החג שבו קוראים את ההגדה?", ["סוכות", "פסח", "שבועות", "פורים"], 1),
                new Question("באיזה חג אוכלים מצות?", ["פורים", "סוכות", "פסח", "שבועות"], 2),
                new Question("מהו החג שבו מקיימים מצוות תקיעת שופר?", ["פסח", "שבועות", "ראש השנה", "חנוכה"], 2),
                new Question("איזה חג נמשך שמונה ימים?", ["סוכות", "חנוכה", "פסח", "פורים"], 1),
                new Question("באיזה חג חוגגים את סיום השנה היהודית?", ["ראש השנה", "יום כיפור", "סוכות", "שמחת תורה"], 0),
                new Question("באיזה חג נוהגים להתענות?", ["פסח", "יום כיפור", "פורים", "חנוכה"], 1),
                new Question("באיזה חג נוהגים לבנות סוכה?", ["פסח", "סוכות", "שבועות", "חנוכה"], 1),
                new Question("מהו החג שבו מקיימים מצוות ארבעת המינים?", ["סוכות", "פסח", "פורים", "שבועות"], 0),
                new Question("באיזה חג חוגגים את נס פך השמן?", ["פסח", "חנוכה", "פורים", "שבועות"], 1),
                new Question("באיזה חג חוגגים את מתן תורה?", ["חנוכה", "פסח", "פורים", "שבועות"], 3),
                new Question("מהו החג שבו מגילת אסתר נקראת?", ["פורים", "פסח", "חנוכה", "סוכות"], 0),
                new Question("מהו החג שבו אוכלים אוזני המן?", ["פסח", "פורים", "סוכות", "שבועות"], 1),
                new Question("באיזה חג מציינים את חורבן בית המקדש?", ["תשעה באב", "יום כיפור", "סוכות", "פסח"], 0),
                new Question("מהו החג שבו נוהגים להתחפש?", ["פסח", "פורים", "חנוכה", "סוכות"], 1),
                new Question("באיזה חג קוראים מגילת קהלת?", ["שבועות", "סוכות", "פסח", "פורים"], 1),
                new Question("מהו החג שבו נוהגים לשבת בסוכה?", ["חנוכה", "שבועות", "סוכות", "פסח"], 2),
                new Question("מהו החג שנחגג בסיום השנה החקלאית?", ["פסח", "שבועות", "סוכות", "חנוכה"], 1),
                new Question("מהו החג שבו אוכלים לביבות?", ["חנוכה", "פורים", "פסח", "סוכות"], 0),
                new Question("באיזה חג נוהגים לאכול תפוח בדבש?", ["ראש השנה", "סוכות", "פסח", "חנוכה"], 0),
            ];
    }

    private List<Question> GetIsraelQuestions()
    {
        return
        [
            new Question("מתי הוכרזה מדינת ישראל?", ["1948", "1956", "1967", "1973"], 0),
                new Question("מי היה ראש הממשלה הראשון של ישראל?", ["דוד בן-גוריון", "גולדה מאיר", "יצחק רבין", "מנחם בגין"], 0),
                new Question("באיזו שנה נחתמה הסכם השלום עם מצרים?", ["1979", "1981", "1973", "1982"], 0),
                new Question("איזו עיר היא בירת ישראל?", ["תל אביב", "חיפה", "ירושלים", "באר שבע"], 2),
                new Question("מהו ההר הגבוה ביותר בישראל?", ["הר תבור", "הר הכרמל", "הר החרמון", "הר עמשא"], 2),
                new Question("מי היה הנשיא הראשון של ישראל?", ["חיים ויצמן", "יצחק בן-צבי", "שמעון פרס", "אפרים קציר"], 0),
                new Question("מהי העיר הדרומית ביותר בישראל?", ["באר שבע", "אילת", "דימונה", "מצפה רמון"], 1),
                new Question("באיזו שנה התרחש מבצע אנטבה?", ["1976", "1982", "1973", "1967"], 0),
                new Question("מהי השפה הרשמית בישראל?", ["אנגלית", "ערבית", "עברית", "יידיש"], 2),
                new Question("באיזו עיר נמצא מצודת דוד?", ["ירושלים", "חיפה", "תל אביב", "עכו"], 0),
                new Question("איזה ים נמצא לחופי תל אביב?", ["ים סוף", "הים התיכון", "הים השחור", "ים המלח"], 1),
                new Question("מהו הסמל הלאומי של ישראל?", ["הדקל", "המגן דוד", "המנורה", "הצבי"], 2),
                new Question("איזה אירוע מציינים ביום העצמאות?", ["הקמת המדינה", "הצהרת בלפור", "סיום המנדט הבריטי", "כיבוש ירושלים"], 0),
                new Question("מי היה הרמטכ\"ל במלחמת ששת הימים?", ["דוד אלעזר", "משה דיין", "יגאל ידין", "יצחק רבין"], 3),
                new Question("באיזו שנה נערכה מלחמת יום הכיפורים?", ["1973", "1967", "1982", "1956"], 0),
                new Question("מהי העיר הגדולה ביותר בישראל?", ["חיפה", "תל אביב", "ירושלים", "ראשון לציון"], 2),
                new Question("מהי הכנסת?", ["הבית העליון", "הבית התחתון", "הפרלמנט של ישראל", "מועצת הביטחון"], 2),
                new Question("איזה אירוע מציינים ביום הזיכרון לחללי מערכות ישראל?", ["לזכר הנופלים במלחמות ישראל", "לזכר הנופלים בשואה", "לזכר הנופלים במלחמת העולם הראשונה", "לזכר הנופלים במבצע קדש"], 0),
                new Question("מהי העיר היהודית העתיקה ביותר בארץ ישראל?", ["ירושלים", "חברון", "צפת", "שכם"], 1),
                new Question("מהי הסוכנות היהודית?", ["ארגון צדקה", "ממשלה מקומית", "ארגון עולמי לעלייה יהודית", "בנק לאומי"], 2),
            ];
    }

    private List<Question> GetJerusalemQuestions()
    {
        return
        [
            new Question("באיזו שנה אוחדה ירושלים?", ["1967", "1948", "1956", "1973"], 0),
                new Question("מהו הכותל המערבי?", ["חלק מחומת העיר העתיקה", "קיר תומך של הר הבית", "שער הכניסה לעיר העתיקה", "מבנה ממלכתי"], 1),
                new Question("באיזו שנה הוקמה ירושלים?", ["3000 לפנה\"ס", "2000 לפנה\"ס", "1000 לפנה\"ס", "700 לפנה\"ס"], 0),
                new Question("מהו הר הבית?", ["הר מדרום לעיר", "הר מרכזי בירושלים", "הר במערב העיר", "הר בצפון העיר"], 1),
                new Question("איזה שער נמצא בצפון העיר העתיקה?", ["שער האריות", "שער יפו", "שער שכם", "שער ציון"], 2),
                new Question("מי היה המלך הראשון שבנה את חומת ירושלים?", ["דוד", "שלמה", "חזקיהו", "עוזיהו"], 2),
                new Question("מהי כיפת הסלע?", ["כנסיה", "מסגד", "מבנה דתי על הר הבית", "שער"], 2),
                new Question("מהו השוק המרכזי בירושלים?", ["שוק מחנה יהודה", "שוק הכרמל", "שוק הפשפשים", "שוק עכו"], 0),
                new Question("באיזו שנה נחרב בית המקדש השני?", ["70 לספירה", "100 לספירה", "586 לפנה\"ס", "132 לספירה"], 0),
                new Question("מהו שם הנהר שעובר בירושלים?", ["הירדן", "הירמוך", "קדרון", "הבשן"], 2),
                new Question("איזו עיר נקראת \"עיר דוד\"?", ["חברון", "ירושלים", "בית לחם", "צפת"], 1),
                new Question("מהי עין יעקב?", ["מעיין בירושלים", "שער בעיר העתיקה", "כנסייה", "הר"], 0),
                new Question("מהי המושבה הגרמנית?", ["שכונה בירושלים", "מבצר", "מסגד", "כנסייה"], 0),
                new Question("באיזו שנה הוקמה הכנסת בירושלים?", ["1949", "1966", "1958", "1967"], 2),
                new Question("מהו שם הרכבת הקלה בירושלים?", ["רכבת דוד", "רכבת ירושלים", "רכבת ישראל", "רכבת הקלה"], 3),
                new Question("מהי העיר החדשה שמחוץ לחומות?", ["עיר גנים", "עיר המלך", "ירושלים החדשה", "עיר דוד"], 2),
                new Question("באיזו שנה נערך טקס קבלת ספר התורה בירושלים?", ["1948", "1950", "1949", "1951"], 2),
                new Question("מהו הגן הבוטני?", ["גן ציבורי", "גן חיות", "מוזיאון טבע", "גן עם צמחים מכל העולם"], 3),
                new Question("מהו יד ושם?", ["מוזיאון לשואה", "מרכז דתי", "אוניברסיטה", "כנסייה"], 0),
                new Question("מהו השם הנוסף לירושלים?", ["עיר דוד", "עיר המלך", "ציון", "עיר הבירה"], 2),
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
            MessageBox.Show("אנא בחר תשובה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        lblScore.Text = $"נכון: {correctAnswers} מתוך 10";

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
            MessageBox.Show($"סיימת את המשחק! נכון: {correctAnswers} מתוך {questions.Count}", "סיום", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        StartGame("חגים ומועדים יהודיים");
    }

    private void btnIsrael_Click(object sender, EventArgs e)
    {
        StartGame("ישראל וציונות");
    }

    private void btnJerusalem_Click(object sender, EventArgs e)
    {
        StartGame("ירושלים");
    }

    private void groupBoxAnswers_Enter(object sender, EventArgs e)
    {

    }
}

