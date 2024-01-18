using gang_of_four.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace gang_of_four.AbstractFactory
{
    
    /*
     * gave my self a challenge to implement a theming four an application 
     * using the abstract class pattern
     */

    /******************************** abstract elements********************/

    public class TestMyself
    {
        public TestMyself() { }

        public static void simpleApp()
        {
            var theme= new DarkTheme();
            var myApp = new App(theme);
            myApp.renderUi();
        }
    }
    public interface IButton
    {
        void render();
    }

    public interface ILabel
    {
        void render();
    }

    public interface IText
    {
        void render();
    }
    /******************************** end of abstract elements ************/


    /******************************** concrete elements ********************/

    public class DarkThemeText: IText { 
      public void render()
        {
            Console.WriteLine("Dark Theme Text");
        }
    }

    public class DarkThemeButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Dark Theme Button");
        }
    }

    public class DarkThemeLabel : ILabel
    {
        public void render()
        {
            Console.WriteLine("Dark Theme label");
        }
    }

    public class lightThemeText : IText
    {
        public void render()
        {
            Console.WriteLine("Dark Theme Text");
        }
    }

    public class lightThemeButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Dark Theme Button");
        }
    }

    public class lightThemeLabel : ILabel
    {
        public void render()
        {
            Console.WriteLine("Dark Theme label");
        }
    }
    /******************************** end of concrete elements ************/

}


/******************************** abstract theme Factory***********************/
public interface ITheme
{
    IButton CreateButton();

    ILabel CreateLabel();

    IText CreateText();

    
}


/******************************** end of abstract them factory********************/



/******************************** concrete  theme Factory***********************/
public  class LightTheme : ITheme
{
   

    public IText CreateText()
    {
        return new lightThemeText();

    }

    public ILabel CreateLabel()
    {
        return new lightThemeLabel();
    }

    public IButton CreateButton()
    {
        return new lightThemeButton();
    }
}


public class DarkTheme : ITheme
{


    public IText CreateText()
    {
        return new DarkThemeText();

    }

    public ILabel CreateLabel()
    {
        return new DarkThemeLabel();
    }

    public IButton CreateButton()
    {
        return new DarkThemeButton();
    }
}


/******************************** end of concretetheme Factory***********************/




/******************************** ui application***********************/

public class App
{   private ITheme _theme;
    public App(ITheme theme)
    {
        _theme = theme;
    }

    public void renderUi()
    {
       var button =  _theme.CreateButton();
       var label= _theme.CreateLabel();
       var text= _theme.CreateText();

        button.render();
        label.render();
        text.render();
    }
}

/******************************** end of ui application***********************/