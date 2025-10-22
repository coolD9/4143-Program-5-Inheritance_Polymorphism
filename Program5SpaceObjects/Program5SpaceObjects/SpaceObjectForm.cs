using SpaceObjectsLib;
using System;
using System.Windows.Forms;

namespace Program5SpaceObjects
{
    public partial class SpaceObjectForm : Form
    {
        private SpaceObject[] spaceObjects = new SpaceObject[10];
        private int objectCount = 0;

        public SpaceObjectForm()
        {
            InitializeComponent();
        }

        private void CreateSOBtn_Click(object sender, EventArgs e)
        {
            //.TextBox = true; 
        }

        private void InstantObjectBtn_Click(object sender, EventArgs e)
        {
            // Get what the user typed
            string type = objectTypeTextBox.Text.Trim().ToLower();

            SpaceObject spaceObj = null; // will hold whatever object we create

            try
            {
                // Read basic inputs (all objects have at least these)
                string name = nameTextBox.Text;
                double x = Convert.ToDouble(xTextBox.Text);
                double y = Convert.ToDouble(yTextBox.Text);
                double z = Convert.ToDouble(zTextBox.Text);

                switch (type)
                {
                    case "Star":
                        int radius = Convert.ToInt32(radiusTextBox.Text);
                        int temp = Convert.ToInt32(tempTextBox.Text);
                        spaceObj = new Star(name, radius, temp, x, y, z);
                        break;

                    case "Planet":
                        int moons = Convert.ToInt32(moonsTextBox.Text);
                        int planetRadius = Convert.ToInt32(radiusTextBox.Text);
                        spaceObj = new Planet(name, planetRadius, moons, x, y, z);
                        break;

                    case "Spaceship":
                        int payload = Convert.ToInt32(payloadTextBox.Text);
                        int speed = Convert.ToInt32(speedTextBox.Text);
                        spaceObj = new SpaceShip(name, payload, speed, x, y, z);
                        break;
        
                    case "Probe":
                        int samples = Convert.ToInt32(samplesTextBox.Text);
                        spaceObj = new Probe(name, samples, x, y, z);
                        break;
        
                    case "Earthling":
                        int heightE = Convert.ToInt32(heightTextBox.Text);
                        spaceObj = new Earthling(name, heightE, x, y, z);
                        break;
        
                    case "Alien":
                        int arms = Convert.ToInt32(armsTextBox.Text);
                        int heightA = Convert.ToInt32(heightTextBox.Text);
                        spaceObj = new Alien(name, arms, heightA, x, y, z);
                        break;                        
                }

                // Show the object's info
                displayLabel.Text = spaceObj.GetInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nPlease check your inputs.");
            }
        }


        private void TypeBtn_Click(object sender, EventArgs e)
        {
            if (TypeBox.Text == "Star")

            else if (TypeBox.Text == "Planet")

            else if (TypeBox.Text == "SpaceShip")

            else if (TypeBox.Text == "Earthling")

            else if (TypeBox.Text == "Alien")

            else if (TypeBox.Text == "Probe")

            else {
                MessageBox.Show("Invalid type! Please enter a valid SpaceObject type (Star, Planet, Probe, etc.)\nRemember to capitalize!");
            }
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            this.Move();
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            this.Rotation(); 
        }

        private void ClassificationBtn_Click(object sender, EventArgs e)
        {
            this.DetermineClassification();
        }

        private void SampleBtn_Click(object sender, EventArgs e)
        {
            this.TakeSample();
        }

        private void TravelTimeBtn_Click(object sender, EventArgs e)
        {
            int dX = Convert.ToInt32(NewXBox.Text);
            int dY = Convert.ToInt32(NewYBox.Text);
            int dZ = Convert.ToInt32(NewZBox.Text);
            this.StarTravel(dX, dY, dZ);
        }
    }
}


