using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternTemplates
{
    public partial class PatternSelectionForm : Form
    {
        public PatternSelectionForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedValue)
                {
                    case 1:
                        TemplateGenerator.Generate("AbstractFactoryTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 2:
                        TemplateGenerator.Generate("BuilderTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 3:
                        TemplateGenerator.Generate("FactoryMethodTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 4:
                        TemplateGenerator.Generate("PrototypeTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 5:
                        TemplateGenerator.Generate("SingletonTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 6:
                        TemplateGenerator.Generate("AdapterTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 7:
                        TemplateGenerator.Generate("BridgeTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 8:
                        TemplateGenerator.Generate("CompositeTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 9:
                        TemplateGenerator.Generate("DecoratorTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 10:
                        TemplateGenerator.Generate("FacadeTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 11:
                        TemplateGenerator.Generate("FlyweightTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 12:
                        TemplateGenerator.Generate("ProxyTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 13:
                        TemplateGenerator.Generate("ChainOfResponsibilityTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 14:
                        TemplateGenerator.Generate("CommandTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 15:
                        TemplateGenerator.Generate("InterpreterTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 16:
                        TemplateGenerator.Generate("IteratorTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 17:
                        TemplateGenerator.Generate("MediatorTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 18:
                        TemplateGenerator.Generate("MementoTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 19:
                        TemplateGenerator.Generate("ObserverTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 20:
                        TemplateGenerator.Generate("StateTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 21:
                        TemplateGenerator.Generate("StrategyTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 22:
                        TemplateGenerator.Generate("TemplateMethodTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    case 23:
                        TemplateGenerator.Generate("VisitorTemplate.txt", comboBox2.SelectedIndex, textBox1.Text);
                        break;
                    default:
                        Exception exception = new Exception("Must select a pattern");
                        throw exception;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
