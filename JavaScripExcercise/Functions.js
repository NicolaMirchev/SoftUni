function solve(data, criteria) {

    const employees = JSON.parse(data);

    const criteriaAsArray = criteria.split('-');

    const result = employees.filter(e => e[criteriaAsArray[0]] == criteriaAsArray[1])

    for (let i = 0;  i < result.length; i++){

        
       console.log(i + '.' + ' ' + result[i].first_name + result[i].last_name + ' - ' + result[i].email);
    }


}

console.log(solve(`[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
    }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
    },
    {
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
    }]`,
    'gender-Female'
    )); 
