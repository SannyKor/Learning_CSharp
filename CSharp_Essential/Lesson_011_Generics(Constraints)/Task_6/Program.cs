
using System.Collections;
using Task_6;

Console.OutputEncoding = System.Text.Encoding.Unicode;

MyClass myClassInstance1 = new MyClass { Id = 1, Name = "Test" };
MyClass myClassInstance2 = new MyClass { Id = 2, Name = "Another Test" };
MyStruct myStructInstance1 = new MyStruct { Id = 1, Name = "Struct Test" };
MyStruct myStructInstance2 = new MyStruct { Id = 2, Name = "Another Struct Test" };
ArrayList myArrayList = new ArrayList();
myArrayList.Add("Hello");
myArrayList.Add(myClassInstance1);
myArrayList.Add(myClassInstance2);
myArrayList.Add(42);
myArrayList.Add(myStructInstance1);
myArrayList.Add(myStructInstance2);

for(int i = 0; i < myArrayList.Count; i++)
{
    Console.WriteLine($"Елемент {i + 1}: {myArrayList[i]}");
}
/*Проблема в тому, що з таким списком важко працювати, 
 * оскільки він може містити об'єкти різних типів. 
 * Це ускладнює доступ до властивостей та методів цих об'єктів, 
 * оскільки потрібно виконувати перевірки типу та приведення типів. 
 * Наприклад, щоб отримати доступ до властивості Name у MyClass, 
 * потрібно спочатку перевірити, чи є елемент типом MyClass, 
 * а потім виконати приведення типу. Це робить код громіздким і менш читабельним. 
 * Крім того, використання ArrayList не забезпечує типобезпеку, 
 * що може призвести до помилок під час виконання, 
 * якщо випадково додати об'єкт неправильного типу.*/