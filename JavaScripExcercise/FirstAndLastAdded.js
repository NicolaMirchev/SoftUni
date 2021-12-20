

function CalculateFirstAndLast(array) {

    let test = [];
    for (i = 0; i < array.length; i++){
        array[i] = Number(array[i]);
    }

    let result = array.shift() + array.pop();
    return result;

}
    console.log(CalculateFirstAndLast(['20', '30', '40']));
    console.log(CalculateFirstAndLast(['5', '10']));
