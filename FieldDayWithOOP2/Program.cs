namespace FieldDayWithOOP2
{
    /*
    Sukurkite klasė Rectangle, kuriai per konstruktoriu paduokite width ir height. Realizuokite du metodus GetArea ir GetPerimeter;
    Sukurkite klasė Circle, kuriai per konstruktoriu paduokite radius. Realizuokite du metodus GetArea ir GetPerimeter;
    Sukurkite klasė Triangle, kuriai per konstruktoriu paduokite trikampio kraštinių ilgius a, b ir c . 
    Realizuokite du metodus GetArea ir GetPerimeter.
    Vartotojas įveda stačiakampio aukštį ir plotį, apskritimo radiusą ir trikampio kraštinių ilgius. 
    Programa atspausdina į ekraną kiekvienos figūros plotą ir perimetrą.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization of figures
            var rectangle = new Rectangle(DataCollector.EnterDimension("Enter height of a rectangle"), 
                DataCollector.EnterDimension("Enter width of a rectangle"));
            var circle = new Circle(DataCollector.EnterDimension("Enter radius of a circle"));
            var triangle = new Triangle(DataCollector.EnterDimension("Eter tirangle border a"), 
                DataCollector.EnterDimension("Eter tirangle border b"), 
                DataCollector.EnterDimension("Eter tirangle border c"));
            #endregion
            #region Data display to console
            Console.WriteLine();
            rectangle.DisplayFigure();
            Console.WriteLine();
            circle.DisplayFigure();
            Console.WriteLine();
            triangle.DisplayFigure();
            #endregion
        }
    }
}