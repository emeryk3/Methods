## Methods

A method is a sequence of statements and are declared within a class. Methods are useful if you need to use the same code over and over again, remember the word DRY (Don’t Repeat Yourself).
 SYNTAX:
 <Returntype> name (parameterList)
 {
 Body Code
 }
 The method name should be something meaningful, and the same variable naming rules apply, so something like customer$name is not valid.
 turnType – The returnType is the data type: int, string etc. Methods also return a value; if your method does not return a value then you must use the keyword void instead of returnType.
 name – The name, as discussed earlier, is the method name.
 ParameterList – This describes the type of information you want to pass on to the method. This is set in the brackets (or parentheses); if you set more than two parameters you separate them witha comma.  The ParameterList is optional.*/

 ## Variables in Method:
You can create variables in methods; however before using a method you must declare it, and that variable can only be used within that method. This is called scope and the variables are called local variables.
 
## Passing Parameters
The previous example is simple; it has no return value or arguments to pass. More complex methods have arguments and return values. In the next example we will create a short program which calculates product cost after VAT (Value After Tax) has been added.
The next example names the method VAT with the data type double and two parameters: productCost and currentRate, which is the current VAT rate (20%). The data types for these are double because the result can be a floating point number, such as £32.50.
To calculate product cost after VAT has been added you use the percentage multiplier, so: (VAT rate + 100) / 100 e.g. (20 + 100) / 100 = 1.2. Remember you need the brackets to show which calculation you want to do first (in this case addition). Next we return the value, which is productCost multiplied by VAT rate
