using System.Collections.Generic;

// 2. Список и массив
List<string> tasks = new List<string>();
Console.WriteLine(tasks.Count); // Выведет 0

tasks = new List<string> { "Код", "Тест", "Код" };

// 3
tasks.Add("Отчёт");
tasks.Insert(1, "План");

// 4
Console.WriteLine(tasks[0]);
Console.WriteLine(tasks[tasks.Count - 1]);

List<string> editableTasks = new List<string> { "Черновик" };
editableTasks[0] = "Готово";
Console.WriteLine(editableTasks[0]);
Console.WriteLine(editableTasks.Count);

Console.WriteLine("\nВывод через метод:");
PrintTasks(tasks);

void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}

// 5. Удаление
List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

bool removed = removedTasks.Remove("Код");
Console.WriteLine(removed);
PrintTasks(removedTasks);

Console.WriteLine(removedTasks.Remove("Экзамен"));
Console.WriteLine(removedTasks.Count);

removedTasks.RemoveAt(1);
PrintTasks(removedTasks);

bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}

bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}