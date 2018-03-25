var reset = document.getElementById("reset");
var answer = document.getElementById("userAnswer");
var enter = document.getElementById("enter");
var level = parseInt(document.getElementById('level').value, 10);
var output = document.getElementById("output");
var leftnum = document.getElementById("num1");
var rightnum = document.getElementById("num2");
var operator = document.getElementById("sign");
var submit = document.getElementById("submit");
var reset = document.getElementById("reset");
var userAnswer = document.getElementById("userAnswer");
var mathSigns = document.getElementsByName("operator");
var totalDiv = document.getElementById("total");
var numRightDiv = document.getElementById("numRight");
var solution, runningTotal = 0, tally = 0;
var correctAns;
var userAns;
var counter = document.getElementById("questionNum").value;
var correct = false;
var resultArray1 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var resultArray2 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var answerArray = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var yourAnswerArray = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var resultString = " ";
var num1, num2 = 0;




if (document.getElementById("submit").disabled == false) {
    answer.addEventListener("keypress", function (event) {

        if (event.keyCode == 13)
            submit.click();
     });
}


document.getElementById("popup1close").onkeydown = function (e) {
    if (e.keyCode == 13) {
        
    }
};

submit.addEventListener("click", solve, false);
reset.addEventListener("click", newEquation, false);
document.getElementsByTagName("fieldset")[0].addEventListener("click", init, false);





function init() {
    var c = document.getElementById("space").innerHTML;
    counter = c;
    if (counter < 10) {
        for (var i = 0; i < mathSigns.length; i++) {
            if (mathSigns[i].checked) {
                chosenSign = mathSigns[i];
            }
            operator.textContent = chosenSign.nextElementSibling.textContent;


            do {
                if (level == 3) {
                    num1 = Math.ceil(Math.random() * 100);
                    num2 = Math.ceil(Math.random() * 100);

                    if (num1 < 10) { num1 = 0; }
                    if (operator.textContent == '*') {
                        if (num1 > 30) { num1 = 0; } if (num2 > 30) { num1 = 0; }
                    }
                }
                else if (level == 2) {
                    num1 = Math.ceil(Math.random() * 60);
                    num2 = Math.ceil(Math.random() * 60);

                    if (num1 < 10) { num1 = 0; }
                    if (operator.textContent == '*') {
                        if (num1 > 20) { num1 = 0; } if (num2 > 20) { num1 = 0; }
                    }
                } else if (level == 1) {
                    num1 = Math.ceil(Math.random() * 30);
                    num2 = Math.ceil(Math.random() * 30);

                    if (operator.textContent == '*') {
                        if (num1 > 10) { num1 = 0; } if (num2 > 10) { num1 = 0; }
                    }
                }
                if (operator.textContent == '/') {

                    if (num1 % num2 != 0) { num1 = 0; }
                }

                if (num2 == 1) { num1 = 0; }
                if (num1 == num2) { num1 = 0; }
                if (num1 < num2) { num1 = 0; }

            } while (num1 == 0);

            document.getElementById("num1").innerHTML = num1;
            document.getElementById("num2").innerHTML = num2;


            resultArray1[counter - 1] = num1;
            resultArray2[counter - 1] = num2;
            document.getElementById("count").innerHTML = "Question " + counter + " of 10";
            document.getElementById("questionNum").value = counter;

        }
        $(document).ready(function () {
            $(".popup-container").hide();



            $("#popup1close").click(function () {
                $("#popup1").fadeOut();
            });
        });
      
        correctAns = num1 + num2;
        
        leftnum.value = num1;
        rightnum.value = num2;


        userAnswer.textContent = "";

        userAnswer.focus();

        if (submit.hasAttribute("disabled")) {
            submit.removeAttribute("disabled");
            submit.style.color = "white";
            submit.textContent = "Solve";
            userAnswer.value = "";
            userAnswer.style.backgroundColor = "#9C8AA5";
            userAnswer.style.color = "#0489B1";
            reset.setAttribute("disabled");
        }
        reset.setAttribute("disabled", "disabled");
    } 
    return numbers = [num1, num2, chosenSign.id];
}

function newEquation() {
   
        if (!submit.hasAttribute("disabled")) {
            solve();
        }
        submit.textContent = "Solve";
        submit.style.color = "white";
        tally++;
        userAnswer.style.backgroundColor = "white";
        userAnswer.style.color = "#0489B1";
        userAnswer.value = "";
        userAnswer.focus();
        submit.removeAttribute("disabled");
        init();
    
}

function increaseProgressWidth() {
   
        document.getElementById("number1").value = num1;
        document.getElementById("number2").value = num2;
        document.getElementById("correct").value = correctAns;
        document.getElementById("user").value = userAnswer.value;
    
    yourAnswerArray[counter] = userAnswer.value;
    if (counter == 10) document.body.innerHTML += " ";
    if (counter < 10) { counter += 1; }
    if (numRightDiv.style.width != "0px") {
        var currentWidth = Number(numRightDiv.style.width.slice(0, 2));
        currentWidth += 10;
        numRightDiv.style.width = currentWidth + "%";
           
        

    } else {
        numRightDiv.style.width = "10%";
    }
    
}

// Display answer on page
function solve() {
    switch (operator.textContent) {
        case '+':
            correctAns = numbers[0] + numbers[1];
            break;
        case '-':
            correctAns = numbers[0] - numbers[1];
            break;
        case '*':
            correctAns = numbers[0] * numbers[1];
            break;
        case '/':
            correctAns = numbers[0] / numbers[1];
            break;
            //document.getElementById("enter").click();
    }

    yourAnswerArray[counter - 1] = userAnswer.value;
    if (userAnswer.value == correctAns) {
        
        //userAnswer.style.backgroundColor = "white";
        userAnswer.style.color = "#0489B1";
        this.textContent = "Correct";
        this.style.color = "rebeccapurple";
        runningTotal++;
        correct = true;
        $("#popup1").fadeIn();
        document.getElementById("popuptext").innerHTML = "Your answer is correct";
        reset.removeAttribute("disabled");
       if (counter > 9) {
           reset.setAttribute("disabled");
       var n = 0;
            for (var i = 0; i < 10; i++) {
                answerArray[i] = resultArray1[i] + resultArray2[i];
                n++;
                intString1 += answerArray[i] + ',';
                intString2 += resultArray1[i] + ',';
                intString3 += resultArray2[i] + ',';
                intString4 += yourAnswerArray[i] + ',';
                resultString += n + ": " + resultArray1[i] + " + " + resultArray2[i] + " = " + answerArray[i];
                resultString += "   Your answer: " + yourAnswerArray[i];

                if (answerArray[i] == yourAnswerArray[i]) {
                    resultString += "  Correct Answer" + "<br />";
                }
                else {
                    resultString += "  Incorrect Answer" + "<br />";
                }
                
            } alert(resultString);

        document.getElementById("result").innerHTML = resultString;
           
       
        
        }

    } else {
        userAnswer.style.backgroundColor = "crimson";
        userAnswer.style.color = "white";
      
        this.textContent = "Wrong";
        this.style.color = "crimson";
        correct = false;
        $("#popup1").fadeIn(); 
        document.getElementById("popuptext").innerHTML = "Your answer is incorrect. <br />The correct answer is: " + correctAns;

        reset.removeAttribute("disabled");
    }
    increaseProgressWidth();
    submit.setAttribute("disabled", "disabled");
   
   
}
init();


function get() {
    var get = document.getElementById("get");
    get.click();
}