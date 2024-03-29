﻿namespace SortApp
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.OriginalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BubbleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MergeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTimes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSort = new System.Windows.Forms.Button();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.textBoxArrSize = new System.Windows.Forms.TextBox();
            this.labelArrSize = new System.Windows.Forms.Label();
            this.buttonGenArr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewData);
            // 
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.buttonGenArr);
            this.splitContainer1.Panel2.Controls.Add(this.labelArrSize);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxArrSize);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxRandom);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSort);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewTimes);
            this.splitContainer1.Panel2MinSize = 110;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 14;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalColumn,
            this.BubbleColumn,
            this.InsertionColumn,
            this.SelectionColumn,
            this.MergeColumn});
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewData.Name = "dataGridView1";
            this.dataGridViewData.Size = new System.Drawing.Size(800, 300);
            this.dataGridViewData.TabIndex = 1;
            // 
            // OriginalColumn
            // 
            this.OriginalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalColumn.HeaderText = "Массив для сортировки";
            this.OriginalColumn.Name = "OriginalColumn";
            // 
            // BubbleColumn
            // 
            this.BubbleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BubbleColumn.HeaderText = "Сортировка пузырьком";
            this.BubbleColumn.Name = "BubbleColumn";
            this.BubbleColumn.ReadOnly = true;
            // 
            // InsertionColumn
            // 
            this.InsertionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InsertionColumn.HeaderText = "Сортировка вставками";
            this.InsertionColumn.Name = "InsertionColumn";
            this.InsertionColumn.ReadOnly = true;
            // 
            // SelectionColumn
            // 
            this.SelectionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SelectionColumn.HeaderText = "Сортировка выбором";
            this.SelectionColumn.Name = "SelectionColumn";
            this.SelectionColumn.ReadOnly = true;
            // 
            // MergeColumn
            // 
            this.MergeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MergeColumn.HeaderText = "Сортировка слиянием";
            this.MergeColumn.Name = "MergeColumn";
            this.MergeColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridViewTimes.AllowUserToAddRows = false;
            this.dataGridViewTimes.AllowUserToDeleteRows = false;
            this.dataGridViewTimes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewTimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTimes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTimes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTimes.Name = "dataGridView2";
            this.dataGridViewTimes.Size = new System.Drawing.Size(800, 56);
            this.dataGridViewTimes.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Сортировка .NET BCL, время (мс)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Сортировка пузырьком, время (мс)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Сортировка вставками, время (мс)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Сортировка выбором, время (мс)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Сортировка слиянием, время (мс)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            //
            // buttonSort
            //
            this.buttonSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSort.Location = new System.Drawing.Point(810, 109);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(93, 25);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(12, 89);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(145, 17);
            this.checkBoxRandom.TabIndex = 4;
            this.checkBoxRandom.Text = "Случайные числа (авто)";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // textBoxArrSize
            // 
            this.textBoxArrSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxArrSize.Enabled = false;
            this.textBoxArrSize.Location = new System.Drawing.Point(108, 112);
            this.textBoxArrSize.Name = "textBoxArrSize";
            this.textBoxArrSize.Size = new System.Drawing.Size(116, 20);
            this.textBoxArrSize.TabIndex = 5;
            // 
            // labelArrSize
            // 
            this.labelArrSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelArrSize.AutoSize = true;
            this.labelArrSize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelArrSize.Location = new System.Drawing.Point(9, 115);
            this.labelArrSize.Name = "labelArrSize";
            this.labelArrSize.Size = new System.Drawing.Size(93, 13);
            this.labelArrSize.TabIndex = 6;
            this.labelArrSize.Text = "Размер массива";
            // 
            // buttonGenArr
            // 
            this.buttonGenArr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGenArr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenArr.Enabled = false;
            this.buttonGenArr.Location = new System.Drawing.Point(230, 109);
            this.buttonGenArr.Name = "buttonGenArr";
            this.buttonGenArr.Size = new System.Drawing.Size(93, 25);
            this.buttonGenArr.TabIndex = 7;
            this.buttonGenArr.Text = "Создать";
            this.buttonGenArr.UseVisualStyleBackColor = false;
            this.buttonGenArr.Click += new System.EventHandler(this.buttonGenArr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Sorting App";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.Load += AppForm_Load;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BubbleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MergeColumn;
        private System.Windows.Forms.DataGridView dataGridViewTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.TextBox textBoxArrSize;
        private System.Windows.Forms.Label labelArrSize;
        private System.Windows.Forms.Button buttonGenArr;
    }
}

