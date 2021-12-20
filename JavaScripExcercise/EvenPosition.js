 /// <param name="array" type="Array"></param>
function EvenPositionArrayElements(array)
{
    let result = [];
    for(let i = 0; i < array.length; i++) {
        if (i % 2 == 0) {
            result.push(array[i]);
        }
    }
    return result.join(' ');
}

console.log(EvenPositionArrayElements(['1', '2', '3', '4', '5']))