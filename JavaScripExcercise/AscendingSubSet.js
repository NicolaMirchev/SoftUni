

function FindAscendingSubSet(array)
{
    let maxNum = Number.MIN_VALUE;
   let result =  array.reduce((arr, currentElement) =>{
        if (currentElement > maxNum) {
            arr.push(currentElement);
            maxNum = currentElement;
        }

        return arr;
    }, [])
    return result;
}

console.log(FindAscendingSubSet([1, 2, 3, 4]));
console.log(FindAscendingSubSet([6, 3, 42, 4]));