using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Collections;

namespace BLD_win10.AppForms
{
    public partial class OtherTestForm : Form
    {
        public OtherTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 测试读取配置文件 App.config
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(
                ConfigurationUserLevel.None);

            // Get the collection of the section groups.
            ConfigurationSectionGroupCollection sectionGroups =
                config.SectionGroups;

            // Display the section groups.
            ShowSectionGroupCollectionInfo(sectionGroups);
        }
        static int indentLevel = 0;
        static void ShowSectionGroupCollectionInfo(
            ConfigurationSectionGroupCollection sectionGroups)
        {
            foreach (ConfigurationSectionGroup sectionGroup in sectionGroups)
            {
                ShowSectionGroupInfo(sectionGroup);
            }
        }

        static void ShowSectionGroupInfo(
            ConfigurationSectionGroup sectionGroup)
        {
            // Get the section group name.
            indent("Section Group Name: " + sectionGroup.Name);

            // Get the fully qualified group name.
            indent("Section Group Name: " + sectionGroup.SectionGroupName);

            indentLevel++;

            indent("Type: " + sectionGroup.Type);
            indent("Is Group Required?: " +
                sectionGroup.IsDeclarationRequired);
            indent("Is Group Declared?: " + sectionGroup.IsDeclared);
            indent("Contained Sections:");

            indentLevel++;
            foreach (ConfigurationSection section
                in sectionGroup.Sections)
            {
                indent("Section Name:" + section.SectionInformation.Name);
            }
            indentLevel--;

            // Display contained section groups if there are any.
            if (sectionGroup.SectionGroups.Count > 0)
            {
                indent("Contained Section Groups:");

                indentLevel++;
                ConfigurationSectionGroupCollection sectionGroups =
                    sectionGroup.SectionGroups;
                ShowSectionGroupCollectionInfo(sectionGroups);
            }

            Console.WriteLine("");
            indentLevel--;
        }

        static void indent(string text)
        {
            for (int i = 0; i < indentLevel; i++)
            {
                Console.Write("  ");
            }
            Console.WriteLine(text.Substring(0, Math.Min(79 - indentLevel * 2, text.Length)));
        }
    }
}
