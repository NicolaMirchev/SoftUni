import {openMonths , hideYears , returnToYearsSection} from './monthCalendar.js';
import {openDayCalendar, hideMonths} from './dayCalendar.js';

const yearsSection = document.getElementById('years');

yearsSection.addEventListener('click', displayTargetYear)


let currentOpenedYear;
let currentOpenedMonth;

function displayTargetYear(event){

    if(event.target.className == 'day'){

        const year = event.target.children[0].textContent;
        
        currentOpenedYear = year;
        const currentOpenedSection = openMonths(year);
        currentOpenedMonth = currentOpenedSection;
        hideYears();

        currentOpenedSection.addEventListener('click', dispayTargetMonth)        

    }    
}

function dispayTargetMonth(event){

    if(event.target.tagName == 'CAPTION'){

       returnToYearsSection(event.target.textContent);
    }
    else{
        const months  = {Jan : '1',
                         Feb : '2',
                         Mar : '3',
                         Apr: '4',
                         May : '5',
                         Jun : '6',
                         Jul : '7',
                         Aug : '8',
                         Sept : '9',
                         Oct : '10',
                         Nov : '11',
                         Dec : '12'};
      
             const section = openDayCalendar(currentOpenedYear,months[event.target.children[0].textContent]);
            hideMonths(currentOpenedYear);

            document.querySelector(`#${section.id} caption`).addEventListener('click', function () {
                section.style.display = 'none';
                currentOpenedMonth.style.display = 'grid';
            });

    }
}
