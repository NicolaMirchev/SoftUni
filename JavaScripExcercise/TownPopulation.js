

function TownPopulaton(arrayOfCities) {

  const cityRegister = {  };

  for (let city of arrayOfCities){
    let cityName = city.split(' <-> ')[0];
    let cityPop = Number(city.split(' <-> ')[1]);

    !cityRegister.hasOwnProperty(cityName) ? cityRegister[cityName] = cityPop : cityRegister[cityName] += cityPop;
  }

  let outPut = '';
  for (let city in cityRegister){
    outPut += `${city} : ${cityRegister[city]}` + '\n';
  }
  return outPut;
}
console.log(TownPopulaton(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']
));

console.log(TownPopulaton(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
));
