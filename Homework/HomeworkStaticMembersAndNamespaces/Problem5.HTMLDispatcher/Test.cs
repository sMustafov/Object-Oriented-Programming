using System;

namespace Problem5.HTMLDispatcher
{
    class Test
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine(HTMLDispatcher.CreateImage("http://facebook.com/userimg.jpg", "UserImg", "Facebook"));
            Console.WriteLine(HTMLDispatcher.CreateUrl("http://facebook.com/", "Click", "Facebook"));
            Console.WriteLine(HTMLDispatcher.CreateInput("Button", "Register", "Click"));
        }
    }
}
