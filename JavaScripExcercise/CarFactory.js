 /// <param name="array" type="Array"></param>
    function CreateCar(obj)
    {
        function GetEnginePower(number)
        {
            if (number <= 90) {
                return {power : 90, volume : 1800};
            }
            else if (number <= 120) {
                return {power: 120 , volume: 2400};
            }
            else { return {power: 200, volume: 3500} };
        }

        let wheelsizeNumber = obj.wheelsize % 2 == 0 ? obj.wheelsize - 1 : obj.wheelsize;
        const wheelsize = new Array(4).fill(wheelsizeNumber, 0, 4);

        const resultCar = {}
        resultCar.model = obj.model;
        resultCar.engine = GetEnginePower(obj.power);
        resultCar.carriage = {type : obj.carriage, color : obj.color};
        resultCar.wheels = wheelsize;


        return resultCar;

    }

console.log(CreateCar({ model: 'VW Golf II',
power: 150,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
));