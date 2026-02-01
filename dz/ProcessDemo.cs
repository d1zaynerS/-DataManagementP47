using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq; // Добавил для OrderBy, который был в твоем файле

namespace SystemProgrammingP47
{
    internal class ProcessDemo
    {
        // ТВОЙ КОД: Поле для процесса
        private Process? notepadProcess;

        public void Run()
        {
            Console.WriteLine("Process Demo");

            // ТВОЙ КОД: Чтение demo.txt (убедись, что файл есть в папке)
            if (File.Exists("demo.txt"))
            {
                Console.WriteLine(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "demo.txt")));
            }

            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("\n1 - Show processes");
                Console.WriteLine("2 - Start notepad");
                Console.WriteLine("3 - Close notepad");
                Console.WriteLine("4 - Edit demo.txt");
                // ДОПИСАНО ПО ДЗ:
                Console.WriteLine("5 - Open itstep.org");
                Console.WriteLine("6 - Save processes to file and open");

                Console.WriteLine("0 - Exit");
                keyInfo = Console.ReadKey();
                Console.WriteLine();
                switch (keyInfo.KeyChar)
                {
                    case '1': ShowProcesses(); break;
                    case '2': StartNotepad(); break;
                    case '3': CloseNotepad(); break;
                    case '4': EditDemo(); break; // Твой метод запуска demo.txt
                    // ДОПИСАНО ПО ДЗ:
                    case '5': OpenItStep(); break;
                    case '6': SaveAndOpenProcesses(); break;
                    case '0': break;
                    default: Console.WriteLine("Wrong choice"); break;
                }
            }
            while (keyInfo.KeyChar != '0');
        }

        // ТВОЙ КОД (Дописал Kill, чтобы работал пункт 3):
        private void CloseNotepad()
        {
            if (notepadProcess != null && !notepadProcess.HasExited)
            {
                notepadProcess.Kill();
                Console.WriteLine("Notepad closed");
            }
        }

        // ТВОЙ КОД:
        private void StartNotepad()
        {
            notepadProcess = Process.Start("notepad.exe");
        }

        // ТВОЙ КОД (был в switch, вынес в метод для порядка):
        private void EditDemo()
        {
            Process.Start("notepad.exe", "demo.txt");
        }

        // ДОПИСАНО ПО ДЗ (Пункт 5):
        private void OpenItStep()
        {
            Process.Start(new ProcessStartInfo("https://itstep.org") { UseShellExecute = true });
        }

        // ДОПИСАНО ПО ДЗ (Пункт 6):
        private void SaveAndOpenProcesses()
        {
            // Используем уникальное имя файла
            string fileName = $"processes_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            // Собираем данные (используем твою логику из ShowProcesses)
            Process[] processes = Process.GetProcesses();
            StringBuilder sb = new StringBuilder();
            foreach (var p in processes)
            {
                try { sb.AppendLine($"{p.ProcessName} (ID: {p.Id})"); }
                catch { }
            }

            // Записываем и открываем (как ты учил в теме File и Process)
            File.WriteAllText(fileName, sb.ToString());
            Process.Start("notepad.exe", fileName);
        }

        // ТВОЙ КОД (полностью без изменений):
        private void ShowProcesses()
        {
            Process[] processes = Process.GetProcesses();
            Dictionary<String, int> taskManager = [];

            foreach (Process process in processes)
            {
                String name;
                try { name = process.ProcessName; }
                catch { name = "Restrited"; }

                if (taskManager.ContainsKey(name)) taskManager[name] += 1;
                else taskManager[name] = 1;
            }
            foreach (var pair in taskManager.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{pair.Key} ({pair.Value})");
            }
        }
    }
}