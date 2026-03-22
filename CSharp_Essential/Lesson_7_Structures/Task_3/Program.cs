using Task_3;

static void ClassTaker (MyClass myClass)
{ myClass.change = "змінено"; }

static void StructTaker (MyStruct myStruct)
{ myStruct.change = "змінено"; }


MyClass myClass = new MyClass ();
myClass.change = "Не змінено";

MyStruct myStruct = new MyStruct ();
myStruct.change = "Не змінено";

ClassTaker (myClass);
StructTaker (myStruct);

Console.WriteLine($"MyClass - {myClass.change}");
Console.WriteLine($"MyStruct - {myStruct.change}");
