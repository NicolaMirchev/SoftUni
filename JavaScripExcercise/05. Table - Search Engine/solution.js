function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      //   TODO:

      // get a list from the rows
      
      const rows = document.querySelector('tbody').children;
      
      // if there is item of the class select, delete it.
      for (row of rows) {         
         if(row.className == 'select'){
            row.className = '';
         }
      }

      //store the input
      const inputString = document.getElementById('searchField').value;

      for (row of rows){
         let currenCol = row.children;

         // get a list from the cols
         for(element of currenCol){

            if(element.textContent.includes(inputString)) row.className = 'select';

         }


      }   

      const cols = rows.children;

      // delete string from the input

      document.getElementById('searchField').value = '';
   }
}