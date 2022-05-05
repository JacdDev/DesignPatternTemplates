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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Pattern";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = null;
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 71);
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
            this.button1.Location = new System.Drawing.Point(213, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PatternSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 156);
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
    }
}