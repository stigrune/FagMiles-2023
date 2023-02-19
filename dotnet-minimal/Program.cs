var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (string q) =>
{
    var answer = CreateAnswer(q);
    Console.WriteLine($"Server question: '{q}' My answer: '{answer}'");
    return answer;
});

app.Run("http://+:1337");

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