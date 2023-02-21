from typing import Union
from fastapi import FastAPI

app = FastAPI()


def create_answer(question: str):
    if "what is your name" in question.casefold():
        return "test"
    else:
        return "I don't know!"

@app.get("/")
def read_root(q:Union[str, None] = None):
    question = q
    answer = create_answer(question)
    return { "question": question, "answer": answer}
