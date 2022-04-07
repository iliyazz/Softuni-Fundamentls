using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> couursePlan = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "course start")
            {
                string[] cmdArg = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string lessonTitle1 = string.Empty;
                string lessonTitle2 = string.Empty;
                int indexCmd = 0;
                switch (cmdArg[0])
                {
                    case "Add":
                        lessonTitle1 = cmdArg[1];
                        AddCmd(couursePlan, lessonTitle1);
                        break;

                    case "Insert":
                        lessonTitle1 = cmdArg[1];
                        indexCmd = int.Parse(cmdArg[2]);
                        InsertCmd(couursePlan, lessonTitle1, indexCmd);
                        break;

                    case "Remove":
                        lessonTitle1 = cmdArg[1];
                        RemoveCmd(couursePlan, lessonTitle1);
                        break;

                    case "Swap":
                        lessonTitle1 = cmdArg[1];
                        lessonTitle2 = cmdArg[2];
                        if (couursePlan.Contains(lessonTitle1) && couursePlan.Contains(lessonTitle2))
                        {
                            SwapCmd(couursePlan, lessonTitle1, lessonTitle2);
                        }
                        break;

                    case "Exercise":
                        lessonTitle1 = cmdArg[1];
                        ExerciseCmd(couursePlan, lessonTitle1);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();

            }
            int indexNumber = 0;
            foreach (var item in couursePlan)
            {
                indexNumber++;
                Console.WriteLine($"{indexNumber}.{item}");
            }
        }
        static void AddCmd(List<string> couursePlan, string lessonTitle1)
        {
            if (!couursePlan.Contains(lessonTitle1))
            {
                couursePlan.Add(lessonTitle1);
            }

        }
        static void InsertCmd(List<string> couursePlan, string lessonTitle1, int indexCmd)
        {
            if (!couursePlan.Contains(lessonTitle1))
            {
                couursePlan.Insert(indexCmd, lessonTitle1);
            }

        }
        static void RemoveCmd(List<string> couursePlan, string lessonTitle1)
        {
            if (couursePlan.Contains(lessonTitle1) && couursePlan.Contains($"{lessonTitle1}-Exercise"))
            {
                couursePlan.Remove(lessonTitle1);
                couursePlan.Remove($"{lessonTitle1}-Exercise");
            }
            else if (couursePlan.Contains(lessonTitle1))
            {
                couursePlan.Remove(lessonTitle1);
            }
        }
        static void SwapCmd(List<string> coursePlan, string lessonTitle1, string lessonTitle2)
        {
            int temporaryIndexLesson1 = coursePlan.IndexOf(lessonTitle1);
            int temporaryIndexLesson2 = coursePlan.IndexOf(lessonTitle2);
            if (coursePlan.Contains($"{lessonTitle1}-Exercise") && coursePlan.Contains($"{lessonTitle2}-Exercise"))
            {
                SwapTemp(coursePlan, temporaryIndexLesson1, temporaryIndexLesson2);
                SwapTemp(coursePlan, temporaryIndexLesson1, temporaryIndexLesson2);
            }
            else if(coursePlan.Contains($"{lessonTitle1}-Exercise"))
            {
                SwapTemp(coursePlan, temporaryIndexLesson1, temporaryIndexLesson2);
                if (temporaryIndexLesson1 < temporaryIndexLesson2)
                {
                    coursePlan.Insert(temporaryIndexLesson2 + 1, coursePlan[temporaryIndexLesson1 + 1]);
                    coursePlan.RemoveAt(temporaryIndexLesson1 + 1);
                }
                else
                {
                    coursePlan.Insert(temporaryIndexLesson2 + 1, coursePlan[temporaryIndexLesson1 + 1]);
                    coursePlan.RemoveAt(temporaryIndexLesson1 + 2);
                }
            }
            else if(coursePlan.Contains($"{lessonTitle2}-Exercise"))
            {
                SwapTemp(coursePlan, temporaryIndexLesson1, temporaryIndexLesson2);
                if (temporaryIndexLesson2 < temporaryIndexLesson1)
                {
                    coursePlan.Insert(temporaryIndexLesson1 + 1, coursePlan[temporaryIndexLesson2 + 1]);
                    coursePlan.RemoveAt(temporaryIndexLesson2 + 1);
                }
                else
                {
                    coursePlan.Insert(temporaryIndexLesson1 + 1, coursePlan[temporaryIndexLesson2 + 1]);
                    coursePlan.RemoveAt(temporaryIndexLesson2 + 2);
                }
            }
            else
            {
                SwapTemp(coursePlan, temporaryIndexLesson1, temporaryIndexLesson2);
            }




        }
        static void SwapTemp(List<string> coursePlan, int index1, int index2)
        {
            string temporaryString = string.Empty;
            temporaryString = coursePlan[index1];
            coursePlan[index1] = coursePlan[index2];
            coursePlan[index2] = temporaryString;
        }

        static void ExerciseCmd(List<string> couursePlan, string lessonTitle1)
        {
            if (!couursePlan.Contains($"{lessonTitle1}-Exercise"))
            {

                if (couursePlan.Contains(lessonTitle1))
                {
                    int indexOfLesson1 = couursePlan.IndexOf(lessonTitle1);
                    if (couursePlan.IndexOf(lessonTitle1) == couursePlan.Count - 1)
                    {
                        couursePlan.Add($"{lessonTitle1}-Exercise");
                    }
                    else
                    {
                        couursePlan.Insert(indexOfLesson1 + 1, $"{lessonTitle1}-Exercise");
                    }
                }
                else
                {
                    couursePlan.Add(lessonTitle1);
                    couursePlan.Add($"{lessonTitle1}-Exercise");

                }
            }
        }
    }
}
