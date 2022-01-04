 /// <param name="array" type="Array"></param>
    function GetRectangle(width, height, color)
    {
        const rectangle = {};
        
        rectangle.height = height;
        rectangle.width = width;
        rectangle.color = color.charAt(0).toUpperCase() + color.slice(1);

        rectangle.calcArea = function() {
            return this.height * this.width;
        };

        return rectangle.calcArea();
    }

console.log(GetRectangle(5,5, 'red'));