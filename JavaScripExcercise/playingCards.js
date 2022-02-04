function createCard(face, suit){

    const validFaces = ['2', '3', '4', '5', '6' ,'7' ,'8', '9', '10', 'J', 'Q', 'K', 'A'];
    const validSuits = ['S', 'H', 'D', 'C'];

    if(!validFaces.includes(face)) throw new Error ('Invalid card face!');
    if(!validSuits.includes(suit)) throw new Error ('Invalid card suit!');

    const cardSuits =  {S : '\u2660',
                        H : '\u2665',
                        D : '\u2666',
                        C : '\u2663'  };
const result = {face,
    suit : cardSuits[suit],
    toString : function() { return `${this.face}${this.suit}`; }}
        return result.toString()                                        
}


console.log(createCard('A', 'S'));
console.log(createCard('10', 'H'));
console.log(createCard('1', 'C'));