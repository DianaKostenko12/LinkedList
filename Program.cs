using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static List<string> question = new List<string>
        {
            "Якi механiзми забезпечують рух тектонiчних плит на Землi?",
            "Якi види дiабету iснують i якi їх симптоми?",
            "Якi фактори впливають на здоров'я людини в мiських умовах?",
            "Якi хiмiчнi елементи складають атмосферу Землi i який вплив вони мають на клiмат?",
            "Якi основнi принципи дiї сонячних батарей i як вони перетворюють сонячну енергiю на електрику?",
            "Якi види забруднення повiтря i якi наслiдки вони можуть мати для здоров'я людини?",
            "Якi механiзми виникнення торнадо i якi наслiдки вони можуть мати для людей та природи?",
            "Якi фактори впливають на вибiр конкретної стратегiї управлiння проектом?",
            "Якi способи зберiгання та обробки даних використовуються в машинному навчаннi?",
            "Якi етапи складають процес розробки програмного забезпечення i " +
            "якi методологiї можна використовувати для його органiзацiї?",
        };

        static List<string> task = new List<string>
        {
            "Напишіть програму на Python, яка знаходить середнє арифметичне " +
            "довільної кількості чисел, введених користувачем з клавіатури.",
            "Створіть веб-сайт з використанням HTML та CSS, який містить заголовок," +
            " меню з трьома пунктами, фото та текстовий блок з описом.",
            "Розробіть базу даних на SQL для зберігання інформації " +
            "про користувачів веб-сайту, що містить ім'я, прізвище, електронну пошту та пароль.",
            "Розробіть алгоритм на мові програмування Python для сортування масиву чисел методом бульбашки",
            "Реалізуйте алгоритм на мові програмування C++, який знаходить найбільший спільний дільник двох чисел.",
        };
        static void Main(string[] args)
        {
            LinkedList<Student> exam = new LinkedList<Student>(new List<Student>()
            {
                new Student("Iван", "Петров", 1, " ", " "),
                new Student("Мар'яна", "Василенко", 2, " ", " "),
                new Student("Петро", "Iванов", 3, " ", " "),
                new Student("Василь", "Шашенко", 4, " ", " "),
                new Student("Григорiй", "Андрiєнко", 5, " ", " "),
                new Student("Катерина", "Гнатенко", 6, " ", " "),
                new Student("Анна", "Пилипенко", 7, " ", " ")
            });

            Console.WriteLine("Студенти, що складають iспит:");

            foreach (Student student in exam)
            {
                Console.WriteLine($"Студент {student.Name} {student.Surname}, номер залiковки: {student.StudentId}");
            }

            Console.WriteLine("Теоретичнi завдання - 1 \nПрактичнi завдання - 2");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                TheoryExamResult(exam);
            }
            else
            {
                PracticalTasksResult(exam);
            }
        }

        static void TheoryExamResult(LinkedList<Student> exam)
        {
            var questionfromprevstudent = GetRandomQuestion(question);
            foreach (var student in exam)
            {
                List<string> questions = new List<string>()
                {
                    GetRandomQuestion(question),
                    GetRandomQuestion(question),
                    questionfromprevstudent,
                };

                Console.WriteLine("\nТеоретичнi запитання для цього студента: ");

                foreach (var item in questions)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Студент склав екзамен? +/-");
                student.TheoryExamResult = Console.ReadLine();

                questionfromprevstudent = questions[new Random().Next(0, questions.Count)];

                Console.WriteLine($"Студент {student.Name} {student.Surname}, " +
                    $"номер залiковки: {student.StudentId}, теоретичнi запитання:{student.TheoryExamResult}");

                Console.ReadKey();
                Console.Clear();
            }
                
        }
        static void PracticalTasksResult(LinkedList<Student> exam)
        {
            var taskfromprevstudent = GetRandomTask(task);

            foreach(var student in exam)
            {
                List<string> tasks = new List<string>()
                {
                    GetRandomTask(task),
                    GetRandomTask(task),
                    taskfromprevstudent,
                };

                Console.WriteLine("\nПрактичнi завдання для цього студента: ");
                foreach (var item in tasks)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Студент склав екзамен? +/-");
                student.PracticalTasksResult = Console.ReadLine();

                taskfromprevstudent = task[new Random().Next(0, task.Count)];

                Console.WriteLine($"Студент {student.Name} {student.Surname}, " +
                        $"номер залiковки: {student.StudentId}, практика:{student.PracticalTasksResult}");
            }

            Console.ReadKey();
            Console.Clear();
        }

        static string GetRandomQuestion(List<string> question)
        {
            Random random = new Random();
            int randomQuestion = random.Next(0, question.Count);

            return (question[randomQuestion]);
        }

        static string GetRandomTask(List<string> task)
        {
            Random random = new Random();
            int randomTask = random.Next(0, task.Count);

            return (task[randomTask]);
        }

    }
}
