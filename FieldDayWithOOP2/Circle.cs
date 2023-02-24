namespace FieldDayWithOOP2
{
    internal class Circle : Geometry
    {
        #region Fields
        private double _radius;
        #endregion
        #region Constructor
        internal Circle(double radius)
        {
            _radius = radius;
        }
        #endregion
        #region Methods
        internal override double GetArea()
        {
            return  Math.PI * (_radius * _radius);
        }
        internal override double GetPerimeter()
        {
            return 2*Math.PI * _radius;
        }
        internal override void DisplayFigure()
        {
            Console.WriteLine($"Area of a Circle: {GetArea()}");
            Console.WriteLine($"Perimeter of a Circle: {GetPerimeter()}");
        }
        #endregion
    }
}
