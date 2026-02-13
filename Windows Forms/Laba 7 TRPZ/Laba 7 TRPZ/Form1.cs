using System.Buffers.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laba_7_TRPZ
{
    public partial class Form1 : Form
    {
        public List<Animal> AddedAnimalList = new List<Animal>();


        public Form1()
        {
            InitializeComponent();
            AddedAnimalList.Add(new BlueTit("Birdie", 5, "Female", "Amazon forest", "Two wings", "Small", "Fast flight", "Blue", "Fruits", "Small", "3 birds", "Brazil-USA"));
            AddedAnimalList.Add(new Dolphin("Igor", 20, "Male", "Pacific ocean", "No legs", "Tail with flippers", 15.61, "No fur", "Fast", "Average", "Sonar", 50.6));
            AddedAnimalList.Add(new Lion("Katya", 12, "Female", "Savanna", "4 legs", "Long", 5.56, "Orange with black spots", "Carnivour", "Long", "Lives in a pack", 126.5));
            AddedAnimalList.Add(new BlueTit("Oleg", 2, "Male", "Forest", "Two wings", "Small", "Fast flight", "Multicolored", "Fruits and berries", "Small", "5 birds", "Ukraine-Turkey"));
            ShowAnimals();
        }

        private void ShowAnimals()
        {
            while (splitContainer1.Panel2.Controls.Count > 1)
            {
                //MessageBox.Show(splitContainer1.Panel2.Controls.Count.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splitContainer1.Panel2.Controls.RemoveAt(1);
            }

            for (int i = 0; i < AddedAnimalList.Count; i++)
            {
                Animal animal = AddedAnimalList[i];
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Top;
                Label[] labels = new Label[13];
                TextBox[] textboxes = new TextBox[12];
                #region Fill Arrays
                for (int j = 0; j < labels.Count(); j++)
                {
                    labels[j] = new Label();
                    labels[j].AutoSize = true;
                }
                for (int j = 0; j < textboxes.Count(); j++)
                {
                    textboxes[j] = new TextBox();
                    textboxes[j].Name = "Value_" + i.ToString() + "_" + j.ToString();
                }
                #endregion
                if (animal.GetType().Name == "BlueTit")
                {
                    #region Fill labels and text boxes
                    BlueTit temp = (BlueTit)animal;
                    labels[0].Text = "Type: BlueTit";
                    labels[1].Text = "Name:";
                    textboxes[0].PlaceholderText = labels[1].Text;
                    textboxes[0].Text = temp.Name;
                    labels[2].Text = "Age:";
                    textboxes[1].PlaceholderText = labels[2].Text;
                    textboxes[1].Text = temp.Age.ToString();
                    labels[3].Text = "Gender:";
                    textboxes[2].PlaceholderText = labels[3].Text;
                    textboxes[2].Text = temp.Gender;
                    labels[4].Text = "Habitat:";
                    textboxes[3].PlaceholderText = labels[4].Text;
                    textboxes[3].Text = temp.Habitat;
                    labels[5].Text = "Wings:";
                    textboxes[4].PlaceholderText = labels[5].Text;
                    textboxes[4].Text = temp.Wings;
                    labels[6].Text = "Beak:";
                    textboxes[5].PlaceholderText = labels[6].Text;
                    textboxes[5].Text = temp.Beak;
                    labels[7].Text = "Flight type:";
                    textboxes[6].PlaceholderText = labels[7].Text;
                    textboxes[6].Text = temp.FlightType;
                    labels[8].Text = "Feather color:";
                    textboxes[7].PlaceholderText = labels[8].Text;
                    textboxes[7].Text = temp.FeatherColor;
                    labels[9].Text = "Diet type:";
                    textboxes[8].PlaceholderText = labels[9].Text;
                    textboxes[8].Text = temp.DietType;
                    labels[10].Text = "Size:";
                    textboxes[9].PlaceholderText = labels[10].Text;
                    textboxes[9].Text = temp.Size;
                    labels[11].Text = "Family:";
                    textboxes[10].PlaceholderText = labels[11].Text;
                    textboxes[10].Text = temp.Family;
                    labels[12].Text = "Migration route:";
                    textboxes[11].PlaceholderText = labels[12].Text;
                    textboxes[11].Text = temp.MigrationRoute;
                    #endregion
                }
                else if (animal.GetType().Name == "Lion")
                {
                    #region Fill labels and text boxes
                    Lion temp = (Lion)animal;
                    labels[0].Text = "Type: Lion";
                    labels[1].Text = "Name:";
                    textboxes[0].PlaceholderText = labels[1].Text;
                    textboxes[0].Text = temp.Name;
                    labels[2].Text = "Age:";
                    textboxes[1].PlaceholderText = labels[2].Text;
                    textboxes[1].Text = temp.Age.ToString();
                    labels[3].Text = "Gender:";
                    textboxes[2].PlaceholderText = labels[3].Text;
                    textboxes[2].Text = temp.Gender;
                    labels[4].Text = "Habitat:";
                    textboxes[3].PlaceholderText = labels[4].Text;
                    textboxes[3].Text = temp.Habitat;
                    labels[5].Text = "Legs:";
                    textboxes[4].PlaceholderText = labels[5].Text;
                    textboxes[4].Text = temp.Legs;
                    labels[6].Text = "Tail:";
                    textboxes[5].PlaceholderText = labels[6].Text;
                    textboxes[5].Text = temp.Tail;
                    labels[7].Text = "Tooth diameter";
                    textboxes[6].PlaceholderText = labels[7].Text;
                    textboxes[6].Text = temp.ToothDiameter.ToString();
                    labels[8].Text = "Fur color:";
                    textboxes[7].PlaceholderText = labels[8].Text;
                    textboxes[7].Text = temp.FurColors;
                    labels[9].Text = "Feeding type:";
                    textboxes[8].PlaceholderText = labels[9].Text;
                    textboxes[8].Text = temp.FeedingType;
                    labels[10].Text = "Mane size:";
                    textboxes[9].PlaceholderText = labels[10].Text;
                    textboxes[9].Text = temp.ManeSize;
                    labels[11].Text = "Social structure:";
                    textboxes[10].PlaceholderText = labels[11].Text;
                    textboxes[10].Text = temp.SocialStructure;
                    labels[12].Text = "Body weight:";
                    textboxes[11].PlaceholderText = labels[12].Text;
                    textboxes[11].Text = temp.BodyWeight.ToString();
                    #endregion
                }
                else if (animal.GetType().Name == "Dolphin")
                {
                    #region Fill labels and text boxes
                    Dolphin temp = (Dolphin)animal;
                    labels[0].Text = "Type: Dolphin";
                    labels[1].Text = "Name:";
                    textboxes[0].PlaceholderText = labels[1].Text;
                    textboxes[0].Text = temp.Name;
                    labels[2].Text = "Age:";
                    textboxes[1].PlaceholderText = labels[2].Text;
                    textboxes[1].Text = temp.Age.ToString();
                    labels[3].Text = "Gender:";
                    textboxes[2].PlaceholderText = labels[3].Text;
                    textboxes[2].Text = temp.Gender;
                    labels[4].Text = "Habitat:";
                    textboxes[3].PlaceholderText = labels[4].Text;
                    textboxes[3].Text = temp.Habitat;
                    labels[5].Text = "Legs:";
                    textboxes[4].PlaceholderText = labels[5].Text;
                    textboxes[4].Text = temp.Legs;
                    labels[6].Text = "Tail:";
                    textboxes[5].PlaceholderText = labels[6].Text;
                    textboxes[5].Text = temp.Tail;
                    labels[7].Text = "Tooth diameter";
                    textboxes[6].PlaceholderText = labels[7].Text;
                    textboxes[6].Text = temp.ToothDiameter.ToString();
                    labels[8].Text = "Fur color:";
                    textboxes[7].PlaceholderText = labels[8].Text;
                    textboxes[7].Text = temp.FurColors;
                    labels[9].Text = "Swimming style:";
                    textboxes[8].PlaceholderText = labels[9].Text;
                    textboxes[8].Text = temp.SwimmingStyle;
                    labels[10].Text = "Fin size";
                    textboxes[9].PlaceholderText = labels[10].Text;
                    textboxes[9].Text = temp.FinSize;
                    labels[11].Text = "Communications:";
                    textboxes[10].PlaceholderText = labels[11].Text;
                    textboxes[10].Text = temp.Communication;
                    labels[12].Text = "Average speed";
                    textboxes[11].PlaceholderText = labels[12].Text;
                    textboxes[11].Text = temp.AverageSpeed.ToString();
                    #endregion
                }
                flowLayoutPanel.Controls.Add(labels[0]);

                for (int j = 0; j < 12; j++)
                {
                    flowLayoutPanel.Controls.Add(labels[j + 1]);
                    flowLayoutPanel.Controls.Add(textboxes[j]);
                }

                Button ShowInRichTextBox_Button = new Button();
                ShowInRichTextBox_Button.Click += ShowInRichTextBox_Click;
                ShowInRichTextBox_Button.Text = "To Unit tab";
                ShowInRichTextBox_Button.AutoSize = true;
                ShowInRichTextBox_Button.Tag = i;

                Button EditAnimal_Button = new Button();
                EditAnimal_Button.Click += EditAnimal_Click;
                EditAnimal_Button.Text = "Edit animal info";
                EditAnimal_Button.AutoSize = true;
                EditAnimal_Button.Tag = i;

                Button DeleteAnimal_Button = new Button();
                DeleteAnimal_Button.Click += DeleteAnimal_Click;
                DeleteAnimal_Button.Text = "Delete animal";
                DeleteAnimal_Button.AutoSize = true;
                DeleteAnimal_Button.Tag = i;

                flowLayoutPanel.Controls.Add(ShowInRichTextBox_Button);
                flowLayoutPanel.Controls.Add(EditAnimal_Button);
                flowLayoutPanel.Controls.Add(DeleteAnimal_Button);
                splitContainer1.Panel2.Controls.Add(flowLayoutPanel);
            }
        }

        private void DeleteAnimal_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            int SelectedIndex = int.Parse(Sender.Tag.ToString());
            AddedAnimalList.RemoveAt(SelectedIndex);
            ShowAnimals();
        }

        private void EditAnimal_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            int SelectedIndex = int.Parse(Sender.Tag.ToString());

            string[] values = new string[12];
            for (int i = 0; i < values.Length; i++)
            {
                string controlName = "Value_" + SelectedIndex.ToString() + "_" + i.ToString();
                TextBox foundControl = (TextBox)splitContainer1.Panel2.Controls.Find(controlName, true).FirstOrDefault();
                values[i] = foundControl.Text;
            }
            Animal CurrentAnimal = AddedAnimalList[SelectedIndex];
            if (CurrentAnimal.GetType().Name == "BlueTit")
            {
                BlueTit temp = new BlueTit(values[0], int.Parse(values[1]), values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11]);
                AddedAnimalList.RemoveAt(SelectedIndex);
                AddedAnimalList.Insert(SelectedIndex, temp);
            }
            else if (CurrentAnimal.GetType().Name == "Lion")
            {

                Lion temp = new Lion(values[0], int.Parse(values[1]), values[2], values[3], values[4], values[5], Double.Parse(values[6]), values[7], values[8], values[9], values[10], Double.Parse(values[11]));
                AddedAnimalList.RemoveAt(SelectedIndex);
                AddedAnimalList.Insert(SelectedIndex, temp);
            }
            else if (CurrentAnimal.GetType().Name == "Dolphin")
            {
                Dolphin temp = new Dolphin(values[0], int.Parse(values[1]), values[2], values[3], values[4], values[5], Double.Parse(values[6]), values[7], values[8], values[9], values[10], Double.Parse(values[11]));
                AddedAnimalList.RemoveAt(SelectedIndex);
                AddedAnimalList.Insert(SelectedIndex, temp);
            }
            ShowAnimals();
        }

        private void ShowInRichTextBox_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            int SelectedIndex = int.Parse(Sender.Tag.ToString());
            Animal CurrentAnimal = AddedAnimalList[SelectedIndex];
            RichTextBox1.Text = CurrentAnimal.GetInformation();
        }

        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
            Animal CurrentAnimal = new Animal("Name", 0, "Gender", "Habitat");
            //Animal

            if (comboBox1.SelectedIndex >= 0)
            {
                string selectedClass = comboBox1.SelectedItem as string;
                string name = NameTextBox.Text;
                int age;
                if (!int.TryParse(AgeTextBox.Text, out age))
                {
                    MessageBox.Show("Введіть коректний вік.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string gender = GenderTextBox.Text;
                string habitat = HabitatTextBox.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    //Bird
                    string wings = Base1.Text;
                    string beak = Base2.Text;
                    string flightType = Base3.Text;
                    string featherColor = Base4.Text;
                    //Sinitsya
                    string dietType = Unique1.Text;
                    string size = Unique2.Text;
                    string family = Unique3.Text;
                    string migrationRoute = Unique4.Text;
                    CurrentAnimal = new BlueTit(name, age, gender, habitat, wings, beak, flightType, featherColor, dietType, size, family, migrationRoute);
                }
                else
                {
                    //Animal
                    string legs = Base1.Text;
                    string tail = Base2.Text;
                    double toothDiameter;
                    if (!double.TryParse(Base3.Text, out toothDiameter))
                    {
                        MessageBox.Show("Введіть коректний діаметр зубів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string furColors = Base4.Text;
                    if (comboBox1.SelectedIndex == 1)
                    {
                        //Lion
                        string feedingType = Unique1.Text;
                        string maneSize = Unique2.Text;
                        string socialStructure = Unique3.Text;
                        double bodyWeight;
                        if (!double.TryParse(Unique4.Text, out bodyWeight))
                        {
                            MessageBox.Show("Введіть коректну масу тіла.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        CurrentAnimal = new Lion(name, age, gender, habitat, legs, tail, toothDiameter, furColors, feedingType, maneSize, socialStructure, bodyWeight);
                    }
                    else
                    {
                        //Dolphin
                        string swimmingStyle = Unique1.Text;
                        string finSize = Unique2.Text;
                        string communication = Unique3.Text;
                        double averageSpeed;
                        if (!double.TryParse(Unique4.Text, out averageSpeed))
                        {
                            MessageBox.Show("Введіть коректну середню швидкість.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        CurrentAnimal = new Dolphin(name, age, gender, habitat, legs, tail, toothDiameter, furColors, swimmingStyle, finSize, communication, averageSpeed);
                    }
                }
                AddedAnimalList.Add(CurrentAnimal);
                ShowAnimals();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                NameTextBox.PlaceholderText = "";
                AgeTextBox.PlaceholderText = "";
                GenderTextBox.PlaceholderText = "";
                HabitatTextBox.PlaceholderText = "";
                Base1.PlaceholderText = "";
                Base2.PlaceholderText = "";
                Base3.PlaceholderText = "";
                Base4.PlaceholderText = "";
                Unique1.PlaceholderText = "";
                Unique2.PlaceholderText = "";
                Unique3.PlaceholderText = "";
                Unique4.PlaceholderText = "";

            }
            else if (comboBox1.SelectedIndex == 0)
            {
                NameTextBox.PlaceholderText = "Name";
                AgeTextBox.PlaceholderText = "Age";
                GenderTextBox.PlaceholderText = "Gender";
                HabitatTextBox.PlaceholderText = "Habitat";
                Base1.PlaceholderText = "Wings";
                Base2.PlaceholderText = "Beak";
                Base3.PlaceholderText = "Flight type";
                Base4.PlaceholderText = "Feather color";
                Unique1.PlaceholderText = "Diet type";
                Unique2.PlaceholderText = "Size";
                Unique3.PlaceholderText = "Family";
                Unique4.PlaceholderText = "Migration route";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                NameTextBox.PlaceholderText = "Name";
                AgeTextBox.PlaceholderText = "Age";
                GenderTextBox.PlaceholderText = "Gender";
                HabitatTextBox.PlaceholderText = "Habitat";
                Base1.PlaceholderText = "Legs";
                Base2.PlaceholderText = "Tail";
                Base3.PlaceholderText = "Tooth diameter";
                Base4.PlaceholderText = "Fur color";
                Unique1.PlaceholderText = "Feeding type";
                Unique2.PlaceholderText = "Mane size";
                Unique3.PlaceholderText = "Social structure";
                Unique4.PlaceholderText = "Body weight";
            }
            else
            {
                NameTextBox.PlaceholderText = "Name";
                AgeTextBox.PlaceholderText = "Age";
                GenderTextBox.PlaceholderText = "Gender";
                HabitatTextBox.PlaceholderText = "Habitat";
                Base1.PlaceholderText = "Legs";
                Base2.PlaceholderText = "Tail";
                Base3.PlaceholderText = "Tooth diameter";
                Base4.PlaceholderText = "Fur color";
                Unique1.PlaceholderText = "Swimming style";
                Unique2.PlaceholderText = "Fin size";
                Unique3.PlaceholderText = "Communication";
                Unique4.PlaceholderText = "Average speed";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\xxxse\\Desktop\\Технологія розробки програмного забезпечення\\Laba 7\\Laba 7 TRPZ\\Laba 7 TRPZ\\SavingFile.txt";
            File.WriteAllText(filePath, "");
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in AddedAnimalList)
                {
                    writer.Write($"{item.GetInformation()}\n");
                }
                MessageBox.Show($"Animal information saved in file with path: {filePath}", "Saving to file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void OutsideShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RichTextBox1.Text, $"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}