

function SortIt(array) {

  let reduced = array.reduce(function(pV, currentItem){
    if (currentItem < 0){
        pV.unshift(currentItem);
    }
    else pV.push(currentItem);

    return pV;
  }, [])
    return reduced.join('\n');
}
    console.log(SortIt([7, -2, 8, 9]));
    console.log(SortIt([3, -2, 0, -1]));