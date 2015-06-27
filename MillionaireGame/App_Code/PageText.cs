using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MillionaireGame.App_Code
{
    public class PageText
    {
        private const byte _ANSWER_COUNT = 4;
        private readonly Label[] _lbls = new Label[_ANSWER_COUNT];
        private readonly ImageButton[] _imgs = new ImageButton[_ANSWER_COUNT];
        private readonly Label _lblQuestion;

        public PageText(Label lblQuestion,
            Label lblA, ImageButton imgA,
            Label lblB, ImageButton imgB,
            Label lblC, ImageButton imgC,
            Label lblD, ImageButton imgD)
        {
            _lblQuestion = lblQuestion;
            _lbls[0] = lblA;
            _imgs[0] = imgA;
            _lbls[1] = lblB;
            _imgs[1] = imgB;
            _lbls[2] = lblC;
            _imgs[2] = imgC;
            _lbls[3] = lblD;
            _imgs[3] = imgD;
        }



        public void SetTextFromQuestion(Question question)
        {
            _lblQuestion.Text = question.QuestionText;

            List<int> list = new List<int>();

            Random rnd = new Random();

            while (list.Count < 4)
            {
                byte number = (byte)rnd.Next(4);
                if (!list.Contains(number))
                {
                    list.Add(number);
                }
            }

            _lbls[list[0]].Text = question.AnswerTrue;
            for (int i = 1; i < _ANSWER_COUNT; i++)
            {
                _lbls[list[i]].Text = question.AnswersFalse[i - 1];
            }
        }
    }
}