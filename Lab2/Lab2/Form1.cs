using System;
using System.Windows.Forms;

using Lab2;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMyClass_Click(object sender, EventArgs e)
        {
            // Использование конструктора класса
            MyClass myObject = new MyClass(5, 10);
            myObject.ShowCoordinates();
        }

        private void btnStaticExample_Click(object sender, EventArgs e)
        {
            // Использование статического конструктора и поля
            StaticExample.ShowCount();
            StaticExample.IncrementCount();
            StaticExample.ShowCount();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            // Использование структуры
            Point p = new Point(3, 4);
            p.ShowPoint();
        }

        private void btnStructInitialization_Click(object sender, EventArgs e)
        {
            // Инициализация структуры через конструктор и без
            StructInitialization initializer = new StructInitialization();
            initializer.InitializeStructure();
        }
    }
}
