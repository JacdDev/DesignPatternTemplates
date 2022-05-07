using EnvDTE;
using System;
using System.Collections;

namespace DesignPatternTemplates
{
    partial class PatternSelectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new GroupedComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select pattern";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = null;
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Value";
            this.comboBox1.DisplayMember = "Display";
            this.comboBox1.GroupMember = "Group";
            this.comboBox1.DataSource = new ArrayList(new object[] {
                new { Value=1, Display="Abstract Factory", Group="Creational Patterns" },
                new { Value=2, Display="Builder", Group="Creational Patterns" },
                new { Value=3, Display="Factory Method", Group="Creational Patterns" },
                new { Value=4, Display="Prototype", Group="Creational Patterns" },
                new { Value=5, Display="Singleton", Group="Creational Patterns" },
                new { Value=6, Display="Adapter", Group="Structural Patterns" },
                new { Value=7, Display="Bridge", Group="Structural Patterns" },
                new { Value=8, Display="Composite", Group="Structural Patterns" },
                new { Value=9, Display="Decorator", Group="Structural Patterns" },
                new { Value=10, Display="Facade", Group="Structural Patterns" },
                new { Value=11, Display="Flyweight", Group="Structural Patterns" },
                new { Value=12, Display="Proxy", Group="Structural Patterns" },
                new { Value=13, Display="Chain of responsibility", Group="Behavioral Patterns" },
                new { Value=14, Display="Command", Group="Behavioral Patterns" },
                new { Value=15, Display="Interpreter", Group="Behavioral Patterns" },
                new { Value=16, Display="Iterator", Group="Behavioral Patterns" },
                new { Value=17, Display="Mediator", Group="Behavioral Patterns" },
                new { Value=18, Display="Memento", Group="Behavioral Patterns" },
                new { Value=19, Display="Observer", Group="Behavioral Patterns" },
                new { Value=20, Display="State", Group="Behavioral Patterns" },
                new { Value=21, Display="Strategy", Group="Behavioral Patterns" },
                new { Value=22, Display="Template Method", Group="Behavioral Patterns" },
                new { Value=23, Display="Visitor", Group="Behavioral Patterns" }
            });
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select project";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(32, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 21);
            this.comboBox2.TabIndex = 4;
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            var _dte = Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider.GetService(typeof(DTE)) as DTE;
            foreach (Project project in _dte.Solution.Projects)
            {
                if (project.UniqueName != "<MiscFiles>")
                    this.comboBox2.Items.Add(project.Name);
            }
            if (this.comboBox2.Items.Count > 0)
                this.comboBox2.SelectedIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path (ex. Patterns/Templates) - optional";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 6;
            // 
            // PatternSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 265);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "PatternSelectionForm";
            this.Text = "Pattern Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GroupedComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}