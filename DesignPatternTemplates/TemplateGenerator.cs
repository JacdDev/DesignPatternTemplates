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

        public static void Generate(string templateName, int projectIndex)
        {
            string extensionPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("DesignPatternTemplates.dll", "");
            string originPath = extensionPath + "\\Resources\\" + templateName;

            string destinationPath;

            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            var _dte = Microsoft.VisualStudio.Shell.ServiceProvider.GlobalProvider.GetService(typeof(DTE)) as DTE;
            Assumes.Present(_dte);

            Project _selectedProject;
            if (_dte.Solution.Projects.Count != 0)
            {
               _selectedProject = _dte.Solution.Projects.Item(projectIndex+1);
                destinationPath = new FileInfo(_selectedProject.FullName).DirectoryName + "\\" + templateName.Replace(".txt", ".cs");
            }
            else
            {
                Exception exception = new Exception("No projects found");
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

            string templateContent = File.ReadAllText(originPath);
            templateContent = templateContent.Replace("${namespace}", new FileInfo(_dte.Solution.FullName).Name.Replace(".sln", ".") + _selectedProject.Name);
            File.WriteAllText(destinationPath, templateContent);

            _dte.ItemOperations.OpenFile(destinationPath);

            MessageBox.Show(
                    "Pattern Generated",
                    "OK",
                    MessageBoxButtons.OK
                );
        }
    }
}