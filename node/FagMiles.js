const express = require('express')
const app = express()
const port = 1337

app.get('/', (req, res) => {
    var question =  req.query.q; 
    var answer = createAnswer(question, req, res);
    console.log("Server question: \"" + question + "\" My answer:\"" + answer + "\"");
    res.end(answer);
})

app.listen(port, () => {
  console.log(`FagMiles app listening at http://localhost:${port}`)
})

// This is where you would have to handle the questions from the 
// server and return the correct answer.
var createAnswer = (question, req, res) => {
    if(question.includes('what is your name')){
        return "test";  
    }
}