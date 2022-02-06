const {expect} = require('chai');
const {isSymmetric} = require('./SymetryChecker');


describe('Symetry function checker', () => {
    it('checks wheter return true for even count of symetric elemets', () => {
        expect(isSymmetric([1,2,2,1])).to.be.true;
    })
    it('returns true for symetric array of odd number of elements', () => {
        expect(isSymmetric([1,2,1])).to.be.true;
    })
    it('returns true for array of strings', () => {
        expect(isSymmetric(['1', '2', '2', '1'])).to.be.true;
        
    })
    it('returns true for array of different type arguments', () => {
        expect(isSymmetric([1, '1', '1', 1])).to.be.true;

    })
    it('return false if the argument is different from array', () => {
        expect(isSymmetric('1, 2, 2, 1')).to.be.false;
    })
    it ( 'returns false for non-symetric array', () => {
        expect(isSymmetric([1,2,3,4,2,1])).to.be.false;

    })
})
