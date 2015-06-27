using System.Collections.Generic;


namespace MillionaireGame.App_Code
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions();
    }
}