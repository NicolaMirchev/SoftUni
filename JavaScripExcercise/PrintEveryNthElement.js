 /// <param name="array" type="Array"></param>
function PrintNthElement(array, jumpNumber)
{
    let resultArray = [];

    for(i =0; i < array.length; i += jumpNumber){
        resultArray.push(array[i]);
    }
    return resultArray;
}

console.log(PrintNthElement(['1', '2', '3', '4', '5'], 2))