using classes;
var studentList = new List<Student>();
string? stop = null;

while (true)
{
    if (stop == "Quit" || stop == "quit")///условие для закрытия программы
    {
        break;
    }

    var student = new Student();///создание объекта студента

    Console.WriteLine("Please enter student name");
    student.Name = Console.ReadLine();///заполнение имени студента
    Console.WriteLine("Please enter student grade");
    student.Grade = Convert.ToInt32(Console.ReadLine());///заполнение класса студента 


    Console.WriteLine("Please enter number of student test scores");
    student.ListSize = Convert.ToInt32(Console.ReadLine());///заполнение количества оценок студента
    for (int i = 0; i < student.ListSize; i++)
    {
        Console.WriteLine("Please enter student test score");
        student.TestScores.Add(Convert.ToInt32(Console.ReadLine())); //заполнение оценок студента
    }

    studentList.Add(student);

    Console.Write($"{Environment.NewLine}Write 'Quit' or 'quit' - to exit program: ");
    stop = Console.ReadLine();///остановление программы при вызывании правильного ключа
}

foreach (var user in studentList)
{
    Console.WriteLine(user.GetPersonalizedMessage());
}