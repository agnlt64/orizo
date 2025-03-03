from flask import Flask

from .views import views

def create_app() -> Flask:
    app = Flask(__name__)
    app.register_blueprint(views)

    return app