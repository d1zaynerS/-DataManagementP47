using DataManagementP47.Ado;

Console.WriteLine("Запуск процесса создания таблиц...");

var ado = new Ado();
await ado.Run();

Console.WriteLine("\nГотово! Нажми любую клавишу, чтобы выйти.");
Console.ReadKey();
