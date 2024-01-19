using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gang_of_four.ProtoType
{
    public static  class ProtoTypeExample
    {
        public static void   ProtoTypeExample1(){
            var rectangle1 = new Rectangle(5, 20);
            rectangle1.DisplayInformation();

            var rectangle2= rectangle1.Clone() as Rectangle;
            rectangle2.DisplayInformation();
        }
    }

    public interface ICloneable
    {
        ICloneable Clone();
    }

    public class Rectangle : ICloneable
    {
        private int _width;
        private int _length;
        public Rectangle(int width,int length)
        {
            _width = width;
            _length = length;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"WIDTH: {_width} LENGTH: {_length}");
        }

        public ICloneable Clone()
        {
            return new Rectangle( _width, _length );
        }
    }
}
