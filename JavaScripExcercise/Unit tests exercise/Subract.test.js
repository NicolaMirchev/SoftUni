const {expect} = require('chai');

const {createCalculator} = require('./Subtract');


describe('Calculator function Test', () => {

    let instanse = null;

    beforeEach(() => {
        instanse = createCalculator();        
    })

    it('starts with value of 0', () => {
        expect(instanse.get()).is.equal(0);
    })
    it('has all the properties', () => {

        expect(instanse).property('add');
        expect(instanse).property('subtract');
        expect(instanse).property('get');
    })
    it('add and subtract values correctly', () => {
        expect(instanse.get()).to.equal(0);
        
        instanse.add(5);
        expect(instanse.get()).to.equal(5);
        
        instanse.subtract(3);
        expect(instanse.get()).to.equal(2);

    })
    it('can take string as arguments and parse it', () => {

        instanse.add('5');
        expect(instanse.get()).to.equals(5);

    })
    it('cannot modifly value from outside', () => {
        expect(instanse.value).to.be.undefined;
    })




})