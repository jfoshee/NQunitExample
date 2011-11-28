NQUnit Example
==============

This is an example of how to run javascript tests within a .NET project.  
The javascript tests use QUnit.  These tests are launched using NQUnit.
NuGet is used to manage the dependencies. 

The majority of the code is boilerplate that you might need to do something similar.

### Usage
- Open the solution
- Run all tests (Ctrl+R, A)
- You should see Internet Explorer open and close in the taskbar
- You should get a failing test: ```Assert.AreEqual failed. Expected:<pass>. Actual:<fail>.```
- If you want to see the tests passing, correct the js test in ExampleTest.html
- Feel free to contact me or open an issue if you have trouble

### Acknowledgements
- Thanks to John Resig, Jörn Zaefferer for QUnit
- Thanks to Robert Moore for NQUnit
