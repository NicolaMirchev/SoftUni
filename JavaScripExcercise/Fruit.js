

function CalculatePrice(fruit, grams, pricePerkg)
{
    let kilograms = grams / 1000;

    let neededMoney = kilograms * pricePerkg;
    console.log(`I need $${neededMoney.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruit}.`)
}
      
CalculatePrice('Bannana', 2500, 1.80)
CalculatePrice('Apple', 1563, 2.35)