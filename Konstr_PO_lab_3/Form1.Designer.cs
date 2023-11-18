namespace Konstr_PO_lab_3
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            создатьСписокToolStripMenuItem = new ToolStripMenuItem();
            добавитьЭлементToolStripMenuItem = new ToolStripMenuItem();
            переборКнопокToolStripMenuItem = new ToolStripMenuItem();
            создатьЭнумераторToolStripMenuItem = new ToolStripMenuItem();
            moveNextToolStripMenuItem = new ToolStripMenuItem();
            currentToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            переборОбъектовToolStripMenuItem = new ToolStripMenuItem();
            создатьЭнумераторToolStripMenuItem1 = new ToolStripMenuItem();
            moveNextToolStripMenuItem1 = new ToolStripMenuItem();
            currentToolStripMenuItem1 = new ToolStripMenuItem();
            resetToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(78, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 294);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { создатьСписокToolStripMenuItem, добавитьЭлементToolStripMenuItem, переборКнопокToolStripMenuItem, переборОбъектовToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // создатьСписокToolStripMenuItem
            // 
            создатьСписокToolStripMenuItem.Name = "создатьСписокToolStripMenuItem";
            создатьСписокToolStripMenuItem.Size = new Size(104, 20);
            создатьСписокToolStripMenuItem.Text = "Создать список";
            создатьСписокToolStripMenuItem.Click += создатьСписокToolStripMenuItem_Click;
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            добавитьЭлементToolStripMenuItem.Size = new Size(120, 20);
            добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            добавитьЭлементToolStripMenuItem.Click += добавитьЭлементToolStripMenuItem_Click;
            // 
            // переборКнопокToolStripMenuItem
            // 
            переборКнопокToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьЭнумераторToolStripMenuItem, moveNextToolStripMenuItem, currentToolStripMenuItem, resetToolStripMenuItem });
            переборКнопокToolStripMenuItem.Name = "переборКнопокToolStripMenuItem";
            переборКнопокToolStripMenuItem.Size = new Size(111, 20);
            переборКнопокToolStripMenuItem.Text = "Перебор кнопок";
            // 
            // создатьЭнумераторToolStripMenuItem
            // 
            создатьЭнумераторToolStripMenuItem.Name = "создатьЭнумераторToolStripMenuItem";
            создатьЭнумераторToolStripMenuItem.Size = new Size(186, 22);
            создатьЭнумераторToolStripMenuItem.Text = "Создать энумератор";
            создатьЭнумераторToolStripMenuItem.Click += создатьЭнумераторToolStripMenuItem_Click;
            // 
            // moveNextToolStripMenuItem
            // 
            moveNextToolStripMenuItem.Checked = true;
            moveNextToolStripMenuItem.CheckState = CheckState.Checked;
            moveNextToolStripMenuItem.Name = "moveNextToolStripMenuItem";
            moveNextToolStripMenuItem.Size = new Size(186, 22);
            moveNextToolStripMenuItem.Text = "MoveNext";
            moveNextToolStripMenuItem.Click += moveNextToolStripMenuItem_Click;
            // 
            // currentToolStripMenuItem
            // 
            currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            currentToolStripMenuItem.Size = new Size(186, 22);
            currentToolStripMenuItem.Text = "Current";
            currentToolStripMenuItem.Click += currentToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(186, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // переборОбъектовToolStripMenuItem
            // 
            переборОбъектовToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьЭнумераторToolStripMenuItem1, moveNextToolStripMenuItem1, currentToolStripMenuItem1, resetToolStripMenuItem1 });
            переборОбъектовToolStripMenuItem.Name = "переборОбъектовToolStripMenuItem";
            переборОбъектовToolStripMenuItem.Size = new Size(122, 20);
            переборОбъектовToolStripMenuItem.Text = "Перебор объектов";
            // 
            // создатьЭнумераторToolStripMenuItem1
            // 
            создатьЭнумераторToolStripMenuItem1.Name = "создатьЭнумераторToolStripMenuItem1";
            создатьЭнумераторToolStripMenuItem1.Size = new Size(186, 22);
            создатьЭнумераторToolStripMenuItem1.Text = "Создать энумератор";
            создатьЭнумераторToolStripMenuItem1.Click += создатьЭнумераторToolStripMenuItem1_Click;
            // 
            // moveNextToolStripMenuItem1
            // 
            moveNextToolStripMenuItem1.Name = "moveNextToolStripMenuItem1";
            moveNextToolStripMenuItem1.Size = new Size(186, 22);
            moveNextToolStripMenuItem1.Text = "MoveNext";
            moveNextToolStripMenuItem1.Click += moveNextToolStripMenuItem1_Click;
            // 
            // currentToolStripMenuItem1
            // 
            currentToolStripMenuItem1.Name = "currentToolStripMenuItem1";
            currentToolStripMenuItem1.Size = new Size(186, 22);
            currentToolStripMenuItem1.Text = "Current";
            currentToolStripMenuItem1.Click += currentToolStripMenuItem1_Click;
            // 
            // resetToolStripMenuItem1
            // 
            resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            resetToolStripMenuItem1.Size = new Size(186, 22);
            resetToolStripMenuItem1.Text = "Reset";
            resetToolStripMenuItem1.Click += resetToolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem создатьСписокToolStripMenuItem;
        private ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private ToolStripMenuItem переборКнопокToolStripMenuItem;
        private ToolStripMenuItem переборОбъектовToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem создатьЭнумераторToolStripMenuItem;
        private ToolStripMenuItem moveNextToolStripMenuItem;
        private ToolStripMenuItem currentToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem создатьЭнумераторToolStripMenuItem1;
        private ToolStripMenuItem moveNextToolStripMenuItem1;
        private ToolStripMenuItem currentToolStripMenuItem1;
        private ToolStripMenuItem resetToolStripMenuItem1;
    }
}
