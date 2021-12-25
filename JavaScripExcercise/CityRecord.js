

function CityRecord(ciryName, population, treasury) {

  const cityObject = {name : ciryName,
                population,
                treasury};

    return cityObject;
}
console.log(CityRecord('Tortuga',
  7000,
  15000));
