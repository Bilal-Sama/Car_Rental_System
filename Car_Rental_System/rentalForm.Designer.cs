namespace Car_Rental_System
{
    partial class rentalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expected Retun Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actual Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rent Date";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(76, 39);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(121, 21);
            this.cmbCar.TabIndex = 8;
            this.cmbCar.SelectedIndexChanged += new System.EventHandler(this.cmbCar_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(76, 66);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomer.TabIndex = 9;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(76, 93);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 10;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(76, 121);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Location = new System.Drawing.Point(400, 42);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpRentDate.TabIndex = 12;
            this.dtpRentDate.ValueChanged += new System.EventHandler(this.dtpRentDate_ValueChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(400, 68);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnDate.TabIndex = 13;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.Location = new System.Drawing.Point(400, 96);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpActualReturnDate.TabIndex = 14;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(400, 122);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(400, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(484, 214);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(565, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRentals.Location = new System.Drawing.Point(0, 263);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.Size = new System.Drawing.Size(1043, 187);
            this.dgvRentals.TabIndex = 19;
            this.dgvRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellClick);
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(730, 40);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(100, 20);
            this.txtRentalID.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Rental ID";
            // 
            // rentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.dtpActualReturnDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpRentDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.rentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label9;
    }
}