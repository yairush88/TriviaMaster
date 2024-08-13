﻿namespace TriviaMaster.Common
{
    public static class QuestionRepository
    {
        public static List<Question> GetRandomQuestions(string topic)
        {
            List<Question> questions;

            switch (topic)
            {
                case "חגים ומועדים יהודיים":
                    questions = GetHolidayQuestions();
                    break;
                case "ישראל וציונות":
                    questions = GetIsraelQuestions();
                    break;
                case "ירושלים":
                    questions = GetJerusalemQuestions();
                    break;
                default:
                    throw new ArgumentException("נושא לא חוקי");
            }

            // Randomly select 10 questions
            return questions.OrderBy(q => Guid.NewGuid()).Take(10).ToList();
        }

        private static List<Question> GetHolidayQuestions()
        {
            return new List<Question>
            {
                new Question("מהו החג שבו מדליקים חנוכייה?", new List<string> { "ראש השנה", "פורים", "חנוכה", "סוכות" }, 2),
                new Question("מהו החג שבו קוראים את ההגדה?", new List<string> { "סוכות", "פסח", "שבועות", "פורים" }, 1),
                new Question("באיזה חג אוכלים מצות?", new List<string> { "פורים", "סוכות", "פסח", "שבועות" }, 2),
                new Question("מהו החג שבו מקיימים מצוות תקיעת שופר?", new List<string> { "פסח", "שבועות", "ראש השנה", "חנוכה" }, 2),
                new Question("איזה חג נמשך שמונה ימים?", new List<string> { "סוכות", "חנוכה", "פסח", "פורים" }, 1),
                new Question("באיזה חג חוגגים את סיום השנה היהודית?", new List<string> { "ראש השנה", "יום כיפור", "סוכות", "שמחת תורה" }, 0),
                new Question("באיזה חג נוהגים להתענות?", new List<string> { "פסח", "יום כיפור", "פורים", "חנוכה" }, 1),
                new Question("באיזה חג נוהגים לבנות סוכה?", new List<string> { "פסח", "סוכות", "שבועות", "חנוכה" }, 1),
                new Question("מהו החג שבו מקיימים מצוות ארבעת המינים?", new List<string> { "סוכות", "פסח", "פורים", "שבועות" }, 0),
                new Question("באיזה חג חוגגים את נס פך השמן?", new List<string> { "פסח", "חנוכה", "פורים", "שבועות" }, 1),
                new Question("באיזה חג חוגגים את מתן תורה?", new List<string> { "חנוכה", "פסח", "פורים", "שבועות" }, 3),
                new Question("מהו החג שבו מגילת אסתר נקראת?", new List<string> { "פורים", "פסח", "חנוכה", "סוכות" }, 0),
                new Question("מהו החג שבו אוכלים אוזני המן?", new List<string> { "פסח", "פורים", "סוכות", "שבועות" }, 1),
                new Question("באיזה חג מציינים את חורבן בית המקדש?", new List<string> { "תשעה באב", "יום כיפור", "סוכות", "פסח" }, 0),
                new Question("מהו החג שבו נוהגים להתחפש?", new List<string> { "פסח", "פורים", "חנוכה", "סוכות" }, 1),
                new Question("באיזה חג קוראים מגילת קהלת?", new List<string> { "שבועות", "סוכות", "פסח", "פורים" }, 1),
                new Question("מהו החג שבו נוהגים לשבת בסוכה?", new List<string> { "חנוכה", "שבועות", "סוכות", "פסח" }, 2),
                new Question("מהו החג שנחגג בסיום השנה החקלאית?", new List<string> { "פסח", "שבועות", "סוכות", "חנוכה" }, 1),
                new Question("מהו החג שבו אוכלים לביבות?", new List<string> { "חנוכה", "פורים", "פסח", "סוכות" }, 0),
                new Question("באיזה חג נוהגים לאכול תפוח בדבש?", new List<string> { "ראש השנה", "סוכות", "פסח", "חנוכה" }, 0),
            };
        }

        private static List<Question> GetIsraelQuestions()
        {
            return new List<Question>
            {
                new Question("מתי הוכרזה מדינת ישראל?", new List<string> { "1948", "1956", "1967", "1973" }, 0),
                new Question("מי היה ראש הממשלה הראשון של ישראל?", new List<string> { "דוד בן-גוריון", "גולדה מאיר", "יצחק רבין", "מנחם בגין" }, 0),
                new Question("באיזו שנה נחתמה הסכם השלום עם מצרים?", new List<string> { "1979", "1981", "1973", "1982" }, 0),
                new Question("איזו עיר היא בירת ישראל?", new List<string> { "תל אביב", "חיפה", "ירושלים", "באר שבע" }, 2),
                new Question("מהו ההר הגבוה ביותר בישראל?", new List<string> { "הר תבור", "הר הכרמל", "הר החרמון", "הר עמשא" }, 2),
                new Question("מי היה הנשיא הראשון של ישראל?", new List<string> { "חיים ויצמן", "יצחק בן-צבי", "שמעון פרס", "אפרים קציר" }, 0),
                new Question("מהי העיר הדרומית ביותר בישראל?", new List<string> { "באר שבע", "אילת", "דימונה", "מצפה רמון" }, 1),
                new Question("באיזו שנה התרחש מבצע אנטבה?", new List<string> { "1976", "1982", "1973", "1967" }, 0),
                new Question("מהי השפה הרשמית בישראל?", new List<string> { "אנגלית", "ערבית", "עברית", "יידיש" }, 2),
                new Question("באיזו עיר נמצא מצודת דוד?", new List<string> { "ירושלים", "חיפה", "תל אביב", "עכו" }, 0),
                new Question("איזה ים נמצא לחופי תל אביב?", new List<string> { "ים סוף", "הים התיכון", "הים השחור", "ים המלח" }, 1),
                new Question("מהו הסמל הלאומי של ישראל?", new List<string> { "הדקל", "המגן דוד", "המנורה", "הצבי" }, 2),
                new Question("איזה אירוע מציינים ביום העצמאות?", new List<string> { "הקמת המדינה", "הצהרת בלפור", "סיום המנדט הבריטי", "כיבוש ירושלים" }, 0),
                new Question("מי היה הרמטכ\"ל במלחמת ששת הימים?", new List<string> { "דוד אלעזר", "משה דיין", "יגאל ידין", "יצחק רבין" }, 3),
                new Question("באיזו שנה נערכה מלחמת יום הכיפורים?", new List<string> { "1973", "1967", "1982", "1956" }, 0),
                new Question("מהי העיר הגדולה ביותר בישראל?", new List<string> { "חיפה", "תל אביב", "ירושלים", "ראשון לציון" }, 2),
                new Question("מהי הכנסת?", new List<string> { "הבית העליון", "הבית התחתון", "הפרלמנט של ישראל", "מועצת הביטחון" }, 2),
                new Question("איזה אירוע מציינים ביום הזיכרון לחללי מערכות ישראל?", new List<string> { "לזכר הנופלים במלחמות ישראל", "לזכר הנופלים בשואה", "לזכר הנופלים במלחמת העולם הראשונה", "לזכר הנופלים במבצע קדש" }, 0),
                new Question("מהי העיר היהודית העתיקה ביותר בארץ ישראל?", new List<string> { "ירושלים", "חברון", "צפת", "שכם" }, 1),
                new Question("מהי הסוכנות היהודית?", new List<string> { "ארגון צדקה", "ממשלה מקומית", "ארגון עולמי לעלייה יהודית", "בנק לאומי" }, 2),
            };
        }

        private static List<Question> GetJerusalemQuestions()
        {
            return new List<Question>
            {
                new Question("באיזו שנה אוחדה ירושלים?", new List<string> { "1967", "1948", "1956", "1973" }, 0),
                new Question("מהו הכותל המערבי?", new List<string> { "חלק מחומת העיר העתיקה", "קיר תומך של הר הבית", "שער הכניסה לעיר העתיקה", "מבנה ממלכתי" }, 1),
                new Question("באיזו שנה הוקמה ירושלים?", new List<string> { "3000 לפנה\"ס", "2000 לפנה\"ס", "1000 לפנה\"ס", "700 לפנה\"ס" }, 0),
                new Question("מהו הר הבית?", new List<string> { "הר מדרום לעיר", "הר מרכזי בירושלים", "הר במערב העיר", "הר בצפון העיר" }, 1),
                new Question("איזה שער נמצא בצפון העיר העתיקה?", new List<string> { "שער האריות", "שער יפו", "שער שכם", "שער ציון" }, 2),
                new Question("מי היה המלך הראשון שבנה את חומת ירושלים?", new List<string> { "דוד", "שלמה", "חזקיהו", "עוזיהו" }, 2),
                new Question("מהי כיפת הסלע?", new List<string> { "כנסיה", "מסגד", "מבנה דתי על הר הבית", "שער" }, 2),
                new Question("מהו השוק המרכזי בירושלים?", new List<string> { "שוק מחנה יהודה", "שוק הכרמל", "שוק הפשפשים", "שוק עכו" }, 0),
                new Question("באיזו שנה נחרב בית המקדש השני?", new List<string> { "70 לספירה", "100 לספירה", "586 לפנה\"ס", "132 לספירה" }, 0),
                new Question("מהו שם הנהר שעובר בירושלים?", new List<string> { "הירדן", "הירמוך", "קדרון", "הבשן" }, 2),
                new Question("איזו עיר נקראת \"עיר דוד\"?", new List<string> { "חברון", "ירושלים", "בית לחם", "צפת" }, 1),
                new Question("מהי עין יעקב?", new List<string> { "מעיין בירושלים", "שער בעיר העתיקה", "כנסייה", "הר" }, 0),
                new Question("מהי המושבה הגרמנית?", new List<string> { "שכונה בירושלים", "מבצר", "מסגד", "כנסייה" }, 0),
                new Question("באיזו שנה הוקמה הכנסת בירושלים?", new List<string> { "1949", "1966", "1958", "1967" }, 2),
                new Question("מהו שם הרכבת הקלה בירושלים?", new List<string> { "רכבת דוד", "רכבת ירושלים", "רכבת ישראל", "רכבת הקלה" }, 3),
                new Question("מהי העיר החדשה שמחוץ לחומות?", new List<string> { "עיר גנים", "עיר המלך", "ירושלים החדשה", "עיר דוד" }, 2),
                new Question("באיזו שנה נערך טקס קבלת ספר התורה בירושלים?", new List<string> { "1948", "1950", "1949", "1951" }, 2),
                new Question("מהו הגן הבוטני?", new List<string> { "גן ציבורי", "גן חיות", "מוזיאון טבע", "גן עם צמחים מכל העולם" }, 3),
                new Question("מהו יד ושם?", new List<string> { "מוזיאון לשואה", "מרכז דתי", "אוניברסיטה", "כנסייה" }, 0),
                new Question("מהו השם הנוסף לירושלים?", new List<string> { "עיר דוד", "עיר המלך", "ציון", "עיר הבירה" }, 2),
            };
        }
    }
}
