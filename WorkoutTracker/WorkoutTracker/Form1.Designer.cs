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
            this.lblTitle = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WorkoutTracker";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(13, 94);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(138, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Latest workout";
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.AutoSize = true;
            this.lblWorkoutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutName.Location = new System.Drawing.Point(14, 146);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(111, 20);
            this.lblWorkoutName.TabIndex = 2;
            this.lblWorkoutName.Text = "workoutName";
            // 
            // lblWorkoutDate
            // 
            this.lblWorkoutDate.AutoSize = true;
            this.lblWorkoutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutDate.Location = new System.Drawing.Point(14, 181);
            this.lblWorkoutDate.Name = "lblWorkoutDate";
            this.lblWorkoutDate.Size = new System.Drawing.Size(103, 20);
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
            this.lstViewWorkout.HideSelection = false;
            this.lstViewWorkout.Location = new System.Drawing.Point(339, 198);
            this.lstViewWorkout.Name = "lstViewWorkout";
            this.lstViewWorkout.Size = new System.Drawing.Size(461, 242);
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
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sets";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 592);
            this.Controls.Add(this.lstViewWorkout);
            this.Controls.Add(this.lblWorkoutDate);
            this.Controls.Add(this.lblWorkoutName);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblWorkoutName;
        private System.Windows.Forms.Label lblWorkoutDate;
        private System.Windows.Forms.ListView lstViewWorkout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

