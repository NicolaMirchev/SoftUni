function solve(){
    let protein = 0;
    let carbohydrate = 0;
    let fat = 0;
    let flavours = 0;   

    return function(command){
        const arguments = command.split(' ');

        if(arguments[0] == 'restock'){
            switch(arguments[1]){
                case 'protein':
                    protein += Number(arguments[2]);
                    break;
                 case 'carbohydrate':
                 carbohydrate += Number(arguments[2]);
                 break;
                 case 'fat':
                     fat += Number(arguments[2]);
                     break;
                 case 'flavour':
                         flavours += Number(arguments[2]);     
                         break;                    
            }
            return 'Success';
        }
        else if (arguments[0] == 'prepare') {
            switch(arguments[1]){
                case 'apple':

                    if (carbohydrate - 1 >= 0 && flavours - 2 >= 0){
              
                            carbohydrate -= 1;
                            flavours -= 2;
                            return 'Success';
                        
                       
                    }
                    else return `Error: not enough ${(carbohydrate - 1 < 0) ? 'carbohydrate' : 'flavour'} in stock`;
                    break;
                case 'lemonade':
                    if( carbohydrate - 10 >= 0 && flavours - 20 >= 0){
                        carbohydrate -= 10;
                        flavours -= 20;
                        return 'Success';
                    }
                    else return `Error: not enough ${(carbohydrate - 10 < 0) ? 'carbohydrate' : 'flavour'} in  stock`;
                    break;
                case 'burger':
                    if(carbohydrate - 5 >= 0 && fat - 7 >= 0 && flavours - 3 >= 0){
                        carbohydrate -= 5;
                        fat -= 7;
                        flavours -= 3;
                        return 'Success';
                    }
                    else {
                        let ingredient = '';
                        if(carbohydrate -5 < 0){
                            ingredient = 'carbohydrate';
                        }
                        else if(fat - 7 < 0) ingredient = 'fat';
                        else ingredient = 'flavour';
                        return `Error: not enough ${ingredient} in stock`;
                    }    
                    break;
                case 'eggs':
                    if(protein - 5 >= 0 && fat - 1 >= 0 && flavours - 1 >= 0) {
                        protein -= 5;
                        fat -= 1;
                        flavours -= 1;

                        return 'Success';
                    }
                    else{
                        let ingr = ''
                        if(protein - 5 < 0) ingr = 'protein';
                        else if (fat - 1 < 0 ) ingr = 'fat';
                        else ingr = 'flavour';
                        return `Error: not enough ${ingr} in stock`;
                    }
                    break;
                case 'turkey':
                    if(protein - 10 >= 0 && fat - 10 >= 0 && flavours - 10 >= 0 && carbohydrate - 10 >= 0){
                        protein -= 10;
                        fat -= 10;
                        flavours -= 10;
                        carbohydrate -= 10;

                    return 'Success';
                    }    
                    else{
                        let ingr = '';
                        if ( protein - 10 < 0) ingr = 'protein';
                        else if(carbohydrate - 10 < 0) ingr = 'carbohydrate';
                        else if(fat - 10 < 0) ingr = 'fat';
                        else if(flavours - 10 < 0) ingr = 'flavour';
                      
                        return `Error: not enough ${ingr} in stock`;
                    }       
                    break; 

            }
        }
        else if (arguments[0] == 'report') {
            return `protein=${protein} carbohydrate=${carbohydrate} fat=${fat} flavour=${flavours}`;
        }

    }

}

let manager = solve();

console.log(manager('prepare turkey 1'));
console.log(manager('restock protein 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('restock carbohydrate 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('restock fat 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('restock flavour 10'));
console.log(manager('prepare turkey 1'));
console.log(manager('report'));
// prepare turkey 1
// restock protein 10
// prepare turkey 1
// restock carbohydrate 10
// prepare turkey 1
// restock fat 10
// prepare turkey 1
// restock flavour 10
// prepare turkey 1
// report