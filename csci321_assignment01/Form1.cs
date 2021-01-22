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
                dynamicBtn.Cursor = System.Windows.Forms.Cursors.No;
                dynamicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                dynamicBtn.FlatAppearance.BorderSize = 1;
                dynamicBtn.ForeColor = System.Drawing.SystemColors.ControlText;
                dynamicBtn.Location = new System.Drawing.Point(6, 25);
                dynamicBtn.Name = "dynamicBtn";
                dynamicBtn.Size = new System.Drawing.Size(288, 77);
                dynamicBtn.TabIndex = 0;
                dynamicBtn.Text = "Dynamic Button";
                dynamicBtn.UseVisualStyleBackColor = false;
                dynamicBtn.Click += new System.EventHandler(this.dynamicBtn_Click);
                dynamicBtn.MouseHover += new System.EventHandler(this.dynamicBtn_Hover);
                DynamicBox.Controls.Add(dynamicBtn);
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
            if (dynamicBtn.Text == "Dynamic Button")
            {
                dynamicBtn.Text = "ANOTHER TEXT CHANGED";
            }
            else
            {
                dynamicBtn.Text = "Dynamic Button";
            }
        }

        private void staticTxtBox_TxtChange(object sender, EventArgs e)
        {
            MessageBox.Show(staticTxtBox.Text, "Text Changed");
        }

        private void staticBtn2_Click(object sender, EventArgs e)
        {
            if (dynamicTxtBox1 == null && dynamicTxtBox2 == null)
            {
                dynamicTxtBox1 = new TextBox();
                dynamicTxtBox1.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicTxtBox1.Location = new System.Drawing.Point(324, 300);
                dynamicTxtBox1.Name = "Dynamic Text Box 1";
                dynamicTxtBox1.Size = new System.Drawing.Size(288, 26);
                dynamicTxtBox1.TabIndex = 1;
                dynamicTxtBox1.TextChanged += new System.EventHandler(this.dynamicTxtBox_TxtChange);
                Controls.Add(dynamicTxtBox1);
                Controls.SetChildIndex(dynamicTxtBox1, 0);
                dynamicTxtBox2 = new TextBox();
                dynamicTxtBox2.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicTxtBox2.Location = new System.Drawing.Point(324, 340);
                dynamicTxtBox2.Name = "Dynamic Text Box 2";
                dynamicTxtBox2.Size = new System.Drawing.Size(288, 26);
                dynamicTxtBox2.TabIndex = 1;
                dynamicTxtBox2.TextChanged += new System.EventHandler(this.dynamicTxtBox_TxtChange);
                Controls.Add(dynamicTxtBox2);
                Controls.SetChildIndex(dynamicTxtBox2, 0);
            }
        }

        private void dynamicTxtBox_TxtChange(object sender, EventArgs e)
        {
            try
            {
                Control tmp = (Control)sender;
                MessageBox.Show(tmp.Text, tmp.Name);
            }
            catch(System.InvalidCastException err)
            {
                MessageBox.Show(err.Source);
                MessageBox.Show(err.Message);
            }
        }

        private Button dynamicBtn;
        private TextBox dynamicTxtBox1, dynamicTxtBox2;
    }
}
