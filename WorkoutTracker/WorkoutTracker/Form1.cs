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
            // TODO: This line of code loads data into the 'dbWorkoutTrackerDataSet.tblLift' table. You can move, or remove it, as needed.
            this.tblLiftTableAdapter.Fill(this.dbWorkoutTrackerDataSet.tblLift);
            // TODO: This line of code loads data into the 'dbWorkoutTrackerDataSet.tblLiftSet' table. You can move, or remove it, as needed.
            this.tblLiftSetTableAdapter.Fill(this.dbWorkoutTrackerDataSet.tblLiftSet);
            // TODO: This line of code loads data into the 'dbWorkoutTrackerDataSet.tblWorkout' table. You can move, or remove it, as needed.
            this.tblWorkoutTableAdapter.Fill(this.dbWorkoutTrackerDataSet.tblWorkout);

            int workoutID = getLatestWorkout();
            displayData(workoutID);
        }

        private int getLatestWorkout()
        {
            int workoutID = 0;
            string workoutName = "";
            DateTime workoutDate = DateTime.Now;

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

            lblWorkoutName.Text = workoutName;
            lblWorkoutDate.Text = workoutDate.ToShortDateString();

            return workoutID;
        }

        private void displayData(int workoutID)
        {
            //try to get it so that it doesn't display the same lift name multiple times
            lstViewWorkout.Items.Clear();
            try
            {
                foreach (DataRow row in this.tblLiftSetTableAdapter.GetDataForSpecificWorkout(workoutID).Rows)
                {
                    string liftName = row.ItemArray[7].ToString();
                    string liftWeight = row.ItemArray[3].ToString();
                    string liftSets = row.ItemArray[5].ToString();
                    string liftReps = row.ItemArray[6].ToString();

                    bool liftKG = Convert.ToBoolean(row.ItemArray[4]);

                    if(liftKG == true)
                    {
                        liftWeight = liftWeight + "kg";
                    }
                    else
                    {
                        liftWeight = liftWeight + "lbs";
                    }

                    lstViewWorkout.Items.Add(liftName);
                    int num = lstViewWorkout.Items.Count - 1;
                    lstViewWorkout.Items[num].SubItems.Add(liftWeight);
                    lstViewWorkout.Items[num].SubItems.Add(liftSets);
                    lstViewWorkout.Items[num].SubItems.Add(liftReps);

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
