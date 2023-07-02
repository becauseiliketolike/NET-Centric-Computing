// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const username = document.querySelector("#username");
const email = document.querySelector("#email");
const password = document.querySelector("#password");
const agree = document.querySelector("#agree");

const Validate = () => {
    if (username.value == "") {
        alert("Username Required");
    } else if (username.value.length < 5) {
        alert("Username must be of length 6 or more");
    }

    const regexEmail = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (email.value == "") {
        alert("Email Required");
    } else if (!email.value.match(regexEmail)) {
        alert("Email not in valid format");
    }

    const regexPassword = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$/;
    if (password.value == "") {
        alert("Password Required");
    } else if (!password.value.match(regexPassword)) {
        alert("Password not in valid format");
    }

    if (!agree.checked) {
        alert("Agree not checked");
    }

}