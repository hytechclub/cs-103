Create a new Visual Studio Shortcut
Open the Shortcut Properties
Append ` /RootSuffix Teaching` to the end of the shortcut
Change the name of the shortcut to "Visual Studio (Teaching)"
Open it up and configure the settings:

Tools -> Options -> Environment -> Fonts and Colors
- Text Editor
- Statement Completion
- Editor Tooltip
- [All Text Tool Windows]
- [Watch, Locals, and Autos Tool Windows]
- CallStack Window
- Environment

This way, your development environment will not be affected, but you will have a nice teaching environment where everything is readable without any additional extensions.

https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2015/extensibility/the-experimental-instance?view=vs-2015&redirectedfrom=MSDN

https://blog.slaks.net/2014-01-27/creating-multiple-visual-studio-profiles-with-rootsuffix/