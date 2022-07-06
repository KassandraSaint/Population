
namespace Population
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.sortAscend = new System.Windows.Forms.Button();
            this.sortDesc = new System.Windows.Forms.Button();
            this.sortName = new System.Windows.Forms.Button();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPop = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet = new Population._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet();
            this.cityTableAdapter = new Population._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new Population._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSetTableAdapters.TableAdapterManager();
            this.calculateAverage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.averagePop = new System.Windows.Forms.Label();
            this.getHigh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.getLow = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(1158, 42);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(71, 80);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.RowHeadersWidth = 82;
            this.cityDataGridView.RowTemplate.Height = 33;
            this.cityDataGridView.Size = new System.Drawing.Size(1012, 340);
            this.cityDataGridView.TabIndex = 1;
            // 
            // sortAscend
            // 
            this.sortAscend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sortAscend.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAscend.Location = new System.Drawing.Point(71, 452);
            this.sortAscend.Name = "sortAscend";
            this.sortAscend.Size = new System.Drawing.Size(369, 80);
            this.sortAscend.TabIndex = 2;
            this.sortAscend.Text = "Sort By Population(Ascending)";
            this.sortAscend.UseVisualStyleBackColor = false;
            this.sortAscend.Click += new System.EventHandler(this.sortAscend_Click);
            // 
            // sortDesc
            // 
            this.sortDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sortDesc.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDesc.Location = new System.Drawing.Point(468, 452);
            this.sortDesc.Name = "sortDesc";
            this.sortDesc.Size = new System.Drawing.Size(369, 80);
            this.sortDesc.TabIndex = 3;
            this.sortDesc.Text = "Sort By Population(Descending)";
            this.sortDesc.UseVisualStyleBackColor = false;
            this.sortDesc.Click += new System.EventHandler(this.sortDesc_Click);
            // 
            // sortName
            // 
            this.sortName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sortName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortName.Location = new System.Drawing.Point(882, 452);
            this.sortName.Name = "sortName";
            this.sortName.Size = new System.Drawing.Size(201, 80);
            this.sortName.TabIndex = 4;
            this.sortName.Text = "Sort By Name";
            this.sortName.UseVisualStyleBackColor = false;
            this.sortName.Click += new System.EventHandler(this.sortName_Click);
            // 
            // calculateTotal
            // 
            this.calculateTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calculateTotal.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotal.Location = new System.Drawing.Point(73, 570);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(369, 80);
            this.calculateTotal.TabIndex = 5;
            this.calculateTotal.Text = "Calculate Total Population";
            this.calculateTotal.UseVisualStyleBackColor = false;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Popultion of All Cities is: ";
            // 
            // totalPop
            // 
            this.totalPop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPop.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPop.Location = new System.Drawing.Point(882, 570);
            this.totalPop.Name = "totalPop";
            this.totalPop.Size = new System.Drawing.Size(201, 80);
            this.totalPop.TabIndex = 7;
            this.totalPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn1.HeaderText = "City";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet;
            // 
            // _C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet
            // 
            this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.DataSetName = "_C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDF" +
    "DataSet";
            this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = Population._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calculateAverage
            // 
            this.calculateAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calculateAverage.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateAverage.Location = new System.Drawing.Point(73, 686);
            this.calculateAverage.Name = "calculateAverage";
            this.calculateAverage.Size = new System.Drawing.Size(369, 80);
            this.calculateAverage.TabIndex = 8;
            this.calculateAverage.Text = "Calculate Average Population";
            this.calculateAverage.UseVisualStyleBackColor = false;
            this.calculateAverage.Click += new System.EventHandler(this.calculateAverage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 714);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Average Population of All Cities: ";
            // 
            // averagePop
            // 
            this.averagePop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.averagePop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averagePop.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averagePop.Location = new System.Drawing.Point(882, 686);
            this.averagePop.Name = "averagePop";
            this.averagePop.Size = new System.Drawing.Size(201, 80);
            this.averagePop.TabIndex = 10;
            this.averagePop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getHigh
            // 
            this.getHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getHigh.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getHigh.Location = new System.Drawing.Point(73, 800);
            this.getHigh.Name = "getHigh";
            this.getHigh.Size = new System.Drawing.Size(369, 80);
            this.getHigh.TabIndex = 11;
            this.getHigh.Text = "Get the Highest Population";
            this.getHigh.UseVisualStyleBackColor = false;
            this.getHigh.Click += new System.EventHandler(this.getHigh_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 828);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "The Highest Population is: ";
            // 
            // highLabel
            // 
            this.highLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.highLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.Location = new System.Drawing.Point(882, 800);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(201, 80);
            this.highLabel.TabIndex = 13;
            this.highLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getLow
            // 
            this.getLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getLow.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getLow.Location = new System.Drawing.Point(73, 912);
            this.getLow.Name = "getLow";
            this.getLow.Size = new System.Drawing.Size(369, 80);
            this.getLow.TabIndex = 14;
            this.getLow.Text = "Get the Lowest Population";
            this.getLow.UseVisualStyleBackColor = false;
            this.getLow.Click += new System.EventHandler(this.getLow_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(468, 1014);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(369, 80);
            this.exit.TabIndex = 15;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 940);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "The Lowest Population is:";
            // 
            // lowLabel
            // 
            this.lowLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.Location = new System.Drawing.Point(882, 912);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(201, 80);
            this.lowLabel.TabIndex = 17;
            this.lowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(1158, 1126);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.getLow);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getHigh);
            this.Controls.Add(this.averagePop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateAverage);
            this.Controls.Add(this.totalPop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.sortName);
            this.Controls.Add(this.sortDesc);
            this.Controls.Add(this.sortAscend);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Name = "Form1";
            this.Text = "Population";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet _C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private _C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private _C__USERS_TONY_DOCUMENTS_BOOKS_C__STUDENT_SAMPLE_PROGRAMS_CHAP11_POPULATIONDB_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button sortAscend;
        private System.Windows.Forms.Button sortDesc;
        private System.Windows.Forms.Button sortName;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPop;
        private System.Windows.Forms.Button calculateAverage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label averagePop;
        private System.Windows.Forms.Button getHigh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Button getLow;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lowLabel;
    }
}

