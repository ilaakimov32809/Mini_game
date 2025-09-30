using System.Diagnostics.Metrics;

namespace Скандинавский_рогалик
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Вы просыпаетесь в комнате где находятся топоры и щиты викингов...");
            Console.Write("Вспомните свое свое имя: ");
            string name = Console.ReadLine();

            bool artifact1 = false;
            bool artifact2 = false;
            bool artifact3 = false;
            bool chestOpened = false;
            bool doorOpened = false;
            int ventAttemtCount = 0;

            while (!doorOpened)
            {
                Console.WriteLine($"\n{name},Вы осмотриваетесь вокруг. Доступные действия:");
                Console.WriteLine("1) Открыть дверь на которой странные руны");
                Console.WriteLine("2) Заглянуть под старинную кровать");
                Console.WriteLine("3) Открыть большой сияющий от странной магии сундук");
                Console.WriteLine("4) Попытаться дотянуться до странного предмета на верхней полке огромного шкафа");
                Console.WriteLine("5) Осмотреть маленький сундук");
                Console.WriteLine("6) Осмотреть древнюю статую великого скандинавского божества тора");

                Console.Write("Вы выбираете: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (chestOpened)
                        {
                            Console.WriteLine($"\n{name}, Вы используете странный сияющий от молний ключ и открываете дверь. Поздравляем вы выбрались из комнаты тора!!!");
                            doorOpened = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n{name}, Дверь заперта. Кажется нужен ключ. Надо осмотреться внимательнее.");
                        }
                        break;

                    case "2":
                        if (!artifact1)
                        {
                            Console.WriteLine($"\n{name}, Под кроватью вы нашли первый рунный камень!");
                            artifact1 = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n{name}, Под кроватью больше нет ничего полезного кроме таинственного молота.");
                        }
                        break;

                    case "3":
                        if (!chestOpened)
                        {
                            if (artifact1 && artifact2 && artifact3)
                            {
                                Console.WriteLine($"\n{name}, Статую великого божества была активирована рунными камнями. Сундук открывается и в нем лежит ключ!");
                                chestOpened = true;
                            }
                            else
                            {
                                Console.WriteLine($"\n{name}, Сундук заперт. Кажется нужно активировать статую великого божества.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\n{name}, Сундук уже открыт. Вы вглядываетесь и откапываете в углу сундука шлема могучего тора.");
                        }
                        break;

                    case "4":
                        if (ventAttemtCount < 2)
                        {
                            ventAttemtCount++;
                            Console.WriteLine($"\n{name}, Вы пытаетесь допрыгнуть до странного предмета. У вас не выходит. Хмм, может попробовать еще раз.");
                        }
                        else if (ventAttemtCount == 2 && !artifact2)
                        {
                            ventAttemtCount++; 
                            artifact2 = true;
                            Console.WriteLine($"\n{name}, Вы наконец  допрыгиваете и находите еще один рунный камень!");
                        }
                        else
                        {
                            Console.WriteLine($"\n{name}, Вы решаете прыгнуть еще раз но не находите ничего полезного кроме части брони Тора");
                        }
                        break;

                    case "5":
                        if (!artifact3)
                        {
                            Console.WriteLine($"\n{name}, Вы октрываете маленький сундук и находите третий рунный камень!");
                            artifact3 = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n{name}, Сундук пуст. Вы вглядываетесь и замечаете маленький светлый волос пропитаный силой молний.");
                        }
                        break;

                    case "6":
                        if (artifact1 && artifact2 && artifact3)
                        {
                            Console.WriteLine($"\n{name}, Вы активируете статую великого скандинавского божества тора при помощи трех рунных камней!");
                        }
                        else
                        {
                            Console.WriteLine($"\n{name}, Статую не реагирует. Кажется нужно вставить рунные камни.");
                        }
                        break;

                    default:
                        Console.WriteLine($"\n{name}, Неизвестный символ. Попробуйте другой.");
                        break;
                }
            }
        }
    }
}
