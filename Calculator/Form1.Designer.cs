namespace Calculator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.BotPanel = new System.Windows.Forms.Panel();
            this.Divide = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.BotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TextBox.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBox.Location = new System.Drawing.Point(0, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(400, 75);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // BotPanel
            // 
            this.BotPanel.Controls.Add(this.Divide);
            this.BotPanel.Controls.Add(this.Delete);
            this.BotPanel.Controls.Add(this.PlusMinus);
            this.BotPanel.Controls.Add(this.Button0);
            this.BotPanel.Controls.Add(this.Multiply);
            this.BotPanel.Controls.Add(this.Button9);
            this.BotPanel.Controls.Add(this.Button8);
            this.BotPanel.Controls.Add(this.Button7);
            this.BotPanel.Controls.Add(this.Minus);
            this.BotPanel.Controls.Add(this.Button6);
            this.BotPanel.Controls.Add(this.Button5);
            this.BotPanel.Controls.Add(this.Button4);
            this.BotPanel.Controls.Add(this.Equals);
            this.BotPanel.Controls.Add(this.Plus);
            this.BotPanel.Controls.Add(this.Button3);
            this.BotPanel.Controls.Add(this.Button2);
            this.BotPanel.Controls.Add(this.Button1);
            this.BotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotPanel.Location = new System.Drawing.Point(0, 100);
            this.BotPanel.Name = "BotPanel";
            this.BotPanel.Size = new System.Drawing.Size(400, 370);
            this.BotPanel.TabIndex = 2;
            this.BotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Divide.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Divide.Location = new System.Drawing.Point(240, 279);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(73, 86);
            this.Divide.TabIndex = 16;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Delete.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.Color.DarkOrange;
            this.Delete.Location = new System.Drawing.Point(161, 279);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(73, 86);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "C";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PlusMinus.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusMinus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlusMinus.Location = new System.Drawing.Point(82, 279);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(73, 86);
            this.PlusMinus.TabIndex = 14;
            this.PlusMinus.Text = "+/-";
            this.PlusMinus.UseVisualStyleBackColor = false;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button0.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button0.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button0.Location = new System.Drawing.Point(3, 279);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(73, 86);
            this.Button0.TabIndex = 13;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Multiply.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiply.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Multiply.Location = new System.Drawing.Point(240, 187);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(73, 86);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button9.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button9.Location = new System.Drawing.Point(161, 187);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(73, 86);
            this.Button9.TabIndex = 11;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button8.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button8.Location = new System.Drawing.Point(82, 187);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(73, 86);
            this.Button8.TabIndex = 10;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button7.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button7.Location = new System.Drawing.Point(3, 187);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(73, 86);
            this.Button7.TabIndex = 9;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Minus.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Minus.Location = new System.Drawing.Point(240, 95);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(73, 86);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button6.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button6.Location = new System.Drawing.Point(161, 95);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(73, 86);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button5.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button5.Location = new System.Drawing.Point(82, 95);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(73, 86);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button4.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button4.Location = new System.Drawing.Point(3, 95);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(73, 86);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Equals.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equals.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Equals.Location = new System.Drawing.Point(319, 3);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(73, 364);
            this.Equals.TabIndex = 4;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Plus.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Plus.Location = new System.Drawing.Point(240, 3);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(73, 86);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button3.Location = new System.Drawing.Point(161, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(73, 86);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button2.Location = new System.Drawing.Point(82, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(73, 86);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button1.Location = new System.Drawing.Point(3, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(73, 86);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(400, 470);
            this.Controls.Add(this.BotPanel);
            this.Controls.Add(this.TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.BotPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox;
        private Panel BotPanel;
        private Button Divide;
        private Button Delete;
        private Button PlusMinus;
        private Button Button0;
        private Button Multiply;
        private Button Button9;
        private Button Button8;
        private Button Button7;
        private Button Minus;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button Equals;
        private Button Plus;
        private Button Button3;
        private Button Button2;
        private Button Button1;
    }
}