using System.ComponentModel;
using System.Windows.Forms;

namespace BestMerge
{
    partial class FindForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTeamProjectCollection = new System.Windows.Forms.ComboBox();
            this.cbMergeTo = new System.Windows.Forms.ComboBox();
            this.btnGetChangesets = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbTeamProjectContributors = new System.Windows.Forms.ComboBox();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.radMerge = new System.Windows.Forms.RadioButton();
            this.radYours = new System.Windows.Forms.RadioButton();
            this.radTheirs = new System.Windows.Forms.RadioButton();
            this.chkAutoCheckin = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolBarProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.toolBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxMerge = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxProject = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbTeamProject = new System.Windows.Forms.ComboBox();
            this.cbMergeFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lwChangesets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.bwWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxMerge.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxProject.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTeamProjectCollection
            // 
            this.cbTeamProjectCollection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTeamProjectCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeamProjectCollection.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTeamProjectCollection.FormattingEnabled = true;
            this.cbTeamProjectCollection.Location = new System.Drawing.Point(2, 20);
            this.cbTeamProjectCollection.Margin = new System.Windows.Forms.Padding(2);
            this.cbTeamProjectCollection.Name = "cbTeamProjectCollection";
            this.cbTeamProjectCollection.Size = new System.Drawing.Size(225, 22);
            this.cbTeamProjectCollection.TabIndex = 2;
            this.cbTeamProjectCollection.SelectedIndexChanged += new System.EventHandler(this.CbTeamProjectCollectionSelectedIndexChanged);
            // 
            // cbMergeTo
            // 
            this.cbMergeTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMergeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMergeTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMergeTo.FormattingEnabled = true;
            this.cbMergeTo.Location = new System.Drawing.Point(2, 134);
            this.cbMergeTo.Margin = new System.Windows.Forms.Padding(2);
            this.cbMergeTo.Name = "cbMergeTo";
            this.cbMergeTo.Size = new System.Drawing.Size(225, 22);
            this.cbMergeTo.TabIndex = 2;
            this.cbMergeTo.SelectedIndexChanged += new System.EventHandler(this.cbMergeTo_SelectedIndexChanged);
            // 
            // btnGetChangesets
            // 
            this.btnGetChangesets.AutoSize = true;
            this.btnGetChangesets.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetChangesets.Location = new System.Drawing.Point(6, 195);
            this.btnGetChangesets.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetChangesets.Name = "btnGetChangesets";
            this.btnGetChangesets.Size = new System.Drawing.Size(235, 30);
            this.btnGetChangesets.TabIndex = 3;
            this.btnGetChangesets.Text = "Get Changesets";
            this.btnGetChangesets.UseVisualStyleBackColor = true;
            this.btnGetChangesets.Click += new System.EventHandler(this.BtnGetChangesets_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(251, 195);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cbTeamProjectContributors
            // 
            this.cbTeamProjectContributors.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTeamProjectContributors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeamProjectContributors.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTeamProjectContributors.FormattingEnabled = true;
            this.cbTeamProjectContributors.Location = new System.Drawing.Point(2, 20);
            this.cbTeamProjectContributors.Margin = new System.Windows.Forms.Padding(2);
            this.cbTeamProjectContributors.Name = "cbTeamProjectContributors";
            this.cbTeamProjectContributors.Size = new System.Drawing.Size(236, 22);
            this.cbTeamProjectContributors.TabIndex = 2;
            // 
            // dpFrom
            // 
            this.dpFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dpFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpFrom.Location = new System.Drawing.Point(2, 58);
            this.dpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.ShowCheckBox = true;
            this.dpFrom.Size = new System.Drawing.Size(236, 22);
            this.dpFrom.TabIndex = 6;
            // 
            // dpTo
            // 
            this.dpTo.Checked = false;
            this.dpTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dpTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpTo.Location = new System.Drawing.Point(2, 96);
            this.dpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dpTo.Name = "dpTo";
            this.dpTo.ShowCheckBox = true;
            this.dpTo.Size = new System.Drawing.Size(236, 22);
            this.dpTo.TabIndex = 6;
            // 
            // txtCriteria
            // 
            this.txtCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCriteria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCriteria.Location = new System.Drawing.Point(2, 134);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(236, 22);
            this.txtCriteria.TabIndex = 7;
            // 
            // radMerge
            // 
            this.radMerge.AutoSize = true;
            this.radMerge.Checked = true;
            this.radMerge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radMerge.Location = new System.Drawing.Point(2, 22);
            this.radMerge.Margin = new System.Windows.Forms.Padding(2);
            this.radMerge.Name = "radMerge";
            this.radMerge.Size = new System.Drawing.Size(102, 18);
            this.radMerge.TabIndex = 8;
            this.radMerge.TabStop = true;
            this.radMerge.Text = "Accept Merge";
            this.radMerge.UseVisualStyleBackColor = true;
            // 
            // radYours
            // 
            this.radYours.AutoSize = true;
            this.radYours.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radYours.Location = new System.Drawing.Point(2, 46);
            this.radYours.Margin = new System.Windows.Forms.Padding(2);
            this.radYours.Name = "radYours";
            this.radYours.Size = new System.Drawing.Size(99, 18);
            this.radYours.TabIndex = 8;
            this.radYours.Text = "Accept Yours";
            this.radYours.UseVisualStyleBackColor = true;
            // 
            // radTheirs
            // 
            this.radTheirs.AutoSize = true;
            this.radTheirs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radTheirs.Location = new System.Drawing.Point(2, 70);
            this.radTheirs.Margin = new System.Windows.Forms.Padding(2);
            this.radTheirs.Name = "radTheirs";
            this.radTheirs.Size = new System.Drawing.Size(101, 18);
            this.radTheirs.TabIndex = 8;
            this.radTheirs.Text = "Accept Theirs";
            this.radTheirs.UseVisualStyleBackColor = true;
            // 
            // chkAutoCheckin
            // 
            this.chkAutoCheckin.AutoSize = true;
            this.chkAutoCheckin.Checked = true;
            this.chkAutoCheckin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoCheckin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAutoCheckin.Location = new System.Drawing.Point(2, 110);
            this.chkAutoCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoCheckin.Name = "chkAutoCheckin";
            this.chkAutoCheckin.Size = new System.Drawing.Size(222, 18);
            this.chkAutoCheckin.TabIndex = 9;
            this.chkAutoCheckin.Text = "Auto check in with same comment.";
            this.chkAutoCheckin.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarProcess,
            this.toolBarText,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(759, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 10;
            // 
            // toolBarProcess
            // 
            this.toolBarProcess.Name = "toolBarProcess";
            this.toolBarProcess.Size = new System.Drawing.Size(75, 16);
            this.toolBarProcess.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolBarText
            // 
            this.toolBarText.Name = "toolBarText";
            this.toolBarText.Size = new System.Drawing.Size(671, 17);
            this.toolBarText.Spring = true;
            this.toolBarText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.62317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.08788F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15579F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxMerge, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxProject, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lwChangesets, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGetChangesets, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 521);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(251, 481);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tip#1 Double click to view changeset detail.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(6, 481);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tip#2 Press \"delete\" to remove from list.";
            // 
            // groupBoxMerge
            // 
            this.groupBoxMerge.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMerge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMerge.Location = new System.Drawing.Point(509, 8);
            this.groupBoxMerge.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMerge.Name = "groupBoxMerge";
            this.groupBoxMerge.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMerge.Size = new System.Drawing.Size(242, 181);
            this.groupBoxMerge.TabIndex = 8;
            this.groupBoxMerge.TabStop = false;
            this.groupBoxMerge.Text = "Merge Options";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chkAutoCheckin, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.radMerge, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.radYours, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.radTheirs, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(234, 158);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(2, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Conflict Resolution Method:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(2, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 14);
            this.label12.TabIndex = 3;
            this.label12.Text = "Check In Mode:";
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxProject.Location = new System.Drawing.Point(8, 8);
            this.groupBoxProject.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProject.Size = new System.Drawing.Size(237, 181);
            this.groupBoxProject.TabIndex = 5;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "TFS Project Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cbTeamProjectCollection, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbTeamProject, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbMergeFrom, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbMergeTo, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 158);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbTeamProject
            // 
            this.cbTeamProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTeamProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeamProject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTeamProject.FormattingEnabled = true;
            this.cbTeamProject.Location = new System.Drawing.Point(2, 58);
            this.cbTeamProject.Margin = new System.Windows.Forms.Padding(2);
            this.cbTeamProject.Name = "cbTeamProject";
            this.cbTeamProject.Size = new System.Drawing.Size(225, 22);
            this.cbTeamProject.TabIndex = 2;
            this.cbTeamProject.SelectedIndexChanged += new System.EventHandler(this.CbTeamProject_SelectedIndexChanged);
            // 
            // cbMergeFrom
            // 
            this.cbMergeFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMergeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMergeFrom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMergeFrom.FormattingEnabled = true;
            this.cbMergeFrom.Location = new System.Drawing.Point(2, 96);
            this.cbMergeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cbMergeFrom.Name = "cbMergeFrom";
            this.cbMergeFrom.Size = new System.Drawing.Size(225, 22);
            this.cbMergeFrom.TabIndex = 2;
            this.cbMergeFrom.SelectedIndexChanged += new System.EventHandler(this.CbMergeFrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "TFS Project:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(2, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Merge To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(2, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Merge From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "TFS Project Collection:";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFilter.Location = new System.Drawing.Point(253, 8);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFilter.Size = new System.Drawing.Size(248, 181);
            this.groupBoxFilter.TabIndex = 6;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Changeset Filter Options";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cbTeamProjectContributors, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dpFrom, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.dpTo, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtCriteria, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(240, 158);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(2, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Owner:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(2, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "From Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(2, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "To Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(2, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Comment or ChangeSetId Contains:";
            // 
            // lwChangesets
            // 
            this.lwChangesets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tableLayoutPanel1.SetColumnSpan(this.lwChangesets, 3);
            this.lwChangesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwChangesets.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwChangesets.FullRowSelect = true;
            this.lwChangesets.Location = new System.Drawing.Point(6, 229);
            this.lwChangesets.Margin = new System.Windows.Forms.Padding(2);
            this.lwChangesets.MultiSelect = false;
            this.lwChangesets.Name = "lwChangesets";
            this.lwChangesets.Size = new System.Drawing.Size(747, 250);
            this.lwChangesets.TabIndex = 9;
            this.lwChangesets.UseCompatibleStateImageBehavior = false;
            this.lwChangesets.View = System.Windows.Forms.View.Details;
            this.lwChangesets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LwChangesets_ColumnClick);
            this.lwChangesets.DoubleClick += new System.EventHandler(this.LwChangesets_DoubleClick);
            this.lwChangesets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LwChangesets_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Changeset Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Owner";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Creation Date";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comment";
            this.columnHeader4.Width = 400;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(507, 481);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tip#3 Press \"F9\" to merge changeset.";
            // 
            // bwWorker
            // 
            this.bwWorker.WorkerReportsProgress = true;
            this.bwWorker.WorkerSupportsCancellation = true;
            this.bwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwWorker_DoWork);
            this.bwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BwWorker_ProgressChanged);
            this.bwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwWorker_RunWorkerCompleted);
            // 
            // FindForm
            // 
            this.AcceptButton = this.btnGetChangesets;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 521);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Best Merge";
            this.Load += new System.EventHandler(this.FindFormLoad);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxMerge.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxProject.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetChangesets;
        private Button btnCancel;
        private BackgroundWorker bwWorker;
        private ComboBox cbMergeFrom;
        private ComboBox cbMergeTo;
        private ComboBox cbTeamProject;
        private ComboBox cbTeamProjectCollection;
        private ComboBox cbTeamProjectContributors;
        private CheckBox chkAutoCheckin;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DateTimePicker dpFrom;
        private DateTimePicker dpTo;
        private GroupBox groupBoxFilter;
        private GroupBox groupBoxMerge;
        private GroupBox groupBoxProject;
        private Label label1;
        private Label label10;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListView lwChangesets;
        private RadioButton radMerge;
        private RadioButton radTheirs;
        private RadioButton radYours;
        private StatusStrip statusStrip;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private ToolStripProgressBar toolBarProcess;
        private ToolStripStatusLabel toolBarText;
        private TextBox txtCriteria;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label13;
        private Label label11;
    }
}
