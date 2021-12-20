

function FindTheSequence(array, firstFlavour, secondFlavour) {

  let resultArr = [];
  let sequencseHasStarted = false;

  for(i = 0; i < array.length; i++){
    if(array[i] == firstFlavour) sequencseHasStarted = true;

    if (sequencseHasStarted) resultArr.push(array[i]);
    if(array[i] == secondFlavour) break;

  }

  return resultArr;
}
    console.log(FindTheSequence(['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie'
    ));
