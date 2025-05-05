using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pehtok30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует помощник Peh, по переходу на сайты. Ниже представлен список: ");

            Console.WriteLine("\n1. Telegramm");
            Console.WriteLine("2. VK");
            Console.WriteLine("3. Одноклассники");
            Console.WriteLine("4. Instagramm");
            Console.WriteLine("5. Steam");
            Console.WriteLine("6. GitHub");
            Console.WriteLine("7. Авито");
            Console.WriteLine("8. Ozon");
            Console.WriteLine("9. Wildberries");
            Console.WriteLine("10. YouTube");

            Console.WriteLine("\nВыберите, что вас интересует: ");

            string sao;
            sao = Console.ReadLine();

            if (sao == "1")
            {
                Process.Start("https://web.telegram.org/k");
            }

            if (sao == "2")
            {
                Process.Start("https://vk.com/feed");
            }

            if (sao == "3")
            {
                Process.Start("https://ok.ru");
            }

            if (sao == "4")
            {
                Process.Start("https://web-instagram.com/lander");
            } 

            if (sao == "5")
            {
                Process.Start("https://store.steampowered.com");
            } 

            if (sao == "6")
            {
                Process.Start("https://github.com");
            }

            if (sao == "7")
            {
                Process.Start("https://www.avito.ru");
            }

            if (sao == "8")
            {
                Process.Start("https://www.ozon.ru");
            }

            if (sao == "9")
            {
                Process.Start("https://www.wildberries.ru");
            }

            if (sao == "10")
            {

                Console.WriteLine("\nYouTube. Ниже представлен список Ютуберов: ");

                Console.WriteLine("\n1. MrBeast");
                Console.WriteLine("2. Marmok");
                Console.WriteLine("3. WWE");
                Console.WriteLine("4. Zee Music Company");
                Console.WriteLine("5. PewDiePie");
                Console.WriteLine("6. Sparkles");
                Console.WriteLine("7. Red Bull");
                Console.WriteLine("8. Mr Ben Brown");
                Console.WriteLine("9. Mei Yu");
                Console.WriteLine("10. Dream");
                Console.WriteLine("\nВыберите, кого хотите посмотреть: ");

                string number;
                number = Console.ReadLine();

                if (number == "1")
                {
                    Process.Start("https://www.youtube.com/@MrBeast");
                }

                if (number == "2")
                {
                    Process.Start("https://www.youtube.com/@MrMarmok");
                }

                if (number == "3")
                {
                    Process.Start("https://www.youtube.com/channel/UCJ5v_MCY6GNUBTO8-D3XoAg");
                }

                if (number == "4")
                {
                    Process.Start("https://www.youtube.com/channel/UCFFbwnve3yF62-tVXkTyHqg");
                }

                if (number == "5")
                {
                    Process.Start("https://www.youtube.com/channel/UC-lHJZR3Gqxm24_Vd_AJ5Yw");
                }

                if (number == "6")
                {
                    Process.Start("https://www.youtube.com/channel/UCs3GloeEzu5rDlQlSLGrr4A");
                }

                if (number == "7")
                {
                    Process.Start("https://www.youtube.com/channel/UCblfuW_4rakIf2h6aqANefA");
                }

                if (number == "8")
                {
                    Process.Start("https://www.youtube.com/playlist?list=PLGbKwS7MP10eYaIIE-B0s7VC8zSI0UZX_");
                }

                if (number == "9")
                {
                    Process.Start("https://www.youtube.com/c/meiyu/channels");
                }

                if (number == "10")
                {
                    Process.Start("https://www.youtube.com/channel/UCTkXRDQl0luXxVQrRQvWS6w");
                }
            }

        }
    }
}
