namespace NP_PW_6
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel_Info = new ToolStripLabel();
            panel_Controls = new Panel();
            textBox_Password = new TextBox();
            textBox_Port = new TextBox();
            textBox_Mail_Adress = new TextBox();
            textBox_Host = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button_SendMail = new Button();
            button_Open = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_Message = new TextBox();
            textBox_Theme = new TextBox();
            textBox_Adressat = new TextBox();
            label1 = new Label();
            listBox_Attachments = new ListBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel_Controls.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Maroon;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(884, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.RosyBrown;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Maroon;
            exitToolStripMenuItem.ForeColor = Color.RosyBrown;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.ForeColor = Color.RosyBrown;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightCoral;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel_Info });
            toolStrip1.Location = new Point(0, 378);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_Info
            // 
            toolStripLabel_Info.Name = "toolStripLabel_Info";
            toolStripLabel_Info.Size = new Size(59, 22);
            toolStripLabel_Info.Text = "Ready...";
            // 
            // panel_Controls
            // 
            panel_Controls.BackColor = Color.LightCoral;
            panel_Controls.Controls.Add(textBox_Password);
            panel_Controls.Controls.Add(textBox_Port);
            panel_Controls.Controls.Add(textBox_Mail_Adress);
            panel_Controls.Controls.Add(textBox_Host);
            panel_Controls.Controls.Add(label8);
            panel_Controls.Controls.Add(label7);
            panel_Controls.Controls.Add(label6);
            panel_Controls.Controls.Add(label5);
            panel_Controls.Dock = DockStyle.Top;
            panel_Controls.Location = new Point(0, 28);
            panel_Controls.Name = "panel_Controls";
            panel_Controls.Size = new Size(884, 89);
            panel_Controls.TabIndex = 2;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(549, 46);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(219, 27);
            textBox_Password.TabIndex = 7;
            // 
            // textBox_Port
            // 
            textBox_Port.Location = new Point(549, 8);
            textBox_Port.Name = "textBox_Port";
            textBox_Port.Size = new Size(219, 27);
            textBox_Port.TabIndex = 6;
            // 
            // textBox_Mail_Adress
            // 
            textBox_Mail_Adress.Location = new Point(148, 46);
            textBox_Mail_Adress.Name = "textBox_Mail_Adress";
            textBox_Mail_Adress.Size = new Size(219, 27);
            textBox_Mail_Adress.TabIndex = 5;
            // 
            // textBox_Host
            // 
            textBox_Host.Location = new Point(148, 8);
            textBox_Host.Name = "textBox_Host";
            textBox_Host.Size = new Size(219, 27);
            textBox_Host.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 53);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 3;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 15);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 2;
            label7.Text = "Port";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 1;
            label6.Text = "Mail Adress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 15);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 0;
            label5.Text = "Host";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(button_SendMail);
            panel1.Controls.Add(button_Open);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Message);
            panel1.Controls.Add(textBox_Theme);
            panel1.Controls.Add(textBox_Adressat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox_Attachments);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 261);
            panel1.TabIndex = 3;
            // 
            // button_SendMail
            // 
            button_SendMail.Location = new Point(674, 229);
            button_SendMail.Name = "button_SendMail";
            button_SendMail.Size = new Size(94, 29);
            button_SendMail.TabIndex = 8;
            button_SendMail.Text = "Send Mail";
            button_SendMail.UseVisualStyleBackColor = true;
            button_SendMail.Click += button_SendMail_Click;
            // 
            // button_Open
            // 
            button_Open.Location = new Point(778, 66);
            button_Open.Name = "button_Open";
            button_Open.Size = new Size(94, 29);
            button_Open.TabIndex = 7;
            button_Open.Text = "Open";
            button_Open.UseVisualStyleBackColor = true;
            button_Open.Click += button_Open_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(674, 75);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Файл/ы: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 75);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Письмо:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 46);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Тема: ";
            // 
            // textBox_Message
            // 
            textBox_Message.Location = new Point(101, 72);
            textBox_Message.Multiline = true;
            textBox_Message.Name = "textBox_Message";
            textBox_Message.Size = new Size(567, 186);
            textBox_Message.TabIndex = 3;
            // 
            // textBox_Theme
            // 
            textBox_Theme.Location = new Point(101, 39);
            textBox_Theme.Name = "textBox_Theme";
            textBox_Theme.Size = new Size(567, 27);
            textBox_Theme.TabIndex = 2;
            // 
            // textBox_Adressat
            // 
            textBox_Adressat.Location = new Point(101, 9);
            textBox_Adressat.Name = "textBox_Adressat";
            textBox_Adressat.Size = new Size(567, 27);
            textBox_Adressat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Адрессат:";
            // 
            // listBox_Attachments
            // 
            listBox_Attachments.FormattingEnabled = true;
            listBox_Attachments.Location = new Point(674, 101);
            listBox_Attachments.Name = "listBox_Attachments";
            listBox_Attachments.Size = new Size(198, 64);
            listBox_Attachments.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(884, 403);
            Controls.Add(panel1);
            Controls.Add(panel_Controls);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel_Controls.ResumeLayout(false);
            panel_Controls.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel_Info;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel_Controls;
        private Panel panel1;
        private TextBox textBox_Adressat;
        private Label label1;
        private Label label2;
        private TextBox textBox_Message;
        private TextBox textBox_Theme;
        private Button button_Open;
        private Label label4;
        private Label label3;
        private Button button_SendMail;
        private Label label6;
        private Label label5;
        private TextBox textBox_Password;
        private TextBox textBox_Port;
        private TextBox textBox_Mail_Adress;
        private TextBox textBox_Host;
        private Label label8;
        private Label label7;
        private ListBox listBox_Attachments;
    }
}
