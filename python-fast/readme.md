# Fagmiles app

Reference app written in Python, using FastAPI.

This has been set up with Poetry as build tool, which can be used to generate python packages for distribution, as
well as dependency management and virtual environment manager.

Poetry will manage a virtual environment for you, in case you haven't already create one, ensuring that you
don't fill up with python packages you don't need.

## QAD

1. Install dependencies with `pip install -r requirements.txt`
2. Start the app with `uvicorn main:app --reload`
3. Test the app with `http://localhost:8000/?q=What%20is%20my%20name%3F`
4. Browse swagger/redoc with `http://localhost:8000/docs` or `http://localhost:8000/redoc`

But, seriously, use a virtual environment!

## Recommended setup

### Using Poetry

Install Poetry from https://python-poetry.org

With Mac using brew: 

```bash
brew install poetry
```

### Install dependencies

```bash
poetry install
```

```bash
poetry shell
uvicorn main:app --reload

# or

poetry run uvicorn main:app --reload
```

## How to run without poetry

Create a virtual environment using (make sure you're using python 3!)

```bash
python -m venv .venv
```

Then activate the virtual environment:
```bash
source ./.venv/bin/activate
```

You can deactivate the virtual environment by typing `deactivate`

Install the dependencies (from inside the virtual environment):

```bash
pip install -r requirements.txt
```

Run the app with the same command as for inside the poetry shell:

```bash
uvicorn main:app --reload
```

