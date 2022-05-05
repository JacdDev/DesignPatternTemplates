using EnvDTE;
using Microsoft;
using System;
using System.IO;
using System.Windows.Forms;

namespace DesignPatternTemplates
{
    public class TemplateGenerator 
    {
        protected TemplateGenerator()
        {

        }

        public static void Generate(string templateName)
        {
            string extensionPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("DesignPatternTemplates.dll", "");
            string originPath = extensionPath + "\\Resources\\" + templateName;

            string destinationPath;
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            var _dte = Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider.GetService(typeof(DTE)) as DTE;
            Assumes.Present(_dte);

            if (_dte.ActiveSolutionProjects is Array _projects && _projects.Length != 0)
            {
                Project _selectedProject = _projects.GetValue(0) as Project;
                destinationPath = new FileInfo(_selectedProject.FullName).DirectoryName + "\\" + templateName.Replace(".txt", ".cs");
            }
            else
            {
                Exception exception = new Exception("No default project found");
                throw exception;
            }

            if (File.Exists(destinationPath))
            {
                DialogResult confirmation = MessageBox.Show(
                    destinationPath+" already exists, do you want to replace it?",
                    "File already exists",
                    MessageBoxButtons.YesNo
                );

                if (confirmation == DialogResult.No)
                    return;
            }

            File.Copy(originPath, destinationPath,true);
            _dte.ItemOperations.OpenFile(destinationPath);

            MessageBox.Show(
                    "Pattern Generated",
                    "OK",
                    MessageBoxButtons.OK
                );
        }
    }
}