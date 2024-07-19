namespace assignment4
{
    public class Rectangle : IRectangle
    {


        double Area;
        public double area
        {
            get
            {
                return Length *Width;
            }
        }

        public double Length { get ; set ; }
        public double Width { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine(area);
        }

        public Rectangle(double _length,double _Width)
        {
            Length = _length;
            Width = _Width;
        }
    }
    }

