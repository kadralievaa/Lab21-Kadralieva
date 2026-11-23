using System.Collections.Generic;

//1
Console.Write("Сколько задач добавить сначала: ");
int count = Convert.ToInt32(Console.ReadLine());

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string title = Console.ReadLine() ?? "";
    tasks.Add(title);
}

Console.WriteLine("\nИсходный список:");
PrintTasks(tasks);

//2
Console.Write("\nВведите новую задачу для добавления: ");
string newTask = Console.ReadLine() ?? "";
tasks.Add(newTask);
Console.WriteLine("Задача добавлена");

//3
Console.Write("Введите задачу для вставки: ");
string insertTask = Console.ReadLine() ?? "";
Console.Write("Введите индекс для вставки: ");
int insertIndex = Convert.ToInt32(Console.ReadLine());

if (InsertTaskSafe(tasks, insertIndex, insertTask))
{
    Console.WriteLine("Задача вставлена");
}
else
{
    Console.WriteLine("Недопустимый индекс вставки");
}

//4
Console.Write("\nВведите название задачи для удаления: ");
string removeName = Console.ReadLine() ?? "";
if (tasks.Remove(removeName))
{
    Console.WriteLine("Первое совпадение удалено");
}
else
{
    Console.WriteLine("Задача не найдена");
}

//5
Console.Write("Введите индекс задачи для удаления: ");
int removeIndex = Convert.ToInt32(Console.ReadLine());
if (RemoveTaskAtSafe(tasks, removeIndex))
{
    Console.WriteLine("Задача по индексу удалена");
}
else
{
    Console.WriteLine("Недопустимый индекс удаления");
}

//6
Console.Write("\nВведите название задачи для поиска: ");
string searchName = Console.ReadLine() ?? "";
int foundIndex = tasks.IndexOf(searchName);

if (foundIndex != -1)
{
    Console.WriteLine($"Первый индекс: {foundIndex}");
}
else
{
    Console.WriteLine("Задача не найдена");
}

//7
Console.WriteLine("\n>>> Итоговый список дел <<<");
Console.WriteLine($"\nКоличество задач: {tasks.Count}");
PrintTasks(tasks);


//методы
void PrintTasks(List<string> list)
{
    if (list.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i}: {list[i]}");
    }
}

bool InsertTaskSafe(List<string> list, int index, string title)
{
    if (index < 0 || index > list.Count)
    {
        return false;
    }
    list.Insert(index, title);
    return true;
}

bool RemoveTaskAtSafe(List<string> list, int index)
{
    if (index < 0 || index >= list.Count)
    {
        return false;
    }
    list.RemoveAt(index);
    return true;
}