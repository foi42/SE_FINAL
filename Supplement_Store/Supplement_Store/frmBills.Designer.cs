namespace Supplement_Store
{
    partial class frmBills
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agenFormBtn = new System.Windows.Forms.Button();
            this.suppFormBtn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agenRBTN = new System.Windows.Forms.RadioButton();
            this.suppRBTN = new System.Windows.Forms.RadioButton();
            this.ID_supp_agen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccountantID = new System.Windows.Forms.ComboBox();
            this.txtBillDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.billImRBTN = new System.Windows.Forms.RadioButton();
            this.billExRBTN = new System.Windows.Forms.RadioButton();
            this.allBillRBTN = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1231, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agenFormBtn);
            this.groupBox2.Controls.Add(this.suppFormBtn);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(972, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 186);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // agenFormBtn
            // 
            this.agenFormBtn.Location = new System.Drawing.Point(160, 79);
            this.agenFormBtn.Name = "agenFormBtn";
            this.agenFormBtn.Size = new System.Drawing.Size(85, 38);
            this.agenFormBtn.TabIndex = 6;
            this.agenFormBtn.Text = "Agencies";
            this.agenFormBtn.UseVisualStyleBackColor = true;
            this.agenFormBtn.Click += new System.EventHandler(this.agenFormBtn_Click);
            // 
            // suppFormBtn
            // 
            this.suppFormBtn.Location = new System.Drawing.Point(160, 31);
            this.suppFormBtn.Name = "suppFormBtn";
            this.suppFormBtn.Size = new System.Drawing.Size(85, 38);
            this.suppFormBtn.TabIndex = 5;
            this.suppFormBtn.Text = "Suppliers";
            this.suppFormBtn.UseVisualStyleBackColor = true;
            this.suppFormBtn.Click += new System.EventHandler(this.suppFormBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(38, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBillID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.agenRBTN);
            this.groupBox3.Controls.Add(this.suppRBTN);
            this.groupBox3.Controls.Add(this.ID_supp_agen);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtAccountantID);
            this.groupBox3.Controls.Add(this.txtBillDate);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(936, 186);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID (Supp/Agen)";
            // 
            // txtBillID
            // 
            this.txtBillID.FormattingEnabled = true;
            this.txtBillID.Items.AddRange(new object[] {
            "Auto ID"});
            this.txtBillID.Location = new System.Drawing.Point(642, 40);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(237, 24);
            this.txtBillID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bill ID";
            // 
            // agenRBTN
            // 
            this.agenRBTN.AutoSize = true;
            this.agenRBTN.Location = new System.Drawing.Point(335, 44);
            this.agenRBTN.Name = "agenRBTN";
            this.agenRBTN.Size = new System.Drawing.Size(74, 20);
            this.agenRBTN.TabIndex = 18;
            this.agenRBTN.TabStop = true;
            this.agenRBTN.Text = "Agency";
            this.agenRBTN.UseVisualStyleBackColor = true;
            this.agenRBTN.CheckedChanged += new System.EventHandler(this.agenRBTN_CheckedChanged);
            // 
            // suppRBTN
            // 
            this.suppRBTN.AutoSize = true;
            this.suppRBTN.Location = new System.Drawing.Point(172, 44);
            this.suppRBTN.Name = "suppRBTN";
            this.suppRBTN.Size = new System.Drawing.Size(78, 20);
            this.suppRBTN.TabIndex = 17;
            this.suppRBTN.TabStop = true;
            this.suppRBTN.Text = "Supplier";
            this.suppRBTN.UseVisualStyleBackColor = true;
            this.suppRBTN.CheckedChanged += new System.EventHandler(this.suppRBTN_CheckedChanged);
            // 
            // ID_supp_agen
            // 
            this.ID_supp_agen.FormattingEnabled = true;
            this.ID_supp_agen.Location = new System.Drawing.Point(172, 87);
            this.ID_supp_agen.Name = "ID_supp_agen";
            this.ID_supp_agen.Size = new System.Drawing.Size(237, 24);
            this.ID_supp_agen.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Accountant ID";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(642, 137);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(237, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total";
            // 
            // txtAccountantID
            // 
            this.txtAccountantID.FormattingEnabled = true;
            this.txtAccountantID.Location = new System.Drawing.Point(642, 87);
            this.txtAccountantID.Name = "txtAccountantID";
            this.txtAccountantID.Size = new System.Drawing.Size(237, 24);
            this.txtAccountantID.TabIndex = 12;
            // 
            // txtBillDate
            // 
            this.txtBillDate.Location = new System.Drawing.Point(172, 139);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(237, 22);
            this.txtBillDate.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(94, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Date";
            // 
            // billImRBTN
            // 
            this.billImRBTN.AutoSize = true;
            this.billImRBTN.Location = new System.Drawing.Point(157, 230);
            this.billImRBTN.Name = "billImRBTN";
            this.billImRBTN.Size = new System.Drawing.Size(96, 20);
            this.billImRBTN.TabIndex = 19;
            this.billImRBTN.TabStop = true;
            this.billImRBTN.Text = "Bills Import ";
            this.billImRBTN.UseVisualStyleBackColor = true;
            this.billImRBTN.CheckedChanged += new System.EventHandler(this.billImRBTN_CheckedChanged);
            // 
            // billExRBTN
            // 
            this.billExRBTN.AutoSize = true;
            this.billExRBTN.Location = new System.Drawing.Point(328, 230);
            this.billExRBTN.Name = "billExRBTN";
            this.billExRBTN.Size = new System.Drawing.Size(94, 20);
            this.billExRBTN.TabIndex = 20;
            this.billExRBTN.TabStop = true;
            this.billExRBTN.Text = "Bills Export";
            this.billExRBTN.UseVisualStyleBackColor = true;
            this.billExRBTN.CheckedChanged += new System.EventHandler(this.billExRBTN_CheckedChanged);
            // 
            // allBillRBTN
            // 
            this.allBillRBTN.AutoSize = true;
            this.allBillRBTN.Location = new System.Drawing.Point(13, 230);
            this.allBillRBTN.Name = "allBillRBTN";
            this.allBillRBTN.Size = new System.Drawing.Size(43, 20);
            this.allBillRBTN.TabIndex = 21;
            this.allBillRBTN.TabStop = true;
            this.allBillRBTN.Text = "All";
            this.allBillRBTN.UseVisualStyleBackColor = true;
            this.allBillRBTN.CheckedChanged += new System.EventHandler(this.allBillRBTN_CheckedChanged);
            // 
            // frmBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 670);
            this.Controls.Add(this.allBillRBTN);
            this.Controls.Add(this.billExRBTN);
            this.Controls.Add(this.billImRBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.frmBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button suppFormBtn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtAccountantID;
        private System.Windows.Forms.DateTimePicker txtBillDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button agenFormBtn;
        private System.Windows.Forms.RadioButton agenRBTN;
        private System.Windows.Forms.RadioButton suppRBTN;
        private System.Windows.Forms.ComboBox ID_supp_agen;
        private System.Windows.Forms.RadioButton billImRBTN;
        private System.Windows.Forms.RadioButton billExRBTN;
        private System.Windows.Forms.RadioButton allBillRBTN;
        private System.Windows.Forms.ComboBox txtBillID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}