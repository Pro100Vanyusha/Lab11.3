using System;

namespace Lab11._3
{
    class Program
    {
        class RandomDateTime
        {
            DateTime start;
            Random gen;
            int range;

            public RandomDateTime()
            {
                start = new DateTime(2015, 1, 1);
                gen = new Random();
                range = (DateTime.Today - start).Days;
            }

            public DateTime Next()
            {

                return start.AddDays(gen.Next(range));
            }
        }


        class Date
        {


            static void Main(string[] args)
            {
                RandomDateTime date = new RandomDateTime();
                Console.WriteLine("Дати : \n");

                List<int> termsList = new List<int>();
                List<DateTime> list = new List<DateTime>();

                for (int i = 0; i < 3; i++)
                {


                    DateTime dt = date.Next();

                    termsList.Add(dt.Year);


                    list.Add(new DateTime(dt.Year, dt.Month, dt.Day));

                    Console.WriteLine(dt);

                    Console.WriteLine("Рiк : " + dt.Year);
                    Console.WriteLine("Мiсяць : " + dt.Month);
                    Console.WriteLine("День : " + dt.Day);
                    Console.WriteLine("----------------------------");



                }
                List<DateTime> SpringDates = new List<DateTime>();
                string sdate = "";
                for (int i = 0; i < 3; i++)
                {
                    if (list[i].Month == 3 || list[i].Month == 4 || list[i].Month == 5)
                    {
                        SpringDates.Add(list[i]);
                    }

                }
                var len = SpringDates.Count();
                if (len == 0) { sdate = "Немає у списку"; }
                else
                {
                    sdate = SpringDates[0].ToString();
                }
                int[] terms = termsList.ToArray();
                DateTime biggestDate = list.Max(p => p);

                Console.WriteLine("Рiк з найменшим номером : " + terms.Min());
                Console.WriteLine("Сама пiздня дата : " + biggestDate);
                Console.WriteLine("Весняна дата : " + sdate);
            }
        }
    }
