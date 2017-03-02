using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haytham.Forms
{
    public static class DropdownPrompt
    {
        public static T ShowDialog<T>(string caption, T[] values)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 100;
            prompt.Text = caption;
            FlowLayoutPanel flp = new FlowLayoutPanel() { Width = 380 };
            prompt.Controls.Add(flp);

            ComboBox cmbValues = new ComboBox() { Width = 360 };
            Button btnOk = new Button() { Text = "Ok", Width = 360 };

            flp.Controls.Add(cmbValues);
            flp.Controls.Add(btnOk);
            
            foreach (T value in values)
            {
                cmbValues.Items.Add((object)value);
            }
            cmbValues.SelectedIndex = 0;

            btnOk.Click += (sender, e) => { prompt.Close(); };

            prompt.ShowDialog();

            return (T)cmbValues.SelectedItem;
        }
    }
}
