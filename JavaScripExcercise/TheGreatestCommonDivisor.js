

function FindGCD(b, c)
{
    let greatest;
    let lowest;
    if(b < c)
    {
        greatest = c;
        lowest = b;
    }
    else
    {
        greatest = b;
        lowest = c;
    }

    while (lowest != 0)
    {
        let temp = greatest % lowest;

        greatest = lowest;
        lowest = temp;    
    }

    console.log(greatest);
}

FindGCD(2154, 458);