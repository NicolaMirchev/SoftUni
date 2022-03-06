export function openDayCalendar(year, month){

    const section = document.getElementById('month-' + year + '-' + month)
    section.style.display = 'grid';
    return section;
}

export function hideMonths(currentOpenedYear){

    document.getElementById('year-' + currentOpenedYear).style.display = 'none';
}