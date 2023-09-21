using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект Timer
        System.Timers.Timer timer = new System.Timers.Timer();

        // Устанавливаем интервал в 1 секунду (1000 миллисекунд)
        timer.Interval = 1000;

        // Устанавливаем количество повторений таймера на 10
        int count = 10;

        // Подписываемся на событие Elapsed
        timer.Elapsed += (sender, e) =>
        {
            // Открыть блокнот
            Process.Start("notepad.exe");

            // Уменьшить счетчик
            count--;

            // Проверить, достигнут ли счетчик 0
            if (count == 0)
            {
                // Остановить таймер
                timer.Stop();
            }
        };

        // Запускаем таймер
        timer.Start();

        // Ждем, пока таймер не закончит свою работу
        while (count > 0)
        {
            // Ждем
            Thread.Sleep(1000);
        }
    }
}