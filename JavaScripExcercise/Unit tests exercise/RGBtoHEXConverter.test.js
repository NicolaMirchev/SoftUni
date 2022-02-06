const {expect} = require('chai');
const {rgbToHexColor} = require('./RGBtoHEXConverter');


describe('RGBtoHEXConverter Tests', () => {
    it('works correctly for white color', () => {

        expect(rgbToHexColor(255, 255, 255)).to.be.equal('#FFFFFF');
    })
    it ('works correctly for the black color', () => {

        expect(rgbToHexColor(0, 0, 0)).to.equal('#000000')
    })
    it('works correctly for random purple color', () => {

        expect(rgbToHexColor(133, 0, 242)).to.equal('#8500F2');
    })
    it('returns undefined for wrong or missing red value', () => {
        expect(rgbToHexColor(0, 222)).to.be.undefined;
        expect(rgbToHexColor(-1, 0, 222)).to.be.undefined;
        expect(rgbToHexColor(256, 0, 222)).to.be.undefined;
    })
    it('returns undefined for wrong or missing green value', () => {
        expect(rgbToHexColor(0, 222)).to.be.undefined;
        expect(rgbToHexColor(3, -2, 222)).to.be.undefined;
        expect(rgbToHexColor(252, 260, 222)).to.be.undefined;
    })
    it('returns undefined for wrong or missing blue value', () => {
        expect(rgbToHexColor(0, 222)).to.be.undefined;
        expect(rgbToHexColor(5, 0, -2)).to.be.undefined;
        expect(rgbToHexColor(252, 4, 333)).to.be.undefined;
    })





})