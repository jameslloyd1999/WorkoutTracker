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

        private void addWorkoutView()
        {
            //function to reset the Add Workout View
            txtWorkoutName.Text = "";
            dtpAddNew.Value = DateTime.Now;
            flpAddNew.Controls.Clear();
            cmbLiftsFill();
            addNewSetRow();
        }

        private void addNewSetRow()
        {
            //function to add a new row on the flowlayout panel to be filled
            //n is the number of rows already
            int n = flpAddNew.Controls.Count / 6;

            //combobox for liftNames. Takes these names from cmbLifts
            ComboBox cmb = new ComboBox();
            foreach (string liftName in cmbLifts.Items)
            {
                if (liftName != "ADD NEW")
                {
                    cmb.Items.Add(liftName);
                }
                
            }
            //takes the selectedIndex of the liftName combobox above it if there is one
            if(n != 0)
            {
                cmb.SelectedIndex = Convert.ToInt32(flpAddNew.Controls[6 * (n - 1)].Tag);
            }
            else
            {
                cmb.SelectedIndex = 0;
            }
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Tag = cmb.SelectedIndex;
            cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;
            flpAddNew.Controls.Add(cmb);

            //textbox for weight
            TextBox txt1 = new TextBox();
            txt1.Size = new Size(60, 30);
            txt1.Name = "txtFlpDecimal";
            flpAddNew.Controls.Add(txt1);

            //combobox for kg or lbs
            ComboBox cmb2 = new ComboBox();
            cmb2.Items.Add("kg");
            cmb2.Items.Add("lbs");
            //takes the selectedIndex of the kg or lbs combobox above it if there is one
            if (n != 0)
            {
                if (flpAddNew.Controls[6*(n-1)+2].Text == "kg")
                {
                    cmb2.SelectedIndex = 0;
                }
                else
                {
                    cmb2.SelectedIndex = 1;
                }
            }
            else
            {
                cmb2.SelectedIndex = 0;
            }
            cmb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb2.Size = new Size(50, 30);
            flpAddNew.Controls.Add(cmb2);

            //textbox for sets
            TextBox txt2 = new TextBox();
            txt2.Size = new Size(40, 30);
            txt2.Name = "txtFlpInt";
            flpAddNew.Controls.Add(txt2);

            //textbox for reps
            TextBox txt3 = new TextBox();
            txt3.Size = new Size(40, 30);
            txt3.Name = "txtFlpInt";
            flpAddNew.Controls.Add(txt3);

            //button for delete row
            Button btn = new Button();
            btn.Size = new Size(20, 20);
            btn.Text = "x";
            btn.Font = new Font(btn.Font.FontFamily, 8);
            btn.Click += btn_click;
            flpAddNew.Controls.Add(btn);
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sets the tag of a liftName combobox in the the flowLayoutPanel to the selected index whenever it is changed
            (sender as ComboBox).Tag = (sender as ComboBox).SelectedIndex;
        }

        private void btn_click(object sender, EventArgs e)
        {
            //code to remove row from new workout when delete row button clicked
            //first finds the position in the flp where the delete button was clicked
            int n = flpAddNew.Controls.Count;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (flpAddNew.Controls[i] == (sender as Button))
                {
                    j = i;
                }
            }
            //deletes the row
            for (int i = 0; i < 6; i++)
            {
                flpAddNew.Controls.Remove(flpAddNew.Controls[j - 5]);
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

            txtWorkoutName.Visible = false;
            dtpAddNew.Visible = false;
            flpAddNew.Visible = false;
            btnNewRow.Visible = false;
            btnInsertWorkout.Visible = false;

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

            addWorkoutView();
            txtWorkoutName.Visible = true;
            dtpAddNew.Visible = true;
            flpAddNew.Visible = true;
            btnNewRow.Visible = true;
            btnInsertWorkout.Visible = true;

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

            txtWorkoutName.Visible = false;
            dtpAddNew.Visible = false;
            flpAddNew.Visible = false;
            btnNewRow.Visible = false;
            btnInsertWorkout.Visible = false;

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

        private void btnNewRow_Click(object sender, EventArgs e)
        {
            addNewSetRow();
        }

        private void btnInsertWorkout_Click(object sender, EventArgs e)
        {
            //function to add the workout and lifts done

            string workoutName = txtWorkoutName.Text;
            DateTime workoutDate = Convert.ToDateTime( dtpAddNew.Text);

            //checks that the appropriate data is in each field in the flowLayoutPanel
            bool filled = true;
            foreach (Control c in flpAddNew.Controls)
            {
                //check that it's not empty
                if (c.Text == "")
                {
                    filled = false;
                }
                //checks that the weight is a decimal
                else if (c.Name == "txtFlpDecimal" && !decimal.TryParse(c.Text, out decimal value))
                {
                    filled = false;
                }
                //checks that sets and reps are ints
                else if (c.Name == "txtFlpInt" && !int.TryParse(c.Text, out int value2))
                {
                    filled = false;
                }
            }

            if (workoutName != "" && filled)
            {
                try
                {
                    //sql insert into tblWorkout
                    this.tblWorkoutTableAdapter.InsertQuery(workoutName,workoutDate);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                //gets the workoutID of the most recent workout which is the one just inserted
                int workoutID = 0;
                try
                {
                    foreach (DataRow row in this.tblWorkoutTableAdapter.GetData().Rows)
                    {
                        workoutID = Convert.ToInt32(row.ItemArray[0]);
                    }

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                //n is number of rows in flowLayoutPanel
                int n = flpAddNew.Controls.Count / 6;

                //loops through each row getting liftID, weight, kg, sets, reps from the FlowLayoutPanel
                for (int i = 0; i < n; i++)
                {
                    //gets the liftID from cmbLifts valueMember using index of flowLayoutPanel liftName combobox
                    string cmbValue = cmbLifts.ValueMember;
                    string[] liftIDs = cmbValue.Split(' ');
                    int liftID = Convert.ToInt32(liftIDs[Convert.ToInt32(flpAddNew.Controls[6 * i].Tag)]);

                    decimal weight = Convert.ToDecimal(flpAddNew.Controls[6 * i + 1].Text);

                    bool kg = true;
                    if (flpAddNew.Controls[6 * i + 2].Text != "kg")
                    {
                        kg = false;
                    }

                    int sets = Convert.ToInt32(flpAddNew.Controls[6 * i + 3].Text);
                    int reps = Convert.ToInt32(flpAddNew.Controls[6 * i + 4].Text);                    

                    try
                    {
                        //sql insert into tblLiftSet
                        this.tblLiftSetTableAdapter.InsertQuery(workoutID, liftID, weight, kg, sets, reps);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    
                }
                //resets this view
                addWorkoutView();
                cbLiftEdit.Visible = false;
            }

            

        }
    }
}
