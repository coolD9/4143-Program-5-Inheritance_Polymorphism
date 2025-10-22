using SpaceObjectsLib;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Program5SpaceObjects
{
    public partial class SpaceObjectForm : Form
    {
        private SpaceObject[] spaceObjects = new SpaceObject[10];
        private int objectCount = 0;
        private SpaceObject currentObject;
        public string selectedType;


        public SpaceObjectForm()
        {
            InitializeComponent();
            DisableMainButtons();
        }

        public void DisableMainButtons()
        {
            TypeBox.Enabled = false;
            TypeBtn.Enabled = false;
            InstantObjectBtn.Enabled = false;
            NameBox.Enabled = false;
            XBox.Enabled = false;
            YBox.Enabled = false;
            ZBox.Enabled = false;
            RadBox.Enabled = false;
            TempBox.Enabled = false;
            ArmBox.Enabled = false;
            HeightBox.Enabled = false;
            PLBox.Enabled = false;
            SpeedBox.Enabled = false;
            moonBox.Enabled = false;
            MoveBtn.Enabled = false;
            RotateBtn.Enabled = false;
            ClassificationBtn.Enabled = false;
            SampleBtn.Enabled = false;
            TravelTimeBtn.Enabled = false;
            NewXBox.Enabled = false;
            NewYBox.Enabled = false;
            NewZBox.Enabled = false;
            SampleBox.Enabled = false;
        }

        public void DisableDataComponents()
        {
            TypeBox.Enabled = false;
            InstantObjectBtn.Enabled = false;
            NameBox.Enabled = false;
            XBox.Enabled = false;
            YBox.Enabled = false;
            ZBox.Enabled = false;
            RadBox.Enabled = false;
            TempBox.Enabled = false;
            ArmBox.Enabled = false;
            HeightBox.Enabled = false;
            PLBox.Enabled = false;
            SpeedBox.Enabled = false;
            moonBox.Enabled = false;
            SampleBox.Enabled = false;
        }

        public void EnablePrimeComponents()
        {
            NameBox.Enabled = true;
            XBox.Enabled = true;
            YBox.Enabled = true;
            ZBox.Enabled = true;
            InstantObjectBtn.Enabled = true;
        }

        public void EnableTypeComponents()
        {
            TypeBox.Enabled = true;
            TypeBtn.Enabled = true;
        }
        public void DisableTypeComponents()
        {
            TypeBox.Enabled = false;
            TypeBtn.Enabled = false;
        }

        private void CreateSOBtn_Click(object sender, EventArgs e)
        {
            // This should just enable the textbox and buttons for the object type
            CreateSOBtn.Enabled = false;
            EnableTypeComponents();
        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            // This should enable components based on the type of object selected
            if (TypeBox.Text == "Star")
            {
                selectedType = TypeBox.Text;
                EnablePrimeComponents();
                DisableTypeComponents();
                RadBox.Enabled = true;
                TempBox.Enabled = true;
            }
            else if (TypeBox.Text == "Planet")
            {
                selectedType = TypeBox.Text;
                EnablePrimeComponents();
                DisableTypeComponents();
                RadBox.Enabled = true;
                moonBox.Enabled = true;
            }
            else if (TypeBox.Text == "Spaceship")
            {
                selectedType = TypeBox.Text;
                EnablePrimeComponents();
                DisableTypeComponents();
                SpeedBox.Enabled = true;
                PLBox.Enabled = true;
            }
            else if (TypeBox.Text == "Earthling")
            {
                selectedType = TypeBox.Text;
                EnablePrimeComponents();
                DisableTypeComponents();
                HeightBox.Enabled = true;
            }
            else if (TypeBox.Text == "Alien")
            {
                selectedType = TypeBox.Text;
                EnablePrimeComponents();
                DisableTypeComponents();
                HeightBox.Enabled = true;
                ArmBox.Enabled = true;
            }
            else if (TypeBox.Text == "Probe")
            {
                selectedType = TypeBox.Text;
                EnablePrimeComponents();
                DisableTypeComponents();
                SampleBox.Enabled = true;
            }
            else
                MessageBox.Show("Invalid type! Please enter a valid SpaceObject type (Star, Planet, Probe, etc.)\nRemember to capitalize!");
        }

        private void InstantObjectBtn_Click(object sender, EventArgs e)
        {
            // THis should create the object using the data entered and using the object constructor
            CreateSOBtn.Enabled = true;
            DisableDataComponents();


            SpaceObject spaceObj = null; // will hold whatever object we create


            try
            {
                // Read basic inputs (all objects have at least these)
                string name = NameBox.Text;
                double x = Convert.ToDouble(XBox.Text);
                double y = Convert.ToDouble(YBox.Text);
                double z = Convert.ToDouble(ZBox.Text);

                switch (selectedType)
                {
                    case "Star":
                        int radius = Convert.ToInt32(RadBox.Text);
                        int temp = Convert.ToInt32(TempBox.Text);
                        spaceObj = new Star(name, radius, temp, x, y, z);
                        ClassificationBtn.Enabled = true;
                        break;

                    case "Planet":
                        int moons = Convert.ToInt32(moonBox.Text);
                        int planetRadius = Convert.ToInt32(RadBox.Text);
                        spaceObj = new Planet(name, planetRadius, moons, x, y, z);
                        RotateBtn.Enabled = true;
                        break;

                    case "Spaceship":
                        int payload = Convert.ToInt32(PLBox.Text);
                        int speed = Convert.ToInt32(SpeedBox.Text);
                        spaceObj = new SpaceShip(name, payload, speed, x, y, z);
                        TravelTimeBtn.Enabled = true;
                        NewXBox.Enabled = true;
                        NewYBox.Enabled = true;
                        NewZBox.Enabled = true;
                        break;

                    case "Probe":
                        int samples = Convert.ToInt32(SampleBox.Text);
                        spaceObj = new Probe(name, samples, x, y, z);
                        SampleBtn.Enabled = true;
                        break;

                    case "Earthling":
                        double heightE = Convert.ToDouble(HeightBox.Text);
                        spaceObj = new Earthling(name, heightE, x, y, z);
                        MoveBtn.Enabled = true;
                        break;

                    case "Alien":
                        int arms = Convert.ToInt32(ArmBox.Text);
                        double heightA = Convert.ToDouble(HeightBox.Text);
                        spaceObj = new Alien(name, arms, heightA, x, y, z);
                        MoveBtn.Enabled = true;
                        break;
                }

                // Show the object's info
                SpaceObjectReadout.Text = spaceObj.GetInfo();

                currentObject = spaceObj;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nPlease check your inputs.");
            }
        }

        

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            // call the move method
            if (currentObject is Being being)
                being.Move();
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            // call the rotate method
            if (currentObject is Planet planet)
                ObjectActionLabel.Text = planet.Rotation();
        }

        private void ClassificationBtn_Click(object sender, EventArgs e)
        {
            // call the classification method
            if (currentObject is Star star)
            {
                string StarClass = star.DetermineClassification();
                ObjectActionLabel.Text = $"Star Classification: {StarClass}";
            }
        }

        private void SampleBtn_Click(object sender, EventArgs e)
        {
            // call the sample method
            if (currentObject is Probe probe)
                probe.TakeSample();
        }

        private void TravelTimeBtn_Click(object sender, EventArgs e)
        {
            // calls the TravelTime method using the values from the textboxes
            if (currentObject is SpaceShip ship)
            {
                int dX = Convert.ToInt32(NewXBox.Text);
                int dY = Convert.ToInt32(NewYBox.Text);
                int dZ = Convert.ToInt32(NewZBox.Text);
                double Time = ship.StarTravel(dX, dY, dZ);
                ObjectActionLabel.Text = $"Ship will reach destination in {Time} hours.";
            }
        }
    }
}


