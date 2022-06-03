// 1.
console.log('Q1');
let salaries = {John: 100,Ann: 160,Pete: 130};
let sum = 0;
for(let s in salaries){
    sum += salaries[s];
}
console.log(`Total salaries are ${sum} `);

//2.
console.log('\nQ2');
let menu = {width: 200,height: 300,title: "My menu"};
console.log("Before function: ");
console.log(menu);

function multiplyNumeric(menu){
    for(let elem in menu){
        if(!isNaN(menu[elem])){
            menu[elem] *= 2;
        }
    }
}

multiplyNumeric(menu);
console.log("After function: ");
console.log(menu);

//3.
console.log('\nQ3');
function checkEmailId(str){
    let re = /\S+@\S+\.\S+/;
 
    if (re.test(str)){
        return true;
    }
    else{
        return false;
    }
}

let email="123@gmail.com";
console.log(checkEmailId(email));

let email1="@.com";
console.log(checkEmailId(email1));
//4.
console.log('\nQ4');
function truncate(str, maxlength){
    if(str.length <= maxlength){
        return str;
    }
    else{
        return str.slice(0, maxlength-1) + '...'
    }
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));


//5.
console.log('\nQ5');

let array = ['James','Brennie'];
console.log(...array);
array.push("Robert");
console.log(...array);

function replaceMiddle(arr, name){
    let size = arr.length;
    if (size % 2 == 1){
        arr[size/2|0] =  name;
    }
}

replaceMiddle(array, "Calvin");
console.log(...array);

array.shift();
console.log(...array);

array.unshift("Rose","Regal");
console.log(array.join(', '));