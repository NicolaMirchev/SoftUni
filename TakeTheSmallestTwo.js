

function Sort(array) {

  array.sort((a, b) => a - b);

  return array[0] + ' ' + array[1];
}
    console.log(Sort([7, -2, 8, 9]));
    console.log(Sort([3, -2, 0, -1]));