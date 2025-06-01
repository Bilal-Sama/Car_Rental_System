namespace Car_Rental_System
{
    partial class Main
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(428, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(696, 104);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManageUsers.Size = new System.Drawing.Size(92, 43);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "🛠 Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnCars
            // 
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Location = new System.Drawing.Point(219, 395);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(92, 43);
            this.btnCars.TabIndex = 2;
            this.btnCars.Text = "🚗 Cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // btnRentals
            // 
            this.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentals.Location = new System.Drawing.Point(317, 395);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(92, 43);
            this.btnRentals.TabIndex = 5;
            this.btnRentals.Text = "📋 Rentals";
            this.btnRentals.UseVisualStyleBackColor = true;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Location = new System.Drawing.Point(415, 395);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(92, 43);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "💵 Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(696, 395);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 43);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(696, 153);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(92, 43);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "👤 Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnRentals);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomers;
    }
}