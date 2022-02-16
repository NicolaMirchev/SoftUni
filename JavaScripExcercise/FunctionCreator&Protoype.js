class Person{
    constructor(name, email){
        this.name = name;
        this.email = email;
    }
}

function Person2(name, age){
    this.name = name;
    this.age = age;
}


 Person2.prototype.represent = function () {
     return `Hello, my name is ${this.name} and i am ${this.age} years old!`;
 }

let person = new Person2('Ivan', 22);
console.log(person.name);
console.log(person.represent());