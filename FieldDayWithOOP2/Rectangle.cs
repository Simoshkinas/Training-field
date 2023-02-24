namespace FieldDayWithOOP2
{
    internal class Rectangle : Geometry
    {
        #region Fields
        private double _height;
        private double _width;
        #endregion
        #region Constructor
        internal Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }
        #endregion
        #region Class Methods
        internal override double GetArea() 
        {   
            return _height * _width;
        }
        internal override double GetPerimeter()
        {
            return (_height + _height) * 2;
        }
        internal override void DisplayFigure()
        {
            Console.WriteLine($"Area of a Rectangle: {GetArea()}");
            Console.WriteLine($"Perimeter of a Rectangle: {GetPerimeter()}");
        }
        #endregion
    }
}
