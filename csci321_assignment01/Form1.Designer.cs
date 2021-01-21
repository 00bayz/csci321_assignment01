
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
            this.StaticBox = new System.Windows.Forms.GroupBox();
            this.DynamicBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // StaticBox
            // 
            this.StaticBox.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticBox.ForeColor = System.Drawing.Color.Cyan;
            this.StaticBox.Location = new System.Drawing.Point(12, 12);
            this.StaticBox.Name = "StaticBox";
            this.StaticBox.Size = new System.Drawing.Size(300, 391);
            this.StaticBox.TabIndex = 0;
            this.StaticBox.TabStop = false;
            this.StaticBox.Text = "Static Elements";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StaticBox;
        private System.Windows.Forms.GroupBox DynamicBox;
    }
}

