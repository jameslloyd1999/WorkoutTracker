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
            this.dbWorkoutTrackerDataSet = new WorkoutTracker.dbWorkoutTrackerDataSet();
            this.tblWorkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWorkoutTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblWorkoutTableAdapter();
            this.tableAdapterManager = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager();
            this.tblLiftSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLiftSetTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblLiftSetTableAdapter();
            this.tblLiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLiftTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblLiftTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource)).BeginInit();
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
            this.btnAddWorkout.Location = new System.Drawing.Point(178, 485);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(160, 40);
            this.btnAddWorkout.TabIndex = 5;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.UseVisualStyleBackColor = true;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // btnViewWorkouts
            // 
            this.btnViewWorkouts.Enabled = false;
            this.btnViewWorkouts.Location = new System.Drawing.Point(12, 485);
            this.btnViewWorkouts.Name = "btnViewWorkouts";
            this.btnViewWorkouts.Size = new System.Drawing.Size(160, 40);
            this.btnViewWorkouts.TabIndex = 6;
            this.btnViewWorkouts.Text = "View Workouts";
            this.btnViewWorkouts.UseVisualStyleBackColor = true;
            this.btnViewWorkouts.Click += new System.EventHandler(this.btnViewWorkouts_Click);
            // 
            // btnLiftsList
            // 
            this.btnLiftsList.Location = new System.Drawing.Point(344, 485);
            this.btnLiftsList.Name = "btnLiftsList";
            this.btnLiftsList.Size = new System.Drawing.Size(160, 40);
            this.btnLiftsList.TabIndex = 7;
            this.btnLiftsList.Text = "Lifts List";
            this.btnLiftsList.UseVisualStyleBackColor = true;
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
            // tblLiftBindingSource
            // 
            this.tblLiftBindingSource.DataMember = "tblLift";
            this.tblLiftBindingSource.DataSource = this.dbWorkoutTrackerDataSet;
            // 
            // tblLiftTableAdapter
            // 
            this.tblLiftTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 537);
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
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource)).EndInit();
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
    }
}

