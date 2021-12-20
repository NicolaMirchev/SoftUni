

function GetSequence(length, numbersToSum) {
    let resultArray = [1, 1];

    for (i = 0; i < length - 2; i++) {

        let number = 0;
        for (j = 0; j < numbersToSum; j++) {
            if (resultArray[resultArray.length - 1 - j] == undefined) {
                break;
            }
            number += resultArray[resultArray.length - 1 - j];
        }
        resultArray.push(number);
    }
    return resultArray;
}

console.log(GetSequence(8, 2));