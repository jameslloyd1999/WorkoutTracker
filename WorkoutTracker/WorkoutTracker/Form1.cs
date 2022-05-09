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

                //will take the first workout in the listview to be displayed in the other listview
                if (lstViewWorkouts.Items.Count != 0)
                {
                    lblWorkoutName.Text = lstViewWorkouts.Items[0].SubItems[0].Text;
                    lblWorkoutDate.Text = lstViewWorkouts.Items[0].SubItems[1].Text;
                    int workoutID = Convert.ToInt32(lstViewWorkouts.Items[0].SubItems[2].Text);
                    displayLiftSets(workoutID);
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
                int lastLiftID = 0;
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

                    //removes where the liftName is written multiple times next to eachother in the list view
                    int liftID = Convert.ToInt32(row.ItemArray[2]);
                    if (liftID == lastLiftID)
                    {
                        liftName = " ";
                    }
                    else
                    {
                        lastLiftID = liftID;
                    }

                    //adds lift details to the list view
                    lstViewLiftSets.Items.Add(liftName);
                    int n = lstViewLiftSets.Items.Count - 1;
                    lstViewLiftSets.Items[n].SubItems.Add(liftWeight);
                    lstViewLiftSets.Items[n].SubItems.Add(liftSets);
                    lstViewLiftSets.Items[n].SubItems.Add(liftReps);

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

            //sql returns the records in tblLiftSet with the specific liftID and the name and date of the workout
            try
            {
                int lastWorkoutID = 0;
                foreach (DataRow row in this.tblLiftSetTableAdapter.GetDataForSpecificLift(liftID).Rows)
                {
                    string workoutName = row.ItemArray[7].ToString();
                    DateTime workoutDate = Convert.ToDateTime(row.ItemArray[8]);
                    string workoutDateStr = workoutDate.ToShortDateString();
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

                    //removes where the workoutName and workoutDate are written multiple times next to eachother in the list view
                    int workoutID = Convert.ToInt32(row.ItemArray[1]);
                    if (workoutID == lastWorkoutID)
                    {
                        workoutName = " ";
                        workoutDateStr = " ";
                    }
                    else
                    {
                        lastWorkoutID = workoutID;
                    }

                    //adds lift details to the list view
                    lstViewLiftsList.Items.Add(workoutName);
                    int n = lstViewLiftsList.Items.Count - 1;
                    lstViewLiftsList.Items[n].SubItems.Add(workoutDateStr);
                    lstViewLiftsList.Items[n].SubItems.Add(liftWeight);
                    lstViewLiftsList.Items[n].SubItems.Add(liftSets);
                    lstViewLiftsList.Items[n].SubItems.Add(liftReps);
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
            //the values of each item in the combobox to be stored as a string with spaces inbetween
            cmbLifts.Items.Clear();
            cmbLifts.ValueMember = "";
            try
            {
                string liftIDs = "";
                //sql to get all records from tblLift
                foreach (DataRow row in this.tblLiftTableAdapter.GetData().Rows)
                {
                    int liftID = Convert.ToInt32(row.ItemArray[0]);
                    string liftName = row.ItemArray[1].ToString();

                    liftIDs = liftIDs + row.ItemArray[0].ToString() + " ";

                    cmbLifts.Items.Add(liftName);
                }

                //final item in combobox to add new lifts
                cmbLifts.Items.Add("ADD NEW");
                liftIDs = liftIDs + "0";

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

            //changes what is visible in this view and resets that screen
            displayWorkouts();
            lstViewWorkouts.Visible = true;
            lstViewLiftSets.Visible = true;
            lblWorkoutName.Visible = true;
            lblWorkoutDate.Visible = true;
            
            lstViewLiftsList.Visible = false;
            cmbLifts.Visible = false;
            txtLiftEdit.Visible = false;
            btnLiftAdd.Visible = false;
            btnLiftRename.Visible = false;
            btnLiftRemove.Visible = false;
            cbLiftEdit.Visible = false;
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            //changes title at top of form and clickability of buttons at bottom
            lblSubTitle.Text = btnAddWorkout.Text;
            btnViewWorkouts.Enabled = true;
            btnAddWorkout.Enabled = false;
            btnLiftsList.Enabled = true;

            //changes what is visible in this view and resets that screen
            lstViewWorkouts.Visible = false;
            lstViewLiftSets.Visible = false;
            lblWorkoutName.Visible = false;
            lblWorkoutDate.Visible = false;

            lstViewLiftsList.Visible = false;
            cmbLifts.Visible = false;
            txtLiftEdit.Visible = false;
            btnLiftAdd.Visible = false;
            btnLiftRename.Visible = false;
            btnLiftRemove.Visible = false;
            cbLiftEdit.Visible = false;
        }

        private void btnLiftsList_Click(object sender, EventArgs e)
        {
            //changes title at top of form and clickability of buttons at bottom
            lblSubTitle.Text = btnLiftsList.Text;
            btnViewWorkouts.Enabled = true;
            btnAddWorkout.Enabled = true;
            btnLiftsList.Enabled = false;

            //changes what is visible in this view and resets that screeen
            lstViewWorkouts.Visible = false;
            lstViewLiftSets.Visible = false;
            lblWorkoutName.Visible = false;
            lblWorkoutDate.Visible = false;

            cmbLiftsFill();
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
            //when a lift in the lifts combobox is selected first finds the liftID
            string cmbValue = cmbLifts.ValueMember;
            string[] liftIDs = cmbValue.Split(' ');
            int liftID = Convert.ToInt32(liftIDs[cmbLifts.SelectedIndex]);

            //liftID=0 when it's on ADD NEW
            if(liftID == 0)
            {
                cbLiftEdit.Visible = false;
                cbLiftEdit.Checked = false;
                txtLiftEdit.Visible = true;
                txtLiftEdit.Text = "";
                btnLiftAdd.Visible = true;
                lstViewLiftsList.Items.Clear();
            }
            //else for the actual lifts
            else
            {
                txtLiftEdit.Visible = false;
                btnLiftAdd.Visible = false;
                cbLiftEdit.Visible = true;
                cbLiftEdit.Checked = false;
                txtLiftEdit.Text = "";
                displayLiftsListLstView(liftID);
            }
            


        }

        private void btnLiftAdd_Click(object sender, EventArgs e)
        {
            //code to add a new lift to tblLift
            if(txtLiftEdit.Text != "")
            {
                try
                {
                    //sql insert into tblLift
                    this.tblLiftTableAdapter.InsertQuery(txtLiftEdit.Text);
                    cmbLiftsFill();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbLiftEdit_CheckedChanged(object sender, EventArgs e)
        {
            //code for when the checkbox in lift list is changed
            if (cbLiftEdit.Checked == true)
            {
                txtLiftEdit.Visible = true;
                btnLiftRename.Visible = true;
                btnLiftRemove.Visible = true;
                txtLiftEdit.Text = cmbLifts.SelectedItem.ToString();
            }
            else
            {
                txtLiftEdit.Visible = false;
                btnLiftRename.Visible = false;
                btnLiftRemove.Visible = false;
                txtLiftEdit.Text = "";
            }
        }

        private void btnLiftRename_Click(object sender, EventArgs e)
        {
            //code to update a liftName in tblLift
            //first gets liftID from the combobox
            string cmbValue = cmbLifts.ValueMember;
            string[] liftIDs = cmbValue.Split(' ');
            int liftID = Convert.ToInt32(liftIDs[cmbLifts.SelectedIndex]);

            if (txtLiftEdit.Text != "")
            {
                try
                {
                    //sql to update tblLift
                    this.tblLiftTableAdapter.UpdateQuery(txtLiftEdit.Text, liftID);
                    cmbLiftsFill();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLiftRemove_Click(object sender, EventArgs e)
        {
            //code to remove a lift from both tblLift and tblSet
            //first gets liftID from the combobox
            string cmbValue = cmbLifts.ValueMember;
            string[] liftIDs = cmbValue.Split(' ');
            int liftID = Convert.ToInt32(liftIDs[cmbLifts.SelectedIndex]);

            //asks for confirmation as a lot of data may be accidentally deleted
            if(MessageBox.Show("Confirm deletion","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //will first delete all the records in tblLiftSet that have the liftID then from tblLift
                    this.tblLiftSetTableAdapter.DeleteQueryLiftID(liftID);
                    this.tblLiftTableAdapter.DeleteQuery(liftID);
                    cmbLiftsFill();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }                        
        }
    }
}
