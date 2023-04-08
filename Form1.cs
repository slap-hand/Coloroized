using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorized
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string red1 = "255 0 0";
        string green1 = "0 255 0";
        string orange1 = "255 167 43";
        string purple1 = "173 110 255";
        string white1 = "255 255 255";
        string default1 = "153 180 209";

        private void button1_Click(object sender, EventArgs e)
        {
            // Specify the path to the registry key and the value you want to change
            string keyPath = @"Control Panel\Colors";
            string valueName = "Window";
            string valueData = "" + red1 + "";

            // Open the registry key
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true);

            // Set the value of the specified key
            key.SetValue(valueName, valueData);

            // Close the registry key
            key.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath1 = @"Control Panel\Colors";
            string valueName1 = "Hilight";
            string valueData1 = "" + red1 + "";

            // Open the registry key
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(keyPath1, true);

            // Set the value of the specified key
            key1.SetValue(valueName1, valueData1);

            // Close the registry key
            key1.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath2 = @"Control Panel\Colors";
            string valueName2 = "HotTrackingColor";
            string valueData2 = "" + red1 + "";

            // Open the registry key
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true);

            // Set the value of the specified key
            key2.SetValue(valueName2, valueData2);

            // Close the registry key
            key2.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath3 = @"Control Panel\Colors";
            string valueName3 = "WindowFrame";
            string valueData3 = "" + red1 + "";

            // Open the registry key
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(keyPath3, true);

            // Set the value of the specified key
            key3.SetValue(valueName3, valueData3);

            // Close the registry key
            key3.Close();
        }
        //red

        private void standard_Click(object sender, EventArgs e)
        {
            // Specify the path to the registry key and the value you want to change
            string keyPath = @"Control Panel\Colors";
            string valueName = "Window";
            string valueData = "153 180 209";

            // Open the registry key
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true);

            // Set the value of the specified key
            key.SetValue(valueName, valueData);

            // Close the registry key
            key.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath1 = @"Control Panel\Colors";
            string valueName1 = "Hilight";
            string valueData1 = "" + default1 + "";

            // Open the registry key
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(keyPath1, true);

            // Set the value of the specified key
            key1.SetValue(valueName1, valueData1);

            // Close the registry key
            key1.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath2 = @"Control Panel\Colors";
            string valueName2 = "HotTrackingColor";
            string valueData2 = "" + default1 + "";

            // Open the registry key
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true);

            // Set the value of the specified key
            key2.SetValue(valueName2, valueData2);

            // Close the registry key
            key2.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath3 = @"Control Panel\Colors";
            string valueName3 = "WindowFrame";
            string valueData3 = "" + default1 + "";

            // Open the registry key
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(keyPath3, true);

            // Set the value of the specified key
            key3.SetValue(valueName3, valueData3);

            // Close the registry key
            key3.Close();
        }
        //standard

        private void green_Click(object sender, EventArgs e)
        {
            // Specify the path to the registry key and the value you want to change
            string keyPath = @"Control Panel\Colors";
            string valueName = "Window";
            string valueData = "" + green1 + "";

            // Open the registry key
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true);

            // Set the value of the specified key
            key.SetValue(valueName, valueData);

            // Close the registry key
            key.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath1 = @"Control Panel\Colors";
            string valueName1 = "Hilight";
            string valueData1 = "" + green1 + "";

            // Open the registry key
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(keyPath1, true);

            // Set the value of the specified key
            key1.SetValue(valueName1, valueData1);

            // Close the registry key
            key1.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath2 = @"Control Panel\Colors";
            string valueName2 = "HotTrackingColor";
            string valueData2 = "" + green1 + "";

            // Open the registry key
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true);

            // Set the value of the specified key
            key2.SetValue(valueName2, valueData2);

            // Close the registry key
            key2.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath3 = @"Control Panel\Colors";
            string valueName3 = "WindowFrame";
            string valueData3 = "" + green1 + "";

            // Open the registry key
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(keyPath3, true);

            // Set the value of the specified key
            key3.SetValue(valueName3, valueData3);

            // Close the registry key
            key3.Close();
        }
        //green

        private void orange_Click(object sender, EventArgs e)
        {
            // Specify the path to the registry key and the value you want to change
            string keyPath = @"Control Panel\Colors";
            string valueName = "Window";
            string valueData = "" + orange1 + "";

            // Open the registry key
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true);

            // Set the value of the specified key
            key.SetValue(valueName, valueData);

            // Close the registry key
            key.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath1 = @"Control Panel\Colors";
            string valueName1 = "Hilight";
            string valueData1 = "" + orange1 + "";

            // Open the registry key
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(keyPath1, true);

            // Set the value of the specified key
            key1.SetValue(valueName1, valueData1);

            // Close the registry key
            key1.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath2 = @"Control Panel\Colors";
            string valueName2 = "HotTrackingColor";
            string valueData2 = "" + orange1 + "";

            // Open the registry key
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true);

            // Set the value of the specified key
            key2.SetValue(valueName2, valueData2);

            // Close the registry key
            key2.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath3 = @"Control Panel\Colors";
            string valueName3 = "WindowFrame";
            string valueData3 = "" + orange1 + "";

            // Open the registry key
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(keyPath3, true);

            // Set the value of the specified key
            key3.SetValue(valueName3, valueData3);

            // Close the registry key
            key3.Close();
        }
        //orange

        private void purple_Click(object sender, EventArgs e)
        {
            // Specify the path to the registry key and the value you want to change
            string keyPath = @"Control Panel\Colors";
            string valueName = "Window";
            string valueData = "" + purple1 + "";

            // Open the registry key
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true);

            // Set the value of the specified key
            key.SetValue(valueName, valueData);

            // Close the registry key
            key.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath1 = @"Control Panel\Colors";
            string valueName1 = "Hilight";
            string valueData1 = "" + purple1 + "";

            // Open the registry key
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(keyPath1, true);

            // Set the value of the specified key
            key1.SetValue(valueName1, valueData1);

            // Close the registry key
            key1.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath2 = @"Control Panel\Colors";
            string valueName2 = "HotTrackingColor";
            string valueData2 = "" + purple1 + "";

            // Open the registry key
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true);

            // Set the value of the specified key
            key2.SetValue(valueName2, valueData2);

            // Close the registry key
            key2.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath3 = @"Control Panel\Colors";
            string valueName3 = "WindowFrame";
            string valueData3 = "" + purple1 + "";

            // Open the registry key
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(keyPath3, true);

            // Set the value of the specified key
            key3.SetValue(valueName3, valueData3);

            // Close the registry key
            key3.Close();
        }
        //purple

        private void white_Click(object sender, EventArgs e)
        {
            // Specify the path to the registry key and the value you want to change
            string keyPath = @"Control Panel\Colors";
            string valueName = "Window";
            string valueData = "" + white1 + "";

            // Open the registry key
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true);

            // Set the value of the specified key
            key.SetValue(valueName, valueData);

            // Close the registry key
            key.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath1 = @"Control Panel\Colors";
            string valueName1 = "Hilight";
            string valueData1 = "" + white1 + "";

            // Open the registry key
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(keyPath1, true);

            // Set the value of the specified key
            key1.SetValue(valueName1, valueData1);

            // Close the registry key
            key1.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath2 = @"Control Panel\Colors";
            string valueName2 = "HotTrackingColor";
            string valueData2 = "" + white1 + "";

            // Open the registry key
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(keyPath2, true);

            // Set the value of the specified key
            key2.SetValue(valueName2, valueData2);

            // Close the registry key
            key2.Close();

            // Specify the path to the registry key and the value you want to change
            string keyPath3 = @"Control Panel\Colors";
            string valueName3 = "WindowFrame";
            string valueData3 = "" + white1 + "";

            // Open the registry key
            RegistryKey key3 = Registry.CurrentUser.OpenSubKey(keyPath3, true);

            // Set the value of the specified key
            key3.SetValue(valueName3, valueData3);

            // Close the registry key
            key3.Close();
        }
    }
}
