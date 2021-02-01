using System;

namespace testeventargse
{
    public class testeventargs : EventArgs
    {
        public string teststring { get; set; }
    }
    public class Program
    {
        public EventHandler<testeventargs> eventname;
        public event Action<object,EventArgs> something;
        public static void Main(string[] args)
        {
            Program item = new Program();
            item.executeeventargs();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public void executeeventargs()
        {
            something += (s, e) => { Console.WriteLine("test2"); };
            testeventargs e = new testeventargs() { teststring = "testthis" };
            eventname += testmethod;
            eventname?.Invoke(this,e);
        }

        public static void testmethod(object sender, testeventargs e)
        {
            Console.WriteLine(e.teststring);
        }
    }

    public class testclass
    {
        Program item = new Program();
        public void main()
        {
            item.executeeventargs();
        }
    }
}
