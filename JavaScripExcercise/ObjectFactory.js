function Compose(functions, objects) {
 

const result = objects.map(Factory);


function Factory(object){

  const newObject = Object.assign({}, object.template);

  for (part of object.parts){
    newObject[part] = functions[part];
  }

  return newObject;

}
   
      
return result;

}
console.log(Compose({
  print: function () {
  console.log(`${this.name} is printing a page`);
  },
  scan: function () {
  console.log(`${this.name} is scanning a document`);
  },
  play: function (artist, track) {
  console.log(`${this.name} is playing '${track}' by ${artist}`);
  },
  }, [{
    template: { name: 'ACME Printer'},
    parts: ['print']
    },
    {
    template: { name: 'Initech Scanner'},
    parts: ['scan']
    },
    {
    template: { name: 'ComTron Copier'},
    parts: ['scan', 'print']
    },
    {
    template: { name: 'BoomBox Stereo'},
    parts: ['play']
    }
    ]));