class Person{
    constructor(firstName, lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }

    get fullName() {return `${this.firstName} ${this.lastName}`};
    set fullName(name) {

        const splitedNames = name.split(' ');
        
        if (splitedNames.length == 2){
            this.firstName = splitedNames[0];
            this.lastName = splitedNames[1];

        }

    }

}

const person1 = new Person('Ivan', 'Petrov');
console.log(person1.fullName);
person1.firstName = 'Anton';
console.log(person1.fullName);
person1.fullName = 'Anton antonov';
console.log(person1.lastName);