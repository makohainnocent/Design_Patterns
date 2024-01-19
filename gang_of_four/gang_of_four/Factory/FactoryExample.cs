using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gang_of_four.Factory
{
    public static class FactoryExample
    {
        public static void  FactoryExample1()
        {
            // Using Circle Factory
            IShapeFactory circleFactory = new CircleFactory();
            Client client1 = new Client(circleFactory);
            client1.DrawShape();

            // Using Rectangle Factory
            IShapeFactory rectangleFactory = new RectangleFactory();
            Client client2 = new Client(rectangleFactory);
            client2.DrawShape();
        }
    }

    // Step 1: Define the Product interface
    public interface IShape
    {
        void Draw();
    }

    // Step 2: Implement concrete products
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    // Step 3: Create a Factory interface
    public interface IShapeFactory
    {
        IShape CreateShape();
    }

    public class RectangleFactory : IShapeFactory
    {
        public IShape CreateShape()
        {
            return new Rectangle();
        }
    }

    // Step 4: Implement concrete factories
    public class CircleFactory : IShapeFactory
    {
        public IShape CreateShape()
        {
            return new Circle();
        }
    }

    // Step 5: Client code uses the factory to create objects
    public class Client
    {
        private IShapeFactory shapeFactory;

        public Client(IShapeFactory factory)
        {
            this.shapeFactory = factory;
        }

        public void DrawShape()
        {
            IShape shape = shapeFactory.CreateShape();
            shape.Draw();
        }
    }
}
