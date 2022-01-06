using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CSh_Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\fqyeh\\source\\repos\\CSh_Lab_12\\Source.txt";
            using (StreamReader file = new StreamReader(path))
            {
                List<Films> ListOfFilms = new List<Films>();
                string text = file.ReadToEnd();
                string[] films = text.Split('\n');

                foreach (string f in films)
                {
                    string[] words = f.Split(',');
                    ListOfFilms.Add(new Films(words[0], words[1], Convert.ToInt32(words[2])));
                }

                //Решение

                //Фильтрация
                var Movies = ListOfFilms.Where(film => film.Director == " Сергей Бондарчук");
                foreach (Films film in Movies)
                {
                    Console.WriteLine(film.ToString());
                }
                Console.WriteLine();
                var Movies1 = ListOfFilms.Where(film => film.Director == " Леонид Гайдай");
                foreach (Films film in Movies1)
                {
                    Console.WriteLine(film.ToString());
                }
                Console.WriteLine();

                //Проекция
                var Movies2 = ListOfFilms.Select(film => new
                {
                    FN = film.Name,
                    Time = 2021 - film.ReleaseDate
                });
                foreach (var film in Movies2)
                {
                    Console.WriteLine(film.ToString());
                }
                Console.WriteLine();

                //Сортировка
                var Movies3 = ListOfFilms.OrderBy(film => film.Name).ThenBy(film => film.ReleaseDate);
                foreach (var film in Movies3)
                {
                    Console.WriteLine(film.ToString());
                }
                Console.WriteLine();

                //Группировка
                var Movies4 = ListOfFilms.GroupBy(film => film.Director);
                foreach (var group in Movies4)
                {
                    foreach (var film in group)
                    {
                        Console.WriteLine(film.ToString());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //Агрегатные функции
                var Movies5 = ListOfFilms.Count(film => film.ReleaseDate == 1977);
                Console.WriteLine(Movies5);

                //Skip, Take, SkipWhile, TakeWhile
                foreach (var film in ListOfFilms.TakeWhile(film => film.ReleaseDate > 1990))
                {
                    Console.WriteLine(film.ToString());
                }
                Console.WriteLine();

                //All и Any
                bool Movies7 = ListOfFilms.Any(film => film.ReleaseDate == 2021);
                if (Movies7)
                    Console.WriteLine("Все фильмы вышли в этом году");
                else
                    Console.WriteLine("Не все фильмы вышли в этом году");
            }
        }
    }
}

