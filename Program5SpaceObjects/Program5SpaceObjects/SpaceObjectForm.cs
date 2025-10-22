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

        
    }
}
