
export function openMonths(year){

    const section = document.getElementById('year-' + year);
    section.style.display = 'grid';
    return section;

}
export function hideYears(){
    document.getElementById('years').style.display = 'none';
}
export function returnToYearsSection(currentOpenedYear) {

    document.getElementById('years').style.display = 'grid';
    document.getElementById('year-' + currentOpenedYear).style.display = 'none';
}