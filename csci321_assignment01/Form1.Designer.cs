
namespace csci321_assignment01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DynamicBox = new System.Windows.Forms.GroupBox();
            this.staticBtn1 = new System.Windows.Forms.Button();
            this.StaticBox = new System.Windows.Forms.GroupBox();
            this.staticBtn2 = new System.Windows.Forms.Button();
            this.staticTxtBox = new System.Windows.Forms.TextBox();
            this.StaticBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DynamicBox
            // 
            this.DynamicBox.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DynamicBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.DynamicBox.Location = new System.Drawing.Point(318, 12);
            this.DynamicBox.Name = "DynamicBox";
            this.DynamicBox.Size = new System.Drawing.Size(300, 391);
            this.DynamicBox.TabIndex = 1;
            this.DynamicBox.TabStop = false;
            this.DynamicBox.Text = "Dynamic Elements";
            // 
            // staticBtn1
            // 
            this.staticBtn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.staticBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staticBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staticBtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.staticBtn1.Location = new System.Drawing.Point(6, 25);
            this.staticBtn1.Name = "staticBtn1";
            this.staticBtn1.Size = new System.Drawing.Size(288, 77);
            this.staticBtn1.TabIndex = 0;
            this.staticBtn1.Text = "Static Button 1";
            this.staticBtn1.UseVisualStyleBackColor = false;
            this.staticBtn1.Click += new System.EventHandler(this.staticBtn1_Click);
            this.staticBtn1.MouseHover += new System.EventHandler(this.staticBtn1_Hover);
            // 
            // StaticBox
            // 
            this.StaticBox.Controls.Add(this.staticBtn2);
            this.StaticBox.Controls.Add(this.staticTxtBox);
            this.StaticBox.Controls.Add(this.staticBtn1);
            this.StaticBox.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticBox.ForeColor = System.Drawing.Color.Cyan;
            this.StaticBox.Location = new System.Drawing.Point(12, 12);
            this.StaticBox.Name = "StaticBox";
            this.StaticBox.Size = new System.Drawing.Size(300, 391);
            this.StaticBox.TabIndex = 0;
            this.StaticBox.TabStop = false;
            this.StaticBox.Text = "Static Elements";
            // 
            // staticBtn2
            // 
            this.staticBtn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.staticBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staticBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staticBtn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.staticBtn2.Location = new System.Drawing.Point(6, 308);
            this.staticBtn2.Name = "staticBtn2";
            this.staticBtn2.Size = new System.Drawing.Size(288, 77);
            this.staticBtn2.TabIndex = 2;
            this.staticBtn2.Text = "Static Button 2";
            this.staticBtn2.UseVisualStyleBackColor = false;
            this.staticBtn2.Click += new System.EventHandler(this.staticBtn2_Click);
            // 
            // staticTxtBox
            // 
            this.staticTxtBox.Location = new System.Drawing.Point(6, 210);
            this.staticTxtBox.Name = "staticTxtBox";
            this.staticTxtBox.Size = new System.Drawing.Size(288, 26);
            this.staticTxtBox.TabIndex = 1;
            this.staticTxtBox.TextChanged += new System.EventHandler(this.staticTxtBox_TxtChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(933, 415);
            this.Controls.Add(this.DynamicBox);
            this.Controls.Add(this.StaticBox);
            this.Font = new System.Drawing.Font("Liberation Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "CSCI321 Assignment 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StaticBox.ResumeLayout(false);
            this.StaticBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DynamicBox;
        private System.Windows.Forms.Button staticBtn1;
        private System.Windows.Forms.GroupBox StaticBox;
        private System.Windows.Forms.TextBox staticTxtBox;
        private System.Windows.Forms.Button staticBtn2;
    }
}

