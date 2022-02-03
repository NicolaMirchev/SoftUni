function Sum(array, firstIndex, secondIndex){

    if(!Array.isArray(array)) return NaN;

    if (firstIndex < 0) firstIndex = 0;
    if (secondIndex >= array.length) secondIndex = array.length - 1;

    let sum = 0;
    for (let i = firstIndex; i <= secondIndex; i++){
        sum += Number(array[i]);
    }
    return sum;
}

console.log(Add(4)(5)(1));