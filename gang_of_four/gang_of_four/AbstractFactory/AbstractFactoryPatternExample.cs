using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gang_of_four.AbstractFactory
{
    internal class AbstractFactoryPatternExample
    {
    }

   

    // Abstract Products
    public interface Button
    {
        void Render();
    }

    public interface Checkbox
    {
        void Render();
    }

    // Concrete Products
    public class WindowsButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows button.");
        }
    }

    public class WindowsCheckbox : Checkbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows checkbox.");
        }
    }

    public class MacOSButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Rendering a macOS button.");
        }
    }

    public class MacOSCheckbox : Checkbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a macOS checkbox.");
        }
    }

    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }

    // Concrete Factories
    public class WindowsGUIFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WindowsButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }

    public class MacOSGUIFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacOSButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }

    // Client Code
    public class GUIApplication
    {
        private GUIFactory guiFactory;

        public GUIApplication(GUIFactory factory)
        {
            this.guiFactory = factory;
        }

        public void CreateUI()
        {
            Button button = guiFactory.CreateButton();
            Checkbox checkbox = guiFactory.CreateCheckbox();

            button.Render();
            checkbox.Render();
        }
    }



}
