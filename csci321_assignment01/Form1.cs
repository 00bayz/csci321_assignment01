using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csci321_assignment01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(StaticBox.Location.X);
            Console.WriteLine(StaticBox.Location.Y);
            Console.WriteLine(DynamicBox.Location.X);
            Console.WriteLine(DynamicBox.Location.Y);
        }

        private void staticBtn1_Hover(object sender, EventArgs e)
        {
            if (staticBtn1.Text == "Static Button 1")
            {
                staticBtn1.Text = "TEXT CHANGED";
            }
            else
            {
                staticBtn1.Text = "Static Button 1";
            }
        }

        private void staticBtn1_Click(object sender, EventArgs e)
        {
            if (dynamicBtn == null)
            {
                dynamicBtn = new Button();
                dynamicBtn.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicBtn.BackColor = System.Drawing.SystemColors.ControlDark;
                dynamicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
                dynamicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                dynamicBtn.FlatAppearance.BorderSize = 1;
                dynamicBtn.ForeColor = System.Drawing.SystemColors.ControlText;
                dynamicBtn.Location = new System.Drawing.Point(324, 37);
                dynamicBtn.Name = "dynamicBtn";
                dynamicBtn.Size = new System.Drawing.Size(288, 77);
                dynamicBtn.TabIndex = 0;
                dynamicBtn.Text = "Dynamic Button";
                dynamicBtn.UseVisualStyleBackColor = false;
                dynamicBtn.Click += new System.EventHandler(this.dynamicBtn_Click);
                dynamicBtn.MouseHover += new System.EventHandler(this.dynamicBtn_Hover);
                Controls.Add(dynamicBtn);
                Controls.SetChildIndex(dynamicBtn, 0);
            }
            else
            {
                MessageBox.Show("Dynamic Button already created.", "Notification");
            }
        }

        private void dynamicBtn_Click(object sender, EventArgs e)
        {

        }

        private void dynamicBtn_Hover(object sender, EventArgs e)
        {
            
        }

        private Button dynamicBtn;
    }
}
