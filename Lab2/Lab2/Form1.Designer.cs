using System;
using System.Windows.Forms;
using Lab2;
namespace WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnMyClass;
        private Button btnStaticExample;
        private Button btnPoint;
        private Button btnStructInitialization;

        private void InitializeComponent()
        {
            this.btnMyClass = new System.Windows.Forms.Button();
            this.btnStaticExample = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnStructInitialization = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnMyClass
            // 
            this.btnMyClass.Location = new System.Drawing.Point(13, 13);
            this.btnMyClass.Name = "btnMyClass";
            this.btnMyClass.Size = new System.Drawing.Size(170, 30);
            this.btnMyClass.TabIndex = 0;
            this.btnMyClass.Text = "MyClass Constructor";
            this.btnMyClass.UseVisualStyleBackColor = true;
            this.btnMyClass.Click += new System.EventHandler(this.btnMyClass_Click);

            // 
            // btnStaticExample
            // 
            this.btnStaticExample.Location = new System.Drawing.Point(13, 50);
            this.btnStaticExample.Name = "btnStaticExample";
            this.btnStaticExample.Size = new System.Drawing.Size(170, 30);
            this.btnStaticExample.TabIndex = 1;
            this.btnStaticExample.Text = "Static Example";
            this.btnStaticExample.UseVisualStyleBackColor = true;
            this.btnStaticExample.Click += new System.EventHandler(this.btnStaticExample_Click);

            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(13, 87);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(170, 30);
            this.btnPoint.TabIndex = 2;
            this.btnPoint.Text = "Point Structure";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);

            // 
            // btnStructInitialization
            // 
            this.btnStructInitialization.Location = new System.Drawing.Point(13, 124);
            this.btnStructInitialization.Name = "btnStructInitialization";
            this.btnStructInitialization.Size = new System.Drawing.Size(170, 30);
            this.btnStructInitialization.TabIndex = 3;
            this.btnStructInitialization.Text = "Struct Initialization";
            this.btnStructInitialization.UseVisualStyleBackColor = true;
            this.btnStructInitialization.Click += new System.EventHandler(this.btnStructInitialization_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnStructInitialization);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnStaticExample);
            this.Controls.Add(this.btnMyClass);
            this.Name = "Form1";
            this.Text = "Windows Forms Application";
            this.ResumeLayout(false);
        }
    }
}
