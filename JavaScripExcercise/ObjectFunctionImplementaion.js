function CityRecord(ciryName, population, treasury) {

  const cityObject = {name : ciryName,
                population,
                treasury,
                taxRate: 10, 
                collectTaxes: function collect() {
                  this.treasury += this.population * this.taxRate;

                },
                applyGrowth: function(percentage) {
                  this.population += (this.population * percentage/100);
                },
                applyRecession: function(percentage) {
                  this.treasury -= Math.floor(treasury * percentage / 100);
                }                    
              };


    cityObject.collectTaxes();
    console.log(cityObject.treasury);
    cityObject.applyGrowth(5);
    console.log(cityObject.population);
    return cityObject;
}
console.log(CityRecord('Tortuga',
  7000,
  15000));