from flask import Blueprint, render_template

views = Blueprint('views', __name__)

@views.route('/')
def index():
    return render_template('index.html')

@views.route('/route', methods=['POST'])
def route():
    return "<h1>It works</h1>"