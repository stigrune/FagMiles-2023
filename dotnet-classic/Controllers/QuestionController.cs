using Microsoft.AspNetCore.Mvc;

namespace FagMiles.Controllers
{
    [ApiController]
    [Route("/")]
    public class QuestionController : ControllerBase
    {
        [HttpGet]
        public string Get(string q)
        {
            var answer = CreateAnswer(q);
            Console.WriteLine($"Server question: '{q}' My answer: '{answer}'");
            return answer;
        }

        // This is where you would have to handle the questions from the 
        // server and return the correct answer.
        string CreateAnswer(string question)
        {
            if (question.Contains("what is your name"))
            {
                return "test";
            }
            return string.Empty;
        }

    }
}