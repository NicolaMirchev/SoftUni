

function Manipulate(array) {

let resultArr = [];
  for (i = 0; i < array.length; i++) {
     if(i % 2 == 1){
      resultArr.push(array[i]);
     }
  }


  return resultArr.map(v => v *= 2 ).reverse().join(' ');
}
console.log(Manipulate([3, 0, 10, 4, 7, 3]));
