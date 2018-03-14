namespace SNMP_BROWSER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxOID = new System.Windows.Forms.TextBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.labelOperations = new System.Windows.Forms.Label();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelresult = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.resultsView = new System.Windows.Forms.TabPage();
            this.tableView = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonObserve = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.trapButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.resultsView.SuspendLayout();
            this.tableView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(325, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OID:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddress.Location = new System.Drawing.Point(135, 26);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(111, 27);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.Text = "localhost";
            // 
            // textBoxOID
            // 
            this.textBoxOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOID.Location = new System.Drawing.Point(375, 26);
            this.textBoxOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOID.Name = "textBoxOID";
            this.textBoxOID.Size = new System.Drawing.Size(169, 27);
            this.textBoxOID.TabIndex = 3;
            // 
            // buttonGO
            // 
            this.buttonGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGO.Location = new System.Drawing.Point(883, 11);
            this.buttonGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(116, 28);
            this.buttonGO.TabIndex = 4;
            this.buttonGO.Text = "Go!";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Location = new System.Drawing.Point(679, 25);
            this.comboBoxOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(181, 28);
            this.comboBoxOperations.TabIndex = 5;
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOperations.Location = new System.Drawing.Point(571, 33);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(91, 20);
            this.labelOperations.TabIndex = 6;
            this.labelOperations.Text = "Operations";
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValues.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewValues.Location = new System.Drawing.Point(0, 517);
            this.dataGridViewValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.RowHeadersVisible = false;
            this.dataGridViewValues.RowTemplate.Height = 24;
            this.dataGridViewValues.Size = new System.Drawing.Size(357, 254);
            this.dataGridViewValues.TabIndex = 9;
            // 
            // column
            // 
            this.column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.column.DefaultCellStyle = dataGridViewCellStyle1;
            this.column.HeaderText = "";
            this.column.MinimumWidth = 20;
            this.column.Name = "column";
            this.column.ReadOnly = true;
            this.column.Width = 24;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "SNMP MIBs";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewResults.Location = new System.Drawing.Point(-5, 0);
            this.dataGridViewResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(781, 686);
            this.dataGridViewResults.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name/OID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "IP:Port";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelresult.Location = new System.Drawing.Point(359, 62);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(103, 20);
            this.labelresult.TabIndex = 7;
            this.labelresult.Text = "Result Table";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 85);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(357, 426);
            this.treeView1.TabIndex = 11;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.resultsView);
            this.tabControl1.Controls.Add(this.tableView);
            this.tabControl1.Location = new System.Drawing.Point(363, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 699);
            this.tabControl1.TabIndex = 12;
            // 
            // resultsView
            // 
            this.resultsView.Controls.Add(this.dataGridViewResults);
            this.resultsView.Location = new System.Drawing.Point(4, 25);
            this.resultsView.Margin = new System.Windows.Forms.Padding(4);
            this.resultsView.Name = "resultsView";
            this.resultsView.Padding = new System.Windows.Forms.Padding(4);
            this.resultsView.Size = new System.Drawing.Size(785, 670);
            this.resultsView.TabIndex = 0;
            this.resultsView.Text = "resultsView";
            this.resultsView.UseVisualStyleBackColor = true;
            // 
            // tableView
            // 
            this.tableView.Controls.Add(this.dataGridView1);
            this.tableView.Location = new System.Drawing.Point(4, 25);
            this.tableView.Margin = new System.Windows.Forms.Padding(4);
            this.tableView.Name = "tableView";
            this.tableView.Padding = new System.Windows.Forms.Padding(4);
            this.tableView.Size = new System.Drawing.Size(785, 670);
            this.tableView.TabIndex = 1;
            this.tableView.Text = "tableView";
            this.tableView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 654);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonObserve
            // 
            this.buttonObserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonObserve.Location = new System.Drawing.Point(1005, 11);
            this.buttonObserve.Name = "buttonObserve";
            this.buttonObserve.Size = new System.Drawing.Size(116, 28);
            this.buttonObserve.TabIndex = 13;
            this.buttonObserve.Text = "Observe";
            this.buttonObserve.UseVisualStyleBackColor = true;
            this.buttonObserve.Click += new System.EventHandler(this.buttonObserve_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
           // this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // trapButton
            // 
            this.trapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trapButton.Location = new System.Drawing.Point(883, 44);
            this.trapButton.Name = "trapButton";
            this.trapButton.Size = new System.Drawing.Size(238, 32);
            this.trapButton.TabIndex = 14;
            this.trapButton.Text = "Generate trap";
            this.trapButton.UseVisualStyleBackColor = true;
            this.trapButton.Click += new System.EventHandler(this.trapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 772);
            this.Controls.Add(this.trapButton);
            this.Controls.Add(this.buttonObserve);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.labelOperations);
            this.Controls.Add(this.comboBoxOperations);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.textBoxOID);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.resultsView.ResumeLayout(false);
            this.tableView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage resultsView;
        private System.Windows.Forms.TabPage tableView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonObserve;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button trapButton;
    }
}

