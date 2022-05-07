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
            int workoutID = getLatestWorkout();

            //will display the data if the workoutID was not default and will make everything invisible if it was
            if(workoutID != 0)
            {
                displayData(workoutID);
            }
            else
            {
                lblSubTitle.Visible = false;
                lblWorkoutName.Visible = false;
                lblWorkoutDate.Visible = false;
                lstViewWorkout.Visible = false;
            }
            
        }

        private int getLatestWorkout()
        {
            //function to get the workoutID of the most recent workout
            //default values if there are no workouts
            int workoutID = 0;
            string workoutName = "";
            DateTime workoutDate = DateTime.Now;

            //sql function returns all tblWorkout records in date order. The last record in the loop will be the most recent one
            try
            {
                foreach (DataRow row in this.tblWorkoutTableAdapter.GetDataOrderByDate().Rows)
                {
                    workoutID = Convert.ToInt32(row.ItemArray[0]);
                    workoutName = row.ItemArray[1].ToString();
                    workoutDate = Convert.ToDateTime(row.ItemArray[2]);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //displays the name and date of the most recent workout
            lblWorkoutName.Text = workoutName;
            lblWorkoutDate.Text = workoutDate.ToShortDateString();

            return workoutID;
        }

        private void displayData(int workoutID)
        {
            //function to display the lifts done in the most recent workout in list view
            lstViewWorkout.Items.Clear();

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
                    lstViewWorkout.Items.Add(liftName);
                    int n = lstViewWorkout.Items.Count - 1;
                    lstViewWorkout.Items[n].SubItems.Add(liftWeight);
                    lstViewWorkout.Items[n].SubItems.Add(liftSets);
                    lstViewWorkout.Items[n].SubItems.Add(liftReps);

                }

                //removes where the liftName is written multiple times next to eachother in the list view
                int m = lstViewWorkout.Items.Count;
                string currentLiftName = "";
                for(int i = 0; i<m; i++)
                {
                    if(lstViewWorkout.Items[i].Text == currentLiftName)
                    {
                        lstViewWorkout.Items[i].Text = " ";
                    }
                    else
                    {
                        currentLiftName = lstViewWorkout.Items[i].Text;
                    }
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
