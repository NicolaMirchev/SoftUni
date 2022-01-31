function Order(data, sortType){
    if (sortType == 'asc'){

        data.sort((a, b) => a -b);

    }
    else if (sortType == 'desc'){
        data.sort((a, b) => b - a);
    }

    return data;
}

console.log(Order([14, 7, 17, 6, 8], 'asc'));
console.log(Order([14, 7, 17, 6, 8], 'desc'));
console.log(Order([14, 7, 17, 6, 8], 'asc'));