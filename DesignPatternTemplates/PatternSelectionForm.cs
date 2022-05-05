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
                        TemplateGenerator.Generate("AbstractFactoryTemplate.txt");
                        break;
                    case 2:
                        TemplateGenerator.Generate("BuilderTemplate.txt");
                        break;
                    case 3:
                        TemplateGenerator.Generate("FactoryMethodTemplate.txt");
                        break;
                    case 4:
                        TemplateGenerator.Generate("PrototypeTemplate.txt");
                        break;
                    case 5:
                        TemplateGenerator.Generate("SingletonTemplate.txt");
                        break;
                    case 6:
                        TemplateGenerator.Generate("AdapterTemplate.txt");
                        break;
                    case 7:
                        TemplateGenerator.Generate("BridgeTemplate.txt");
                        break;
                    case 8:
                        TemplateGenerator.Generate("CompositeTemplate.txt");
                        break;
                    case 9:
                        TemplateGenerator.Generate("DecoratorTemplate.txt");
                        break;
                    case 10:
                        TemplateGenerator.Generate("FacadeTemplate.txt");
                        break;
                    case 11:
                        TemplateGenerator.Generate("FlyweightTemplate.txt");
                        break;
                    case 12:
                        TemplateGenerator.Generate("ProxyTemplate.txt");
                        break;
                    case 13:
                        TemplateGenerator.Generate("ChainOfResponsibilityTemplate.txt");
                        break;
                    case 14:
                        TemplateGenerator.Generate("CommandTemplate.txt");
                        break;
                    case 15:
                        TemplateGenerator.Generate("InterpreterTemplate.txt");
                        break;
                    case 16:
                        TemplateGenerator.Generate("IteratorTemplate.txt");
                        break;
                    case 17:
                        TemplateGenerator.Generate("MediatorTemplate.txt");
                        break;
                    case 18:
                        TemplateGenerator.Generate("MementoTemplate.txt");
                        break;
                    case 19:
                        TemplateGenerator.Generate("ObserverTemplate.txt");
                        break;
                    case 20:
                        TemplateGenerator.Generate("StateTemplate.txt");
                        break;
                    case 21:
                        TemplateGenerator.Generate("StrategyTemplate.txt");
                        break;
                    case 22:
                        TemplateGenerator.Generate("TemplateMethodTemplate.txt");
                        break;
                    case 23:
                        TemplateGenerator.Generate("VisitorTemplate.txt");
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
