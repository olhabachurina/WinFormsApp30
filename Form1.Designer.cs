namespace WinFormsApp30
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
            labelMenu = new Label();
            rightPanel = new Panel();
            buttonrigth = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            labelleft = new Label();
            buttonleft = new Button();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.BackColor = SystemColors.ActiveCaption;
            labelMenu.Dock = DockStyle.Top;
            labelMenu.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.Location = new Point(0, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(800, 44);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "Menu";
            labelMenu.TextAlign = ContentAlignment.MiddleCenter;
            labelMenu.UseCompatibleTextRendering = true;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(label1);
            rightPanel.Controls.Add(textBox1);
            rightPanel.Controls.Add(buttonrigth);
            rightPanel.Location = new Point(550, 44);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(250, 407);
            rightPanel.TabIndex = 1;
            // 
            // buttonrigth
            // 
            buttonrigth.Location = new Point(84, 220);
            buttonrigth.Name = "buttonrigth";
            buttonrigth.Size = new Size(94, 29);
            buttonrigth.TabIndex = 0;
            buttonrigth.Text = "Button";
            buttonrigth.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(68, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 129);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 2;
            label1.Text = "Panel Content";
            // 
            // labelleft
            // 
            labelleft.AutoSize = true;
            labelleft.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelleft.Location = new Point(266, 201);
            labelleft.Name = "labelleft";
            labelleft.Size = new Size(164, 31);
            labelleft.TabIndex = 2;
            labelleft.Text = "Body Content";
            // 
            // buttonleft
            // 
            buttonleft.Location = new Point(273, 264);
            buttonleft.Name = "buttonleft";
            buttonleft.Size = new Size(157, 29);
            buttonleft.TabIndex = 3;
            buttonleft.Text = "Show Hidden Panel";
            buttonleft.UseVisualStyleBackColor = true;
            buttonleft.Click += buttonleft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonleft);
            Controls.Add(labelleft);
            Controls.Add(rightPanel);
            Controls.Add(labelMenu);
            Name = "Form1";
            Text = "Form1";
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private Panel rightPanel;
        private TextBox textBox1;
        private Button buttonrigth;
        private Label label1;
        private Label labelleft;
        private Button buttonleft;
    }
}