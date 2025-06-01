namespace Car_Rental_System
{
    partial class paymentsForm
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
            this.lblRental = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRentalID = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment ID";
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Location = new System.Drawing.Point(83, 61);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(52, 13);
            this.lblRental.TabIndex = 1;
            this.lblRental.Text = "Rental ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notes";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(545, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(464, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPayments.Location = new System.Drawing.Point(0, 247);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(800, 203);
            this.dgvPayments.TabIndex = 8;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(141, 33);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentID.TabIndex = 9;
            this.txtPaymentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(141, 111);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(428, 29);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(216, 87);
            this.txtNotes.TabIndex = 11;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(141, 85);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPaymentDate.TabIndex = 12;
            // 
            // cmbRentalID
            // 
            this.cmbRentalID.FormattingEnabled = true;
            this.cmbRentalID.Location = new System.Drawing.Point(141, 58);
            this.cmbRentalID.Name = "cmbRentalID";
            this.cmbRentalID.Size = new System.Drawing.Size(121, 21);
            this.cmbRentalID.TabIndex = 13;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(141, 137);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbPaymentMethod.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(626, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(707, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // paymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.cmbRentalID);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "paymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentsForm";
            this.Load += new System.EventHandler(this.paymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.ComboBox cmbRentalID;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}