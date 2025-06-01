namespace Car_Rental_System
{
    partial class CarsForm
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
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.lblRentalRate = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtRentalRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(79, 12);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.ReadOnly = true;
            this.txtCarID.Size = new System.Drawing.Size(100, 20);
            this.txtCarID.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(77, 55);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 6;
            this.txtBrand.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(77, 92);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(71, 140);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Maintenance"});
            this.cmbStatus.Location = new System.Drawing.Point(77, 168);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(170, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(506, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCars.Location = new System.Drawing.Point(0, 300);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.Size = new System.Drawing.Size(800, 150);
            this.dgvCars.TabIndex = 13;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Location = new System.Drawing.Point(217, 39);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(71, 13);
            this.lblNumberPlate.TabIndex = 14;
            this.lblNumberPlate.Text = "Number Plate";
            // 
            // lblRentalRate
            // 
            this.lblRentalRate.AutoSize = true;
            this.lblRentalRate.Location = new System.Drawing.Point(217, 64);
            this.lblRentalRate.Name = "lblRentalRate";
            this.lblRentalRate.Size = new System.Drawing.Size(64, 13);
            this.lblRentalRate.TabIndex = 15;
            this.lblRentalRate.Text = "Rental Rate";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(294, 39);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(100, 20);
            this.txtNumberPlate.TabIndex = 16;
            // 
            // txtRentalRate
            // 
            this.txtRentalRate.Location = new System.Drawing.Point(294, 64);
            this.txtRentalRate.Name = "txtRentalRate";
            this.txtRentalRate.Size = new System.Drawing.Size(100, 20);
            this.txtRentalRate.TabIndex = 17;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRentalRate);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.lblRentalRate);
            this.Controls.Add(this.lblNumberPlate);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.Label lblRentalRate;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtRentalRate;
        
    }
}