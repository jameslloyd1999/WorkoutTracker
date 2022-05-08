namespace WorkoutTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblWorkoutName = new System.Windows.Forms.Label();
            this.lblWorkoutDate = new System.Windows.Forms.Label();
            this.lstViewLiftSets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.btnViewWorkouts = new System.Windows.Forms.Button();
            this.btnLiftsList = new System.Windows.Forms.Button();
            this.lstViewWorkouts = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewLiftsList = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblLifttblLiftSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLifttblLiftSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLifts = new System.Windows.Forms.ComboBox();
            this.tblLiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbWorkoutTrackerDataSet = new WorkoutTracker.dbWorkoutTrackerDataSet();
            this.tblWorkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWorkoutTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblWorkoutTableAdapter();
            this.tableAdapterManager = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager();
            this.tblLiftSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLiftSetTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblLiftSetTableAdapter();
            this.tblLiftTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblLiftTableAdapter();
            this.tblLiftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblLiftBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblLifttblLiftSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLifttblLiftSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(13, 9);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(202, 32);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "View Workouts";
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.AutoSize = true;
            this.lblWorkoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutName.Location = new System.Drawing.Point(411, 47);
            this.lblWorkoutName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(132, 25);
            this.lblWorkoutName.TabIndex = 2;
            this.lblWorkoutName.Text = "workoutName";
            // 
            // lblWorkoutDate
            // 
            this.lblWorkoutDate.AutoSize = true;
            this.lblWorkoutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutDate.Location = new System.Drawing.Point(629, 47);
            this.lblWorkoutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkoutDate.Name = "lblWorkoutDate";
            this.lblWorkoutDate.Size = new System.Drawing.Size(121, 25);
            this.lblWorkoutDate.TabIndex = 3;
            this.lblWorkoutDate.Text = "workoutDate";
            // 
            // lstViewLiftSets
            // 
            this.lstViewLiftSets.BackColor = System.Drawing.SystemColors.Window;
            this.lstViewLiftSets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewLiftSets.FullRowSelect = true;
            this.lstViewLiftSets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewLiftSets.HideSelection = false;
            this.lstViewLiftSets.Location = new System.Drawing.Point(416, 77);
            this.lstViewLiftSets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstViewLiftSets.MultiSelect = false;
            this.lstViewLiftSets.Name = "lstViewLiftSets";
            this.lstViewLiftSets.Size = new System.Drawing.Size(390, 390);
            this.lstViewLiftSets.TabIndex = 4;
            this.lstViewLiftSets.UseCompatibleStateImageBehavior = false;
            this.lstViewLiftSets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lift";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Weight";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sets";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reps";
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.BackColor = System.Drawing.Color.White;
            this.btnAddWorkout.Location = new System.Drawing.Point(178, 485);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(160, 40);
            this.btnAddWorkout.TabIndex = 5;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.UseVisualStyleBackColor = false;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // btnViewWorkouts
            // 
            this.btnViewWorkouts.BackColor = System.Drawing.Color.White;
            this.btnViewWorkouts.Enabled = false;
            this.btnViewWorkouts.Location = new System.Drawing.Point(12, 485);
            this.btnViewWorkouts.Name = "btnViewWorkouts";
            this.btnViewWorkouts.Size = new System.Drawing.Size(160, 40);
            this.btnViewWorkouts.TabIndex = 6;
            this.btnViewWorkouts.Text = "View Workouts";
            this.btnViewWorkouts.UseVisualStyleBackColor = false;
            this.btnViewWorkouts.Click += new System.EventHandler(this.btnViewWorkouts_Click);
            // 
            // btnLiftsList
            // 
            this.btnLiftsList.BackColor = System.Drawing.Color.White;
            this.btnLiftsList.Location = new System.Drawing.Point(344, 485);
            this.btnLiftsList.Name = "btnLiftsList";
            this.btnLiftsList.Size = new System.Drawing.Size(160, 40);
            this.btnLiftsList.TabIndex = 7;
            this.btnLiftsList.Text = "Lifts List";
            this.btnLiftsList.UseVisualStyleBackColor = false;
            this.btnLiftsList.Click += new System.EventHandler(this.btnLiftsList_Click);
            // 
            // lstViewWorkouts
            // 
            this.lstViewWorkouts.BackColor = System.Drawing.SystemColors.Window;
            this.lstViewWorkouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lstViewWorkouts.FullRowSelect = true;
            this.lstViewWorkouts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewWorkouts.HideSelection = false;
            this.lstViewWorkouts.Location = new System.Drawing.Point(19, 77);
            this.lstViewWorkouts.Name = "lstViewWorkouts";
            this.lstViewWorkouts.Size = new System.Drawing.Size(390, 390);
            this.lstViewWorkouts.TabIndex = 8;
            this.lstViewWorkouts.UseCompatibleStateImageBehavior = false;
            this.lstViewWorkouts.View = System.Windows.Forms.View.Details;
            this.lstViewWorkouts.SelectedIndexChanged += new System.EventHandler(this.lstViewWorkouts_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Workout Name";
            this.columnHeader5.Width = 210;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 150;
            // 
            // lstViewLiftsList
            // 
            this.lstViewLiftsList.BackColor = System.Drawing.SystemColors.Window;
            this.lstViewLiftsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstViewLiftsList.FullRowSelect = true;
            this.lstViewLiftsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewLiftsList.HideSelection = false;
            this.lstViewLiftsList.Location = new System.Drawing.Point(814, 77);
            this.lstViewLiftsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstViewLiftsList.MultiSelect = false;
            this.lstViewLiftsList.Name = "lstViewLiftsList";
            this.lstViewLiftsList.Size = new System.Drawing.Size(600, 390);
            this.lstViewLiftsList.TabIndex = 9;
            this.lstViewLiftsList.UseCompatibleStateImageBehavior = false;
            this.lstViewLiftsList.View = System.Windows.Forms.View.Details;
            this.lstViewLiftsList.Visible = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Workout";
            this.columnHeader7.Width = 210;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Weight";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Sets";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Reps";
            // 
            // tblLifttblLiftSetBindingSource
            // 
            this.tblLifttblLiftSetBindingSource.DataMember = "tblLifttblLiftSet";
            this.tblLifttblLiftSetBindingSource.DataSource = this.tblLiftBindingSource;
            // 
            // tblLifttblLiftSetBindingSource1
            // 
            this.tblLifttblLiftSetBindingSource1.DataMember = "tblLifttblLiftSet";
            this.tblLifttblLiftSetBindingSource1.DataSource = this.tblLiftBindingSource;
            // 
            // cmbLifts
            // 
            this.cmbLifts.BackColor = System.Drawing.Color.White;
            this.cmbLifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLifts.FormattingEnabled = true;
            this.cmbLifts.Location = new System.Drawing.Point(814, 36);
            this.cmbLifts.Name = "cmbLifts";
            this.cmbLifts.Size = new System.Drawing.Size(150, 33);
            this.cmbLifts.TabIndex = 10;
            this.cmbLifts.Visible = false;
            this.cmbLifts.SelectedIndexChanged += new System.EventHandler(this.cmbLifts_SelectedIndexChanged);
            // 
            // tblLiftBindingSource
            // 
            this.tblLiftBindingSource.DataMember = "tblLift";
            this.tblLiftBindingSource.DataSource = this.dbWorkoutTrackerDataSet;
            // 
            // dbWorkoutTrackerDataSet
            // 
            this.dbWorkoutTrackerDataSet.DataSetName = "dbWorkoutTrackerDataSet";
            this.dbWorkoutTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblWorkoutBindingSource
            // 
            this.tblWorkoutBindingSource.DataMember = "tblWorkout";
            this.tblWorkoutBindingSource.DataSource = this.dbWorkoutTrackerDataSet;
            // 
            // tblWorkoutTableAdapter
            // 
            this.tblWorkoutTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCardioSetTableAdapter = null;
            this.tableAdapterManager.tblCardioTableAdapter = null;
            this.tableAdapterManager.tblIsoSetTableAdapter = null;
            this.tableAdapterManager.tblIsoTableAdapter = null;
            this.tableAdapterManager.tblLiftSetTableAdapter = null;
            this.tableAdapterManager.tblLiftTableAdapter = null;
            this.tableAdapterManager.tblWorkoutTableAdapter = this.tblWorkoutTableAdapter;
            this.tableAdapterManager.UpdateOrder = WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblLiftSetBindingSource
            // 
            this.tblLiftSetBindingSource.DataMember = "tblLiftSet";
            this.tblLiftSetBindingSource.DataSource = this.dbWorkoutTrackerDataSet;
            // 
            // tblLiftSetTableAdapter
            // 
            this.tblLiftSetTableAdapter.ClearBeforeFill = true;
            // 
            // tblLiftTableAdapter
            // 
            this.tblLiftTableAdapter.ClearBeforeFill = true;
            // 
            // tblLiftBindingSource1
            // 
            this.tblLiftBindingSource1.DataMember = "tblLift";
            this.tblLiftBindingSource1.DataSource = this.dbWorkoutTrackerDataSet;
            // 
            // tblLiftBindingSource2
            // 
            this.tblLiftBindingSource2.DataMember = "tblLift";
            this.tblLiftBindingSource2.DataSource = this.dbWorkoutTrackerDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1431, 537);
            this.Controls.Add(this.cmbLifts);
            this.Controls.Add(this.lstViewLiftsList);
            this.Controls.Add(this.lstViewWorkouts);
            this.Controls.Add(this.btnLiftsList);
            this.Controls.Add(this.btnViewWorkouts);
            this.Controls.Add(this.btnAddWorkout);
            this.Controls.Add(this.lstViewLiftSets);
            this.Controls.Add(this.lblWorkoutDate);
            this.Controls.Add(this.lblWorkoutName);
            this.Controls.Add(this.lblSubTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "WorkoutTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLifttblLiftSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLifttblLiftSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbWorkoutTrackerDataSet dbWorkoutTrackerDataSet;
        private System.Windows.Forms.BindingSource tblWorkoutBindingSource;
        private dbWorkoutTrackerDataSetTableAdapters.tblWorkoutTableAdapter tblWorkoutTableAdapter;
        private dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tblLiftSetBindingSource;
        private dbWorkoutTrackerDataSetTableAdapters.tblLiftSetTableAdapter tblLiftSetTableAdapter;
        private System.Windows.Forms.BindingSource tblLiftBindingSource;
        private dbWorkoutTrackerDataSetTableAdapters.tblLiftTableAdapter tblLiftTableAdapter;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblWorkoutName;
        private System.Windows.Forms.Label lblWorkoutDate;
        private System.Windows.Forms.ListView lstViewLiftSets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnViewWorkouts;
        private System.Windows.Forms.Button btnLiftsList;
        private System.Windows.Forms.ListView lstViewWorkouts;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstViewLiftsList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.BindingSource tblLifttblLiftSetBindingSource;
        private System.Windows.Forms.BindingSource tblLiftBindingSource1;
        private System.Windows.Forms.BindingSource tblLifttblLiftSetBindingSource1;
        private System.Windows.Forms.ComboBox cmbLifts;
        private System.Windows.Forms.BindingSource tblLiftBindingSource2;
    }
}

