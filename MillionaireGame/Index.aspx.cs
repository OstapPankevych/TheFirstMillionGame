using System;
using System.Web.UI;
using MillionaireGame.App_Code;
using MillionaireGame.Controls.Player;

namespace MillionaireGame
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["CurrentPlayerStatus"] = (byte)1;
                Session["HelpCall"] = true;
                ProgressBar.SetPlayerStatus(_currentPlayerStatus);
            }

            imageButtonA.Click += ClickA;
            imageButtonB.Click += ClickB;
            imageButtonC.Click += ClickC;
            imageButtonD.Click += ClickD;

            help_call.Click += HelpCallClick;
            help_50_50.Click += Help_50_50Click;
            help_room.Click += Help_RoomClick;
        }

        private void HelpCallClick(object sender, ImageClickEventArgs e)
        {
            if ((bool) Session["HelpCall"])
            {
                string clientScript = "helpCall(){allert(\"bla\")};";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "MyClientScript", clientScript);
            }
        }

        private void Help_50_50Click(object sender, ImageClickEventArgs e)
        {
            
        }

        private void Help_RoomClick(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            GetQuestionFromFile();
        }

        private byte _currentPlayerStatus
        {
            get { return (byte)Session["CurrentPlayerStatus"]; }
            set { Session["CurrentPlayerStatus"] = value; }
        }

        private Question GetCurrentQuestion()
        {
            XmlQuestionRepository xmlQuestionRepository = new XmlQuestionRepository(Server.MapPath("~/App_Data/Questions/questions.xml"));
            byte currentQuestion = 0;
            foreach (Question x in xmlQuestionRepository.GetQuestions())
            {
                currentQuestion++;
                if (currentQuestion == _currentPlayerStatus)
                {
                    return x;
                }
            }

            return null;
        }

        public void GetQuestionFromFile()
        {
            PageText pageText = new PageText(lblQuestion,
                        lblAnswerA, imageButtonA,
                        lblAnswerB, imageButtonB,
                        lblAnswerC, imageButtonC,
                        lblAnswerD, imageButtonD);

            pageText.SetTextFromQuestion(GetCurrentQuestion());
        }

        private void ChackTrueAnswer(System.Web.UI.WebControls.Label lblAnswer)
        {
            if (GetCurrentQuestion().AnswerTrue == lblAnswer.Text)
            {
                _currentPlayerStatus += 1;
            }
            else
            {
                Session["money"] = ProgressBar.GetMoneyCount(_currentPlayerStatus);
                Response.Redirect("~/GameResult.aspx");
            }
            ProgressBar.SetPlayerStatus(_currentPlayerStatus);
        }

        private void ClickA(object sender, ImageClickEventArgs e)
        {
            ChackTrueAnswer(lblAnswerA);
        }

        private void ClickB(object sender, ImageClickEventArgs e)
        {
            ChackTrueAnswer(lblAnswerB);
        }

        private void ClickC(object sender, ImageClickEventArgs e)
        {
            ChackTrueAnswer(lblAnswerC);
        }

        private void ClickD(object sender, ImageClickEventArgs e)
        {
            ChackTrueAnswer(lblAnswerD);
        }
    }
    
}