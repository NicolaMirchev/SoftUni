function DisplayData(...arguments){

    const typeCounter = {};

    for (argument of arguments){

        let type = typeof(argument);

        console.log(`${typeof(argument)}: ${argument}`);
        
        if(Object.keys(typeCounter).includes(type)) {typeCounter[type] ++;}
        else typeCounter[type] = 1;
    }

    const keys = Object.keys(typeCounter);
    // for (i = 0; i < keys.length - 1 ; i++){
    //     if(typeCounter[keys][i] < typeCounter[keys][i + 1]){

    //         let temp = typeCounter[keys][i];          
    //     }
    // }

    keys.sort((a,b) => typeCounter[b] - typeCounter[a]);

    for (element of keys){
        console.log(element + ' = ' + typeCounter[element]);
    }
}

console.log(DisplayData('cat', 42, function () { console.log('Hello world'); }, 22));