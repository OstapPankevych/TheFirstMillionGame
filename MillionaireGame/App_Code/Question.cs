using System;

namespace MillionaireGame.App_Code
{
    public class Question
    {
        public const byte FALSE_ANSWER_COUNT = 3;

        private readonly string _question = String.Empty;
        private readonly string[] _answersFalse = new string[FALSE_ANSWER_COUNT];
        private readonly string _answerTrue = String.Empty;

        public string QuestionText
        {
            get { return _question; }
        }

        public string[] AnswersFalse
        {
            get { return _answersFalse; }
            private set
            {
                for (byte i = 0; i < value.Length; i++)
                {
                    _answersFalse[i] = value[i];
                }
            }
        }

        public string AnswerTrue
        {
            get { return _answerTrue; }
        }

        public Question(string question, string trueAnswer, string[] falseAnswers)
        {
            _question = question;
            _answerTrue = trueAnswer;
            _answersFalse = falseAnswers;
        }
    }
}