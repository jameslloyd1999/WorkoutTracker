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
            this.dbWorkoutTrackerDataSet = new WorkoutTracker.dbWorkoutTrackerDataSet();
            this.tblWorkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWorkoutTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblWorkoutTableAdapter();
            this.tableAdapterManager = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager();
            this.tblLiftSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLiftSetTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblLiftSetTableAdapter();
            this.tblLiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLiftTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblLiftTableAdapter();
            this.lstViewWorkout = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewWorkout = new System.Windows.Forms.Button();
            this.btnViewWorkouts = new System.Windows.Forms.Button();
            this.btnLiftList = new System.Windows.Forms.Button();
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
            this.lblSubTitle.Size = new System.Drawing.Size(198, 32);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Latest workout";
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.AutoSize = true;
            this.lblWorkoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutName.Location = new System.Drawing.Point(14, 67);
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
            this.lblWorkoutDate.Location = new System.Drawing.Point(14, 111);
            this.lblWorkoutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkoutDate.Name = "lblWorkoutDate";
            this.lblWorkoutDate.Size = new System.Drawing.Size(121, 25);
            this.lblWorkoutDate.TabIndex = 3;
            this.lblWorkoutDate.Text = "workoutDate";
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
            // lstViewWorkout
            // 
            this.lstViewWorkout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewWorkout.FullRowSelect = true;
            this.lstViewWorkout.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewWorkout.HideSelection = false;
            this.lstViewWorkout.Location = new System.Drawing.Point(227, 67);
            this.lstViewWorkout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstViewWorkout.MultiSelect = false;
            this.lstViewWorkout.Name = "lstViewWorkout";
            this.lstViewWorkout.Size = new System.Drawing.Size(390, 390);
            this.lstViewWorkout.TabIndex = 4;
            this.lstViewWorkout.UseCompatibleStateImageBehavior = false;
            this.lstViewWorkout.View = System.Windows.Forms.View.Details;
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
            // btnNewWorkout
            // 
            this.btnNewWorkout.Location = new System.Drawing.Point(12, 325);
            this.btnNewWorkout.Name = "btnNewWorkout";
            this.btnNewWorkout.Size = new System.Drawing.Size(160, 40);
            this.btnNewWorkout.TabIndex = 5;
            this.btnNewWorkout.Text = "New Workout";
            this.btnNewWorkout.UseVisualStyleBackColor = true;
            // 
            // btnViewWorkouts
            // 
            this.btnViewWorkouts.Location = new System.Drawing.Point(12, 371);
            this.btnViewWorkouts.Name = "btnViewWorkouts";
            this.btnViewWorkouts.Size = new System.Drawing.Size(160, 40);
            this.btnViewWorkouts.TabIndex = 6;
            this.btnViewWorkouts.Text = "View Workouts";
            this.btnViewWorkouts.UseVisualStyleBackColor = true;
            // 
            // btnLiftList
            // 
            this.btnLiftList.Location = new System.Drawing.Point(12, 417);
            this.btnLiftList.Name = "btnLiftList";
            this.btnLiftList.Size = new System.Drawing.Size(160, 40);
            this.btnLiftList.TabIndex = 7;
            this.btnLiftList.Text = "Lift List";
            this.btnLiftList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 537);
            this.Controls.Add(this.btnLiftList);
            this.Controls.Add(this.btnViewWorkouts);
            this.Controls.Add(this.btnNewWorkout);
            this.Controls.Add(this.lstViewWorkout);
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
        private System.Windows.Forms.ListView lstViewWorkout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnNewWorkout;
        private System.Windows.Forms.Button btnViewWorkouts;
        private System.Windows.Forms.Button btnLiftList;
    }
}

