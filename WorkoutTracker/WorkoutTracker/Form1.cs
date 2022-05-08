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
            displayWorkouts();
            lblWorkoutName.Visible = false;
            lblWorkoutDate.Visible = false;
            lstViewLiftSets.Visible = false;

            btnViewWorkouts.BackColor = Color.White;
            btnAddWorkout.BackColor = Color.White;
            btnLiftsList.BackColor = Color.White;
        }

        private void displayWorkouts()
        {
            //function to display all the workout in the list view
            lstViewWorkouts.Items.Clear();

            //sql returns the records in tblWorkout in descending date order
            try
            {
                foreach (DataRow row in this.tblWorkoutTableAdapter.GetDataOrderByDateDesc().Rows)
                {
                    int workoutID = Convert.ToInt32(row.ItemArray[0]);
                    string workoutName = row.ItemArray[1].ToString();
                    DateTime workoutDate = Convert.ToDateTime(row.ItemArray[2]);

                    //adds workout details to the list view. WorkoutID will be invisible as there's no 3rd column
                    lstViewWorkouts.Items.Add(workoutName);
                    int n = lstViewWorkouts.Items.Count-1;
                    lstViewWorkouts.Items[n].SubItems.Add(workoutDate.ToShortDateString());
                    lstViewWorkouts.Items[n].SubItems.Add(workoutID.ToString());
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void displayLiftSets(int workoutID)
        {
            //function to display the lifts done in the most recent workout in list view
            lstViewLiftSets.Items.Clear();

            //sql returns the records in tblLiftSet with the specific workoutID and the name of the lift
            try
            {
                foreach (DataRow row in this.tblLiftSetTableAdapter.GetDataForSpecificWorkout(workoutID).Rows)
                {
                    string liftName = row.ItemArray[7].ToString();
                    string liftWeight = row.ItemArray[3].ToString();
                    string liftSets = row.ItemArray[5].ToString();
                    string liftReps = row.ItemArray[6].ToString();

                    //whether or not the weight is in kg or lbs is stored as a boolean so "kg" or "lbs" is added to the end of the weight string
                    bool liftKG = Convert.ToBoolean(row.ItemArray[4]);
                    if(liftKG == true)
                    {
                        liftWeight = liftWeight + "kg";
                    }
                    else
                    {
                        liftWeight = liftWeight + "lbs";
                    }

                    //adds lift details to the list view
                    lstViewLiftSets.Items.Add(liftName);
                    int n = lstViewLiftSets.Items.Count - 1;
                    lstViewLiftSets.Items[n].SubItems.Add(liftWeight);
                    lstViewLiftSets.Items[n].SubItems.Add(liftSets);
                    lstViewLiftSets.Items[n].SubItems.Add(liftReps);

                }

                //removes where the liftName is written multiple times next to eachother in the list view
                int m = lstViewLiftSets.Items.Count;
                string currentLiftName = "";
                for(int i = 0; i<m; i++)
                {
                    if(lstViewLiftSets.Items[i].Text == currentLiftName)
                    {
                        lstViewLiftSets.Items[i].Text = " ";
                    }
                    else
                    {
                        currentLiftName = lstViewLiftSets.Items[i].Text;
                    }
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnViewWorkouts_Click(object sender, EventArgs e)
        {
            lblSubTitle.Text = btnViewWorkouts.Text;
            btnViewWorkouts.Enabled = false;
            btnAddWorkout.Enabled = true;
            btnLiftsList.Enabled = true;
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            lblSubTitle.Text = btnAddWorkout.Text;
            btnViewWorkouts.Enabled = true;
            btnAddWorkout.Enabled = false;
            btnLiftsList.Enabled = true;
        }

        private void btnLiftsList_Click(object sender, EventArgs e)
        {
            lblSubTitle.Text = btnLiftsList.Text;
            btnViewWorkouts.Enabled = true;
            btnAddWorkout.Enabled = true;
            btnLiftsList.Enabled = false;
        }

        private void lstViewWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewWorkouts.SelectedItems.Count != 0)
            {
                lblWorkoutName.Text = lstViewWorkouts.SelectedItems[0].SubItems[0].Text;
                lblWorkoutDate.Text = lstViewWorkouts.SelectedItems[0].SubItems[1].Text;
                int workoutID = Convert.ToInt32(lstViewWorkouts.SelectedItems[0].SubItems[2].Text);
                displayLiftSets(workoutID);
                lblWorkoutName.Visible = true;
                lblWorkoutDate.Visible = true;
                lstViewLiftSets.Visible = true;
            }
            else
            {
                lblWorkoutName.Visible = false;
                lblWorkoutDate.Visible = false;
                lstViewLiftSets.Visible = false;
            }
        }
    }
}
