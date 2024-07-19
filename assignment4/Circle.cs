namespace assignment4
{
    public class Circle : ICircle
    {
        double Area;
        public double area
        {
            get
            {
                return Radius*Radius*Math.PI;
            }
        }
        public double Radius { get ; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine(area);
        }

        public Circle(double _R)
        {
            Radius = _R;
        }
    }
    }

