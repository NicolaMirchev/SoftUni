function createDeck(arrayOfCards){

    const result = [];
    for (card of arrayOfCards){
        const suit = card[card.length - 1];
        const face = card.slice(0, card.length - 1 );

  
        try {
            result.push(createCard(face, suit));;           
        } catch (error) {
            console.log('Invalid card: ' + face + card);
            return;
        }
        
    }
    return result.join(' ');
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

}

console.log(createDeck(['AS','10D','KH', '2C']));
console.log(createDeck(['5S','3D','KH', '1C']));