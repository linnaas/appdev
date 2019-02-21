// Defines variables from .cshtml

var modal = document.getElementsByClassName('modal');
var btn = document.getElementsByClassName('btn');
var span = document.getElementsByClassName('close');


// Name-change

btn[0].onclick = function () {
    modal[0].style.display = "block";
}

span[0].onclick = function () {
    modal[0].style.display = "none";
}




// Username-change 

btn[1].onclick = function () {
    modal[1].style.display = "block";
}

span[1].onclick = function () {
    modal[1].style.display = "none";
}



// Password-change

btn[2].onclick = function () {
    modal[2].style.display = "block";
}

span[2].onclick = function () {
    modal[2].style.display = "none";
}



// Email-change

btn[3].onclick = function () {
    modal[3].style.display = "block";
}

span[3].onclick = function () {
    modal[3].style.display = "none";
}


// Phone-change

btn[4].onclick = function () {
    modal[4].style.display = "block";
}

span[4].onclick = function () {
    modal[4].style.display = "none";
}



// Closes the selected modal


window.onclick = function (event) {
    if (event.target == modal[0]) {
        modal[0].style.display = "none";
    }
}