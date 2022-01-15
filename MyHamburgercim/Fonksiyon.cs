using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHamburgercim
{
    public class Fonksiyon
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    if (textBox.Name == "txtToplamFiyat")
                    {

                    }
                    else
                    {
                        textBox.Clear();
                    }
                }
                else if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    checkBox.Checked = false;
                }
                else if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Text == "Küçük")
                    {
                        radioButton.Checked = true;
                    }
                    else
                    {
                        radioButton.Checked = false;
                    }
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    numericUpDown.Value = 1;
                }
                else if (item is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)item;
                    Temizle(groupBox.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)item;
                    Temizle(flowLayoutPanel.Controls);
                }
                else if (item is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)item;
                    comboBox.SelectedIndex = 0;
                }
            }
        }
    }
}
