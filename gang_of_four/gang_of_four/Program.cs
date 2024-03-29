﻿using gang_of_four;
using gang_of_four.AbstractFactory;
using gang_of_four.builder;
using gang_of_four.Factory;
using gang_of_four.ProtoType;
using gang_of_four.Singleton;

class Program
{
    static void Main()
    {   /*****************abstract factory *********************/
        // For Windows
        /*GUIFactory windowsFactory = new WindowsGUIFactory();
        GUIApplication windowsApp = new GUIApplication(windowsFactory);
        windowsApp.CreateUI();*/

        // For macOS
        /*GUIFactory macosFactory = new MacOSGUIFactory();
        GUIApplication macosApp = new GUIApplication(macosFactory);
        macosApp.CreateUI();*/

        //TestMyself.simpleApp();


        /*****************end of abstract factory *********************/


        /***************** builder pattern ****************************/
        //TestMyself_builder.cooking();
        /***************** end of  builder pattern *********************/

        //factory pattern
        //FactoryExample.FactoryExample1();

        //prototype pattern
        //ProtoTypeExample.ProtoTypeExample1();

        //singleton example
        SingletonExample.SingletonExample1();
    }    
}
