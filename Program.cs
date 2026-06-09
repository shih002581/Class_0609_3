namespace Class_0609_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel hander;

            hander = new MyDel(Class1.Sub);
            hander += new MyDel(Class1.Add);
            hander += new MyDel(Class1.Div);
            hander += new MyDel(Class1.Mul);
            hander += new MyDel(Class1.Add);
            hander -= new MyDel(Class1.Sub);

            hander(10, 20);
            Console.WriteLine(Class1.Str);
        }
    }
}
