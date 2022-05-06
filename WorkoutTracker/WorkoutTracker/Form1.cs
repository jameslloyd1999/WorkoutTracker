using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblWorkoutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblWorkoutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbWorkoutTrackerDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbWorkoutTrackerDataSet.tblWorkout' table. You can move, or remove it, as needed.
            this.tblWorkoutTableAdapter.Fill(this.dbWorkoutTrackerDataSet.tblWorkout);

        }
    }
}
