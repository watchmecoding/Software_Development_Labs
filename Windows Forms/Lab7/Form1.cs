using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        Data data = new Data();
        public Form1()
        {
            InitializeComponent();
            ShowcurrentConsumable();
            data.CheckParts();
            ShowParts();
        }

        private void ShowcurrentConsumable()
        {
            BoxName.Text = data.Consumables[data.currentConsumable].Name;
            BoxYear.Text = data.Consumables[data.currentConsumable].ManufactureYear.ToString();
            BoxProvider.Text = data.Consumables[data.currentConsumable].Provider;
            BoxCountry.Text = data.Consumables[data.currentConsumable].CountryProvider;
            BoxHMaterial.Text = data.Consumables[data.currentConsumable].CMaterial;
            BoxAMaterial.Text = data.Consumables[data.currentConsumable].CAddInfo.ToString();
            BoxHDiameter.Text = data.Consumables[data.currentConsumable].CWidth.ToString();
            BoxALength.Text = data.Consumables[data.currentConsumable].CLength.ToString();
        }
        private void ShowFirstGuitar(int index)
        {
            if(index == -1)
            {
                GBoxName1.Text = " ";
                GBoxYear1.Text = " ";
                GBoxProvider1.Text = " ";
                GBoxCountry1.Text = " ";
                GBoxStrings1.Text = " ";
                GBoxMaterial1.Text = " ";
                GBoxBody1.Text = " ";
                GBoxLength1.Text = " ";
            }
            else
            {
                GBoxName1.Text = data.Parts[index].Name;
                GBoxYear1.Text = data.Parts[index].ManufactureYear.ToString();
                GBoxProvider1.Text = data.Parts[index].Provider;
                GBoxCountry1.Text = data.Parts[index].CountryProvider;
                GBoxStrings1.Text = data.Parts[index].Amount.ToString();
                GBoxMaterial1.Text = data.Parts[index].Material;
                GBoxBody1.Text = data.Parts[index].Width.ToString();
                GBoxLength1.Text = data.Parts[index].Length.ToString();
            }            
        }

        private void ShowSecondGuitar(int index)
        {
            if (index == -1)
            {
                GBoxName2.Text = " ";
                GBoxYear2.Text = " ";
                GBoxProvider2.Text = " ";
                GBoxCountry2.Text = " ";
                GBoxStrings2.Text = " ";
                GBoxMaterial2.Text = " ";
                GBoxBody2.Text = " ";
                GBoxLength2.Text = " ";
            }
            else
            {
                GBoxName2.Text = data.Parts[index].Name;
                GBoxYear2.Text = data.Parts[index].ManufactureYear.ToString();
                GBoxProvider2.Text = data.Parts[index].Provider;
                GBoxCountry2.Text = data.Parts[index].CountryProvider;
                GBoxStrings2.Text = data.Parts[index].Amount.ToString();
                GBoxMaterial2.Text = data.Parts[index].Material;
                GBoxBody2.Text = data.Parts[index].Width.ToString();
                GBoxLength2.Text = data.Parts[index].Length.ToString();
            }
           
        }
        private void ShowThirdGuitar(int index)
        {
            if (index == -1)
            {
                GBoxName3.Text = " ";
                GBoxYear3.Text = " ";
                GBoxProvider3.Text = " ";
                GBoxCountry3.Text = " ";
                GBoxStrings3.Text = " ";
                GBoxMaterial3.Text = " ";
                GBoxBody3.Text = " ";
                GBoxLength3.Text = " ";
            }
            else
            {
                GBoxName3.Text = data.Parts[index].Name;
                GBoxYear3.Text = data.Parts[index].ManufactureYear.ToString();
                GBoxProvider3.Text = data.Parts[index].Provider;
                GBoxCountry3.Text = data.Parts[index].CountryProvider;
                GBoxStrings3.Text = data.Parts[index].Amount.ToString();
                GBoxMaterial3.Text = data.Parts[index].Material;
                GBoxBody3.Text = data.Parts[index].Width.ToString();
                GBoxLength3.Text = data.Parts[index].Length.ToString();
            }

        }
        private void ShowParts()
        {
            ShowFirstGuitar(data.PartsToShow[0]);
            ShowSecondGuitar(data.PartsToShow[1]);
            ShowThirdGuitar(data.PartsToShow[2]);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            data.Consumables.Add(new Consumables(BoxName.Text, Convert.ToInt32(BoxYear.Text), BoxProvider.Text,
                BoxCountry.Text, BoxHMaterial.Text, BoxAMaterial.Text, Convert.ToDouble(BoxHDiameter.Text),
                Convert.ToDouble(BoxALength.Text)
            ));
        }

        private void ToLeftButton_Click(object sender, EventArgs e)
        {
            data.DecrementConsumable();
            ShowcurrentConsumable();
        }

        private void ToRightButton_Click(object sender, EventArgs e)
        {
            data.IncrementConsumable();
            ShowcurrentConsumable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Consumables hammer = new Consumables(BoxName.Text, Convert.ToInt32(BoxYear.Text), BoxProvider.Text,
                BoxCountry.Text, BoxHMaterial.Text, BoxAMaterial.Text, Convert.ToDouble(BoxHDiameter.Text),
                Convert.ToDouble(BoxALength.Text));
            
            for (int i = 0; i < data.Consumables.Count; i++)
            {
                if (hammer.Equals(data.Consumables[i])) data.Consumables.Remove(data.Consumables[i]);
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            data.DecrementPart();
            ShowParts();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            data.IncrementPart();
            ShowParts();
        }

        private void DeleteGuitar1_Click(object sender, EventArgs e)
        {
            data.Parts.Remove(data.Parts[data.PartsToShow[0]]);
            if (!data.CheckParts()) data.SetParts();
            ShowParts();
        }

        private void DeleteGuitar2_Click(object sender, EventArgs e)
        {
            data.Parts.Remove(data.Parts[data.PartsToShow[1]]);
            if (!data.CheckParts()) data.SetParts();
            ShowParts();
        }

        private void DeleteGuitar3_Click(object sender, EventArgs e)
        {
            data.Parts.Remove(data.Parts[data.PartsToShow[2]]);
            if (!data.CheckParts()) data.SetParts();
            ShowParts();
        }

        private void AddGuitarButton_Click(object sender, EventArgs e)
        {
            Parts guitar = new Parts(GBoxName1.Text, Convert.ToInt32(GBoxYear1.Text), GBoxProvider1.Text,
                GBoxCountry1.Text, GBoxMaterial1.Text, Convert.ToInt32(GBoxStrings1.Text), Convert.ToInt32(GBoxLength1.Text),
                Convert.ToInt32(GBoxLength1.Text));
            data.Parts.Add(guitar);
            if (!data.CheckParts()) data.SetParts();
            ShowParts();
        }

        private void ToRichTextBox_Click(object sender, EventArgs e)
        {

        }

        private void ConsumablesFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Consumables.txt");
            foreach(Consumables hammer in data.Consumables)
            {
                sw.WriteLine(hammer.ToString());
            }
            sw.Close();
        }

        private void PartsFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Parts.txt");
            foreach (Parts guitar in data.Parts)
            {
                sw.WriteLine(guitar.ToString());
            }
            sw.Close();
        }

        private void ConsumablesRTB_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Consumables hammer in data.Consumables)
            {
               sb.AppendLine(hammer.ToString());
            }
            RTBCollections.Text = sb.ToString();
        }

        private void PartsRTB_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Parts guitar in data.Parts)
            {
                sb.AppendLine(guitar.ToString());
            }
            RTBCollections.Text = sb.ToString();
        }

        private void BoxName_MouseClick(object sender, MouseEventArgs e)
        {            
            if (e.Button != MouseButtons.Left)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxYear_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxProvider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxCountry_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxHMaterial_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumables", buttons);
            }
        }

        private void BoxAMaterial_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxHDiameter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void BoxALength_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Consumables[data.currentConsumable].ToString(), "Consumable", buttons);
            }
        }

        private void GBoxName1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxYear1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxProvider1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxCountry1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxStrings1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxMaterial1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxBody1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxLength1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[0]].ToString(), "Part", buttons);
            }
        }

        private void GBoxName2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxYear2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxProvider2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxCountry2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxStrings2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxMaterial2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxBody2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxLength2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[1]].ToString(), "Part", buttons);
            }
        }

        private void GBoxName3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxYear3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxProvider3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxCountry3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxStrings3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxMaterial3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxBody3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }

        private void GBoxLength3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(data.Parts[data.PartsToShow[2]].ToString(), "Part", buttons);
            }
        }
    }
}
