﻿using gang_of_four;
using gang_of_four.AbstractFactory;

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

        TestMyself.simpleApp();


        /*****************end of abstract factory *********************/
    }
}