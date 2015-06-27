using System.Collections.Generic;
using System.Xml;

namespace MillionaireGame.App_Code
{
    public class XmlQuestionRepository
    {
        #region Fields

        private readonly string _fileName;

        #endregion


        #region Constructors

        public XmlQuestionRepository(string fileName)
        {
            _fileName = fileName;
        }

        #endregion


        #region IQuestionRepository

        public IEnumerable<Question> GetQuestions()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(_fileName);
            foreach (XmlNode x in xml.DocumentElement)
            {
                string[] answersFalse = new string[Question.FALSE_ANSWER_COUNT];
                byte currentFalseAnswer = 0;
                foreach (XmlNode y in x["falseAnswer"])
                {
                    answersFalse[currentFalseAnswer++] = y.InnerText;
                }

                yield return new Question(x["textQuestion"].InnerText, x["trueAnswer"].InnerText, answersFalse);
            }
        }

        #endregion
    }
}