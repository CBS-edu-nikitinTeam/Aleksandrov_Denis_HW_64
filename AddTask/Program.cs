using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/*    Задание
   Создайте форму регистрации на консультацию. В форме должны быть поля:
   Имя Фамилия
   Email
   Желаемая дата консультации   Все поля обязательные для ввода. Email должен быть в соответствующем формате. Дата 
   консультации должна быть правильной датой, она должна быть в будущем и не должна 
   попадать на выходные дни.
   При наличии ошибок, необходимо оповестить пользователя об ошибках.      Задание 1
   Для формы из предыдущего задания добавьте валидацию на стороне клиента.
      
      Задание 2
   Для формы из предыдущего задания добавьте выпадающий список, в котором можно будет 
   указать продукт, по которому клиент хочет получить консультацию. Значения: JavaScript, C#, Java, 
   Python, Основы. При этом консультация по продукту «Основы» не может проходить по 
   понедельникам, соответствующая ошибка должна выводиться в пользовательском интерфейсе.*/

namespace AddTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
