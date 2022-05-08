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


            if(lstViewWorkouts.Items.Count != 0)
            {
                lblWorkoutName.Text = lstViewWorkouts.Items[0].SubItems[0].Text;
                lblWorkoutDate.Text = lstViewWorkouts.Items[0].SubItems[1].Text;
                int workoutID = Convert.ToInt32(lstViewWorkouts.Items[0].SubItems[2].Text);
                displayLiftSets(workoutID);
            }

            cmbLiftsFill();
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

        private void displayLiftsListLstView(int liftID)
        {
            //function to display the lifts done in the lifts list list view
            lstViewLiftsList.Items.Clear();

            try
            {
                //sql returns the records in tblLiftSet with the specific liftID and the name and date of the workout
                foreach (DataRow row in this.tblLiftSetTableAdapter.GetDataForSpecificLift(liftID).Rows)
                {
                    string workoutName = row.ItemArray[7].ToString();
                    DateTime workoutDate = Convert.ToDateTime(row.ItemArray[8]);
                    string liftWeight = row.ItemArray[3].ToString();
                    string liftSets = row.ItemArray[5].ToString();
                    string liftReps = row.ItemArray[6].ToString();

                    //whether or not the weight is in kg or lbs is stored as a boolean so "kg" or "lbs" is added to the end of the weight string
                    bool liftKG = Convert.ToBoolean(row.ItemArray[4]);
                    if (liftKG == true)
                    {
                        liftWeight = liftWeight + "kg";
                    }
                    else
                    {
                        liftWeight = liftWeight + "lbs";
                    }

                    //adds lift details to the list view
                    lstViewLiftsList.Items.Add(workoutName);
                    int n = lstViewLiftsList.Items.Count - 1;
                    lstViewLiftsList.Items[n].SubItems.Add(workoutDate.ToShortDateString());
                    lstViewLiftsList.Items[n].SubItems.Add(liftWeight);
                    lstViewLiftsList.Items[n].SubItems.Add(liftSets);
                    lstViewLiftsList.Items[n].SubItems.Add(liftReps);
                }

                //removes where the workoutName and workoutDate is written multiple times next to eachother in the list view
                int m = lstViewLiftsList.Items.Count;
                string currentWorkoutName = "";
                string currentWorkoutDate = "";
                for (int i = 0; i < m; i++)
                {
                    if (lstViewLiftsList.Items[i].Text == currentWorkoutName && lstViewLiftsList.Items[i].SubItems[0].Text == currentWorkoutDate)
                    {
                        lstViewLiftsList.Items[i].Text = " ";
                        lstViewLiftsList.Items[i].SubItems[0].Text = " ";
                        lstViewLiftsList.Items[i].SubItems[0].Text = " "; //need to fix this
                    }
                    else
                    {
                        currentWorkoutName = lstViewLiftsList.Items[i].Text;
                        currentWorkoutDate = lstViewLiftsList.Items[i].SubItems[0].Text;
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cmbLiftsFill()
        {
            //function to fill the combobox of the lift list with liftNames and put liftIDs as value members
            try
            {
                string liftIDs = "";
                foreach (DataRow row in this.tblLiftTableAdapter.GetData().Rows)
                {
                    int liftID = Convert.ToInt32(row.ItemArray[0]);
                    string liftName = row.ItemArray[1].ToString();

                    liftIDs = liftIDs + row.ItemArray[0].ToString() + " ";

                    cmbLifts.Items.Add(liftName);
                }
                cmbLifts.ValueMember = liftIDs;

                //sets it to be on first item in the list as default
                if(cmbLifts.Items.Count != 0)
                {
                    cmbLifts.SelectedIndex = 0;
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnViewWorkouts_Click(object sender, EventArgs e)
        {
            //changes title at top of form and clickability of buttons at bottom
            lblSubTitle.Text = btnViewWorkouts.Text;
            btnViewWorkouts.Enabled = false;
            btnAddWorkout.Enabled = true;
            btnLiftsList.Enabled = true;

            //changes what is visible in this view
            lstViewWorkouts.Visible = true;
            lstViewLiftSets.Visible = true;
            lblWorkoutName.Visible = true;
            lblWorkoutDate.Visible = true;

            lstViewLiftsList.Visible = false;
            cmbLifts.Visible = false;
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            //changes title at top of form and clickability of buttons at bottom
            lblSubTitle.Text = btnAddWorkout.Text;
            btnViewWorkouts.Enabled = true;
            btnAddWorkout.Enabled = false;
            btnLiftsList.Enabled = true;

            //changes what is visible in this view
            lstViewWorkouts.Visible = false;
            lstViewLiftSets.Visible = false;
            lblWorkoutName.Visible = false;
            lblWorkoutDate.Visible = false;

            lstViewLiftsList.Visible = false;
            cmbLifts.Visible = false;
        }

        private void btnLiftsList_Click(object sender, EventArgs e)
        {
            //changes title at top of form and clickability of buttons at bottom
            lblSubTitle.Text = btnLiftsList.Text;
            btnViewWorkouts.Enabled = true;
            btnAddWorkout.Enabled = true;
            btnLiftsList.Enabled = false;

            //changes what is visible in this view
            lstViewWorkouts.Visible = false;
            lstViewLiftSets.Visible = false;
            lblWorkoutName.Visible = false;
            lblWorkoutDate.Visible = false;

            lstViewLiftsList.Visible = true;
            cmbLifts.Visible = true;
        }

        private void lstViewWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //function called when a workout is selected to be viewed
            if (lstViewWorkouts.SelectedItems.Count != 0)
            {
                lblWorkoutName.Text = lstViewWorkouts.SelectedItems[0].SubItems[0].Text;
                lblWorkoutDate.Text = lstViewWorkouts.SelectedItems[0].SubItems[1].Text;
                int workoutID = Convert.ToInt32(lstViewWorkouts.SelectedItems[0].SubItems[2].Text);
                displayLiftSets(workoutID);
            }
        }

        private void cmbLifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a lift in the lifts combobox is selected finds the liftID
            string cmbValue = cmbLifts.ValueMember;
            string[] liftIDs = cmbValue.Split(' ');
            int liftID = Convert.ToInt32(liftIDs[cmbLifts.SelectedIndex]);
            displayLiftsListLstView(liftID);
        }
    }
}
