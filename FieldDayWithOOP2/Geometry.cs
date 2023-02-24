namespace FieldDayWithOOP2
{
    internal abstract class Geometry
    {
        /// <summary>
        /// Calculates and returns Area of a Figure
        /// </summary>
        /// <returns></returns>
        internal abstract double GetArea();
        /// <summary>
        /// Calculates and returns Perimeter of a figure
        /// </summary>
        /// <returns></returns>
        internal abstract double GetPerimeter();
        /// <summary>
        /// Displays data of a figure to the Console
        /// </summary>
        internal abstract void DisplayFigure();
    }
}
