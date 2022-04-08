var str = document.getElementById("inp").value;

//1
function reverseString(str) {
    let reverseStr = "";
    for (let i = str.length - 1; i >= 0; i--) {
        reverseStr += str[i];
    }
    document.getElementById("reversed").innerHTML = "Reverse: " + reverseStr;
    return reverseStr;
    console.log(reverseStr);
}

//2
function checkPalindrome(str) {
    let str2 = reverseString(str);
    if (str == str2) {
        console.log("Palindrome");
        return true;
    }
    else {
        console.log("NOT a palindrome");
        return false;
    }
}

function checkPal2(str) {
    for (let i = 0; i < str.length / 2; i++) {
        if (str[i] != str[str.length - i - 1]) {
            return false;
        }
        else {
            return true;
        }
    }
}

//4
function multiply(a, b) { //as given works fine as long as a and b are numbers
    return a * b;
}

//5
function isLetter(char) { 
    return (/[a-zA-Z]/).test(char); //if char matches a letter, test will return true
}                                   //Works only for english letters

                            // works for last character
function addNumber(str) {   //Normaly, should have a function checking recursively every character from last to first
    var lastChar = str[str.length - 1]; // untill it finds a letter, so that we can change the last string of numbers, 
                                        // ex 29 tp 30, or even if the whole string consists of number characters
    if (isLetter(lastChar)) {   
        str += "1";
        console.log(str);
    }
    else {
        let num = str.substring(str.length - 1, str.length);    //store number part
        str = str.substring(0, str.length - 1);                 // remove the number part
        num++;
        str += num;
        console.log(str);
    }
}

//3
function addToList() {
    let name = document.getElementById("txtName");
    let surname = document.getElementById("txtSurname");
    let age = document.getElementById("txtAge");
    
    let gender = document.querySelector('input[name"gender"]:checked').value;
}