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
            this.dbWorkoutTrackerDataSet = new WorkoutTracker.dbWorkoutTrackerDataSet();
            this.tblWorkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblWorkoutTableAdapter = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.tblWorkoutTableAdapter();
            this.tableAdapterManager = new WorkoutTracker.dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager();
            this.tblWorkoutDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tblWorkoutDataGridView
            // 
            this.tblWorkoutDataGridView.AutoGenerateColumns = false;
            this.tblWorkoutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblWorkoutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tblWorkoutDataGridView.DataSource = this.tblWorkoutBindingSource;
            this.tblWorkoutDataGridView.Location = new System.Drawing.Point(134, 91);
            this.tblWorkoutDataGridView.Name = "tblWorkoutDataGridView";
            this.tblWorkoutDataGridView.RowHeadersWidth = 51;
            this.tblWorkoutDataGridView.RowTemplate.Height = 24;
            this.tblWorkoutDataGridView.Size = new System.Drawing.Size(464, 274);
            this.tblWorkoutDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "workoutID";
            this.dataGridViewTextBoxColumn1.HeaderText = "workoutID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "workoutName";
            this.dataGridViewTextBoxColumn2.HeaderText = "workoutName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "workoutDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "workoutDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblWorkoutDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbWorkoutTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkoutDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbWorkoutTrackerDataSet dbWorkoutTrackerDataSet;
        private System.Windows.Forms.BindingSource tblWorkoutBindingSource;
        private dbWorkoutTrackerDataSetTableAdapters.tblWorkoutTableAdapter tblWorkoutTableAdapter;
        private dbWorkoutTrackerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblWorkoutDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

