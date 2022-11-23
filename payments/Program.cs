using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using payments.SubscriptionContext;

namespace payments.ContentContext
{
    class Program
    {

        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo OOP", "orientacao a objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos orientacao a objetos");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos do C#");
            var courseAspNet = new Course("Fundamentos ASP .NET", "fundamentos .NET");

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(2, "aprenda OOP", "", courseOOP);
            var careerItem2 = new CareerItem(1, "Começe poor aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "aprenda .NET", "", courseAspNet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }

                    var payPalSubscription = new PayPalSubscription();
                    var student = new Student();

                    student.CreateSubscription(payPalSubscription);

                }
            }
        }



    }
}