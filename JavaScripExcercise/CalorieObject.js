function ex1(array){

  const result = {};
  for (let i = 0; i < array.length; i+= 2){

    result[array[i]] = Number(array[i + 1]);
  }

  return result;
}

console.log(ex1(['Yoghurt', '48', 'Rise', '138','Apple', '52']));