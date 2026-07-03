namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.MethodOld();
            //myClass.MethodDeprecated();
            myClass.NewMethod();
        }
    }
}
