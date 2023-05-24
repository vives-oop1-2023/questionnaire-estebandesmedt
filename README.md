# Questionnaire Application
Welcome to this application made by <b> Esteban Desmedt </b>. This application was made as part of a school project. The program was made entirely in C# and developed for the subject Object Oriënted Programming, given at Vives (Xaveriaenenstraat 10, 8200 Brugge).
<h3> UML Diagram </h3>
<hr></hr>
<img src="./Images/uml.jpg" alt="UML">


<div class="toc">

## Table of Contents

- [User guide](#section-1)
- [Update schedule](#section-2)
- [Future changes](#section-3)
- [Licensing](#section-4)

</div>

## User guide
Well how do you use the app? You will be welcomed to the next screen, here you can fill in your username. The username can contain numbers and letters and can't exceed the maximum length of 10 characters. Whenever you press the "Submit" button you will get a short welcome message. Whenever you press the "Start Playing" button you will be directed to the next page containing the game itself. Pressing the "Submit" button however isn't necessary to proceed with your username, you will only miss out on the welcome message.
<img src="./Images/Login.jpg" alt="Login">

After proceeding to the main window you will find next graphical layout. At the bottom you find your username accompanied by a question tracker to it's right. This will tell which question your on. To proceed to the first question you need to press the "Next" button.
<img src="./Images/Main1.jpg" alt="Main1">

When you press the button the request will be send for the question and the answers, more information about this follows later in the readme. Whenever the request is done you will get the question on your screen, followed by four possible answers. 
<img src="./Images/Main2.jpg" alt="Main2">

Now it's up to you to choose an option. If you guess the right answer, it will turn green. However if you fail to get the correct answer the background will turn red. Meanwhile the correct answer will be shown with a green background. Your score (at the right) will update after answering. Finally press next to see the new question. I chose to include 12 questions for now. Whenever you press next after your final answer you will go to the scoreboard.
<img src="./Images/Main3.jpg" alt="Main3">

On this page you will see a few of your stats from the previous game. First you will find the amount of answered questions. I'm trying to implement a system so the player chooses the amount of questions before the game. In the middle you will find the amount of correctly answered questions followed by the number of incorrect ones. Finally you will find the time you spend in the game. This timer starts when you start the game and ends when you press next to go to the scoreboard.
<img src="./Images/Score.jpg" alt="Scoreboard">

## Update schedule
<ul>
    <li> Creating the Question and Answer class in the Questionnaire library</li>
    Answer class:
    <img src="./Images/AnswerClass.jpg" alt="AnswerClass">
    Question class:
    <img src="./Images/QuestionClass1.jpg" alt="QuestionClass1">
    <img src="./Images/QuestionClass2.jpg" alt="QuestionClass2">
    <img src="./Images/QuestionClass3.jpg" alt="QuestionClass3">
    <br></br>
    <li> Designing the WPF application layout</li>
    <li> Adding functionality:</li>
    <ul>
    <li>"Next" button - Showing the next question</li>
    <li>"Scoredisplay" - Displaying the question you're on</li>
    <li>"Answer" Buttons - Displaying the answers</li>
    </ul>
    <li> Coding the code behind each button and the logics connecting the triviaAPI, containing the questions, with the Question class and application</li>
    <li> Adding a Login form</li>
    <li> Adding a scoreboard</li>
    <li> Adding two new methods</li>
    <img src="./Images/NewMethod.jpg" alt="newmethod">
</ul>

## Future changes
<ul>
    <li>Scoreboard implementation</li>
    <li>Checking for correct question</li>
    <li>Button turns green when correct, red when wrong</li>
    <li>You go to the next question when answering, this change would make it possible to change the next button to a "Start" button</li>
    <li>Disable the hovering of a button before you press the button to get the first question</li>
    <li>"Start" button in the middle till you press start, then the questions appear and the button disappears but Adding a skip button on the spot if the "Next" button right now.</li>
    <li></li>
    <li></li>
    <li></li>
</ul>
 
 ## Licensing
<p>Made by Esteban Desmedt, student @ Vives Brugge 8200, Xaveriaenenstraat 10</p>
<p>for the Subject Object Oriented Programming (first year, phase 2) 2023</p>


