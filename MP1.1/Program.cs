using System;

namespace MP1._1
{
    class Document
    {
        string body { get; set; }
        string footer { get; set; }
        public void InitilazeDocument()
        {
            Console.WriteLine("Метод класса - initilazeDocument.");
        }
        public void Show()
        {
            Console.WriteLine("Метод класса Document - Show.");
        }
    }
    class Title : Document
    {
        string content { get; set; }
        public void Show_Title()
        {
            Console.WriteLine("Метод класса Title - Show.");
        }
    }
    class Body : Document
    {
        string content { get; set; }
        public void Show_Body()
        {
            Console.WriteLine("Метод класса Body - Show.");
        }
    }
    class Footer : Document
    {
        string content { get; set; }
        public void Show_Footer()
        {
            Console.WriteLine("Метод класса Footer - Show.");
        }
    }
    class Program
        {
        static void Main()
        {
            Document instance = new Document();
            Title instance0 = new Title();
            Body instance1 = new Body();
            Footer instance2 = new Footer();
            instance.Show();
            instance0.Show_Title();
            instance1.Show_Body();
            instance2.Show_Footer();

            //Document v = instance as Document;
            //v.Show();

            //Title v0 = instance0 as Title;
            //v0.Show_Title();

            //Body v1 = instance1 as Body;
            //v1.Show_Body();

            //Footer v2 = instance2 as Footer;
            //v2.Show_Footer();
        }
        }
    
}
