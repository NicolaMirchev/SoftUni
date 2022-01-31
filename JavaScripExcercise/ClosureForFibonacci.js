function GetFibonator(){
    let currentFibonacciNum = 1;
    let previousFibonacciNum = 0;
    return function () {
        const newNum = currentFibonacciNum += previousFibonacciNum;        

        previousFibonacciNum = currentFibonacciNum;
        currentFibonacciNum = newNum;
        return currentFibonacciNum;
    }


}


let fib1 = GetFibonator();
console.log(fib1());
console.log(fib1());
console.log(fib1());
console.log(fib1());
console.log(fib1());
