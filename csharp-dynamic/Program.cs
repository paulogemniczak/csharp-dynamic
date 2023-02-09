dynamic name = "Paulo";
Console.WriteLine(name);
name = 40;
Console.WriteLine(name);

name = "Daniele";
// name++; //Microsoft.CSharp.RuntimeBinder.RuntimeBinderException: Operator '++' cannot be applied to operand of type 'string'

dynamic a = 10; // dynamic {int}
dynamic b = 5; // dynamic {int}
var c = a + b; // dynamic {int}