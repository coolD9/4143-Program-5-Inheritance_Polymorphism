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
            // This should just enable the textbox and buttons for the object type
        }

        private void InstantObjectBtn_Click(object sender, EventArgs e)
        {
            // THis should create the object using the data entered and using the object constructor
        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            // This should enable components based on the type of object selected
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            // call the move method
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            // call the rotate method
        }

        private void ClassificationBtn_Click(object sender, EventArgs e)
        {
            // call the classification method
        }

        private void SampleBtn_Click(object sender, EventArgs e)
        {
            // call the sample method
        }

        private void TravelTimeBtn_Click(object sender, EventArgs e)
        {
            // calls the TravelTime method using the values from the textboxes
        }
    }
}
