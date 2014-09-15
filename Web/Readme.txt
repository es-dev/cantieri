Visual WebGui - Links
====================================================
1. Home page 			- http://www.visualwebgui.com
2. Bug tracking and reporting 	- http://support.visualwebgui.com
3. Any questions can be sent to	- support@visualwebgui.com
4. Developer Resources		- http://www.visualwebgui.com/Gizmox/Solutions/VisualWebGui/VWGDevelopersCenter/tabid/783/Default.aspx


Visual WebGui - Frequently Asked Questions
====================================================

1. What is the Visual WebGui Integration feature within Visual Studio?
--------------------------------------------------------------------------------------------------------

Enabling Visual WebGui's Integration feature within Visual Studio gives you access to sets
of tools to manage the application at run time and in development. This feature simplifies the
development of a VWG application by adding new menues, property tabs and additional features.
To implement the Integration feature, right click on the project and select "Enable Visual WebGui" (Once
you do this you cant roll back on the current application). 


2. When I run the application I get a directory listing instead of the application.
--------------------------------------------------------------------------------------------------------

In order to run a Visual WebGui application from visual studio you need to set the start page 
to a virtual Visual WebGui page.

With the Integration feature:
Right click on the form you want as the start up form of the application and select "Set as start form".

With out the Integration feature:
Open the project properties, select the web tab, choose "Specific Page" and enter the virtual 
page you want to start from ("Form.wgx" for example).


3. How do I define a virtual Visual WebGui page?
--------------------------------------------------------------------------------------------------------

With the Integration feature:
Open the project properties, select the Registration tab and click the Add button in the Application section.
A list of forms that where not set as a page is displayed and you can select a form from this list.

With out the Integration feature:
In the Visual WebGui configuration section there is an Applications section. Each application mapped
in the Application section represents a virtual page. The code attribute is the page name and
the type attribute is the class mapping that should inherit from the Gizmox.WebGUI.Forms.Form class.


3. When I run the WGX page I get a message that the resource was not found.
--------------------------------------------------------------------------------------------------------

Visual WebGui uses its own script map called wgx. The wgx extension is defined in the IIS manager and should 
have the same definitions as the aspx extension but without the "check file exists" setting. 
If you are getting this message it is either because you have not registered the script map or because 
you have the "check file exists" setting still checked in the wgx definition.


4. How do I create a new form?
--------------------------------------------------------------------------------------------------------

Right click your project and select Add. From the Add menu select a Visual WebGui form or a Visual WebGui user control.


5. How do I use a User Control?
--------------------------------------------------------------------------------------------------------

The best way to implement a User Control is to drag a Panel to the form and then switch to the *.design.vb 
or *.design.cs file and replace the declaration of the Panel with your User Control and the 
initialization of the Panel to your User Control type.


6. When I drag controls to the Visual WebGui designer I get an "Invalid WebGUI Control" message.
--------------------------------------------------------------------------------------------------------

You are probably trying to drag a WinForms control or some other non Visual WebGui control. 
Look for the Visual WebGui section in the toolbox and drag the components from there.


