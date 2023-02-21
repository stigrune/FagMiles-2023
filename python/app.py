from flask import Flask, request

app = Flask(__name__)

@app.route('/')

def index():
    question = request.args.get('question')
    answer = "test"
    return f'Server question: "{question}", my answer: "{answer}"'

if __name__ == '__main__':
    app.run(host="localhost", port=1337)
