using Part_2;
using Part_1;
using Class2 = Part_2.Class1;
using Class1 = Part_1.Class1;

Class1 class1 = new Class1();
class1.ShowHello();
Class2 class2 = new Class2();
class2.ShowHelloFromPart2();
//у класі dll створив батьківський клас, а в класі exe створив дочірній клас, який наслідує батьківський клас.
//У методі Main() створив об'єкти обох класів і викликав їхні методи.
//В складанні Part_2 використавши директиву using для обох класів,
//викликав метод з іншого складання Part_1.
//Також використав директиву using для створення псевдонімів класів, щоб уникнути конфліктів імен.