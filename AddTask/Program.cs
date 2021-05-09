using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/*    �������
   �������� ����� ����������� �� ������������. � ����� ������ ���� ����:
   ��� �������
   Email
   �������� ���� ������������   ��� ���� ������������ ��� �����. Email ������ ���� � ��������������� �������. ���� 
   ������������ ������ ���� ���������� �����, ��� ������ ���� � ������� � �� ������ 
   �������� �� �������� ���.
   ��� ������� ������, ���������� ���������� ������������ �� �������.      ������� 1
   ��� ����� �� ����������� ������� �������� ��������� �� ������� �������.
      
      ������� 2
   ��� ����� �� ����������� ������� �������� ���������� ������, � ������� ����� ����� 
   ������� �������, �� �������� ������ ����� �������� ������������. ��������: JavaScript, C#, Java, 
   Python, ������. ��� ���� ������������ �� �������� �������� �� ����� ��������� �� 
   �������������, ��������������� ������ ������ ���������� � ���������������� ����������.*/

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
