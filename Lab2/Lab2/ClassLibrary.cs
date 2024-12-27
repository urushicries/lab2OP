using System;
using System.Windows.Forms;
using Lab2;
namespace WindowsFormsApp
{
    // Класс с перегрузкой конструкторов
    public class MyClass
    {
        private int x;
        private int y;

        // Конструктор по умолчанию
        public MyClass()
        {
            x = 0;
            y = 0;
        }

        // Перегруженный конструктор
        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowCoordinates()
        {
            MessageBox.Show($"x = {x}, y = {y}");
        }
    }

    // Класс с статическим полем и статическим конструктором
    public class StaticExample
    {
        public static int count = 0;

        
        static StaticExample()
        {
            count = 10;
        }

        public static void IncrementCount()
        {
            count++;
        }

        public static void ShowCount()
        {
            MessageBox.Show($"Count = {count}");
        }
    }

    // Структура Point
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ShowPoint()
        {
            MessageBox.Show($"Point: ({X}, {Y})");
        }
    }

    // Класс для инициализации структуры
    public class StructInitialization
    {
        public void InitializeStructure()
        {
            // Инициализация структуры через конструктор
            Point point1 = new Point(5, 10);
            point1.ShowPoint();

            // Инициализация структуры без конструктора
            Point point2;
            point2.X = 7;
            point2.Y = 12;
            point2.ShowPoint();
        }
    }
}
