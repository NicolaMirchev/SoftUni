const { expect } = require("chai");
let { Repository } = require("./solution.js");

describe("Repository tests", function () {
    describe("constructor", function () {
        it("creates data property", function () {

            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let repo = new Repository(properties);
            expect(repo).to.haveOwnProperty('data');
        });
    });
    describe('count property', function() {
        it('works correctly', function() {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity = {
                    name: "Pesho",
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);
                repo.add(entity);
                expect(repo.count).to.equal(1);

        })            
    })
    describe('add function', function () {
        it('works correctly and return the ID of the object', function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity = {
                    name: "Pesho",
                    age: 22,
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);
                
                expect(repo.add(entity)).to.equal(0);
        });
        it('throws and error if the entity arguments are different or missing from defined properties', function (){

let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity = {
                    name: "Pesho",
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);

            expect(repo.add.bind(repo, entity)).to.throw('Property age is missing from the entity!');

        });
        it('throws and error if entity data types are different from defined in property', function() {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity = {
                    name: "Pesho",
                    age : "22",
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);

            expect(repo.add.bind(repo, entity)).to.throw('Property age is not of correct type!');

        });
    })
    describe('getID function works correctly', function() {
        it('retunrn correct objcet', function() {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity1 = {
                    name: "Pesho",
                    age : 15,
                    birthday: new Date(1998, 0, 7)
                };
                let entity2 = {
                    name: "Gesho",
                    age : 33,
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);
                repo.add(entity1);
                repo.add(entity2);
                expect(repo.getId(1)).to.equal(entity2);
        })
    });
    describe('replace function works correctly', function() {
        it('replace correct', function() {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity1 = {
                    name: "Pesho",
                    age : 15,
                    birthday: new Date(1998, 0, 7)
                };
                let entity2 = {
                    name: "Gesho",
                    age : 33,
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);
                repo.add(entity1);

                repo.update(0, entity2);
                expect(repo.getId(0)).equal(entity2);
        });
        it('throws an error for invalid ID', function() {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity1 = {
                    name: "Pesho",
                    age : 15,
                    birthday: new Date(1998, 0, 7)
                }; 

                let repo = new Repository(properties);
                
                expect(repo.update.bind(repo, 0)).throws('Entity with id: 0 does not exist!');

        })      
    });
    describe('delete method', function() {
        it('works correct for valid arguments', function() {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity1 = {
                    name: "Pesho",
                    age : 15,
                    birthday: new Date(1998, 0, 7)
                };
                let repo = new Repository(properties);
                repo.add(entity1);

                expect(repo.count).to.equal(1);

                repo.del(0);
                expect(repo.count).to.equal(0);

        });

        it('throws an error when invalid id is passed', function() {

            let properties = {
                name: "string",
                age: "number",
                birthday: "object"};

                let entity1 = {
                    name: "Pesho",
                    age : 15,
                    birthday: new Date(1998, 0, 7)
                };

                let repo = new Repository(properties);
                repo.add(entity1);

                expect(repo.del.bind(repo, 3)).to.throw('Entity with id: 3 does not exist!')
        })
                
    })
 });
    

