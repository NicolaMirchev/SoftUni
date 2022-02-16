
class SummerCamp{
    constructor(organizer, location){

            this.organizer = organizer;
            this.location = location;
            this.priceForTheCamp = {child : 150,
                                    student : 300,
                                    collegian : 500};
            this.listOfParticipants = [];                                    
    }

    registerParticipant (name, condition, money){

        if(!this.priceForTheCamp[condition]) throw Error('Unsuccessful registration at the camp.');

        if(this.priceForTheCamp[condition] > money) return `The money is not enough to pay the stay at the camp.`;

        if (this.listOfParticipants.some(p => p.name == name)) return `The ${name} is already registered at the camp.`;

        const currentObj = {name,
                            condition,
                            power : 100,
                            wins : 0};
        this.listOfParticipants.push(currentObj);
        return `The ${name} was successfully registered.`;                            

    }
    unregisterParticipant (name){
        const index = this.listOfParticipants.findIndex(p => p.name == name);
        if(index == -1) throw Error(`The ${name} is not registered in the camp.`)
        else{
            
            
            this.listOfParticipants.splice(index, 1);
            return `The ${name} removed successfully.`;
        }
    }

    timeToPlay(game, participant1, participant2){

        if (game == 'WaterBalloonFights'){

            if(this.listOfParticipants.some(p => p.name == participant1) && (this.listOfParticipants.some(p => p.name == participant2))){                    
                    const firstParticipant = this.listOfParticipants.find(p => p.name == participant1);
                    const secondParticipant = this.listOfParticipants.find(p => p.name == participant2);

                    if(firstParticipant.condition != secondParticipant.condition){
                        throw Error('Choose players with equal condition.');
                    }

                    if(firstParticipant.power > secondParticipant.power){
                        firstParticipant.wins ++;
                        return `The ${firstParticipant.name} is winner in the game ${game}.`;
                    }
                    else if (secondParticipant.power > firstParticipant.power){
                        secondParticipant.wins ++;
                        return `The ${secondParticipant.name} is winner in the game ${game}.`;
                    }
                    else {return 'There is no winner'}                    
            }
            else throw Error('Invalid entered name/s.');
        

        }
        else if(game == 'Battleship'){
            if(this.listOfParticipants.some(p => p.name = participant1)){

                this.listOfParticipants.find(p => p.name == participant1).power += 20;
                return `The ${participant1} successfully completed the game ${game}.`
            }
            else{ 
                throw Error('Invalid entered name/s.')
            }
        }

    }

    toString() {
        let result = '';
        result += `${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}\n`;
        for (const key of this.listOfParticipants.sort((a, b) => a - b)) {
            result += `${key.name} - ${key.condition} - ${key.power} - ${key.wins} \n`;
        }
        return result;
    }
}
const summerCamp = new SummerCamp('Jane Austen', 'Pancharevo Sofia 1137, Bulgaria');
console.log(summerCamp.registerParticipant('Petar Petarson', 'student', 300));
console.log(summerCamp.timeToPlay('Battleship', 'Petar Petarson'));
console.log(summerCamp.registerParticipant('Sara Dickinson', 'child', 200));
// console.log(summerCamp.timeToPlay('WaterBalloonFights','Petar Petarson', 'Sara Dickinson'));
console.log(summerCamp.registerParticipant('Dimitur Kostov', 'student', 300));
console.log(summerCamp.timeToPlay('WaterBalloonFights', 'Petar Petarson', 'Dimitur Kostov'));
    console.log(summerCamp.toString());