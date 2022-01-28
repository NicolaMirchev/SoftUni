function solve (area, vol, data){

    const cubes = JSON.parse(data);
    const result = [];

    for (cube of cubes){

        const currentObj = {area : area.apply(cube),
        vol : vol.apply(cube)};
            result.push(currentObj);
    }
    return result;
}

let data = `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`;
    

console.log(solve(area, vol, data));


function area(){
    return Math.abs(this.x * this.y);
 };

 function vol(){
    return Math.abs(this.x * this.y * this.z);
    };