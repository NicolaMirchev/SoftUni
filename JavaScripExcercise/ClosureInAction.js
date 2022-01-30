function solution(){
    let string ='';

    return {

        append : function append(data){
            string += data;
        },
        removeStart : function removeStart(data){
            string = string.slice(data, string.length);
        },
        removeEnd : function removeEnd(data){
            string = string.slice(0, string.length - data);
        },
        print : function print(){
            console.log(string);
        }
    }

}

let firstSolution = solution();

firstSolution.append('hello');
firstSolution.append('print');
firstSolution.print();