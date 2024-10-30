namespace Inventory_app
{
    partial class Adminpage
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
            this.btnuser = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnmanage = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // btnuser
            // 
            this.btnuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuser.Location = new System.Drawing.Point(30, 145);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(213, 85);
            this.btnuser.TabIndex = 2;
            this.btnuser.Text = "Add User";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnview
            // 
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.Location = new System.Drawing.Point(561, 145);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(209, 85);
            this.btnview.TabIndex = 3;
            this.btnview.Text = "View/Manage Inventory";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnmanage
            // 
            this.btnmanage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmanage.Location = new System.Drawing.Point(294, 145);
            this.btnmanage.Name = "btnmanage";
            this.btnmanage.Size = new System.Drawing.Size(213, 85);
            this.btnmanage.TabIndex = 4;
            this.btnmanage.Text = "Manage User";
            this.btnmanage.UseVisualStyleBackColor = true;
            this.btnmanage.Click += new System.EventHandler(this.btnmanage_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Location = new System.Drawing.Point(667, 13);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(121, 23);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnmanage);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.label1);
            this.Name = "Adminpage";
            this.Text = "Adminpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnmanage;
        private System.Windows.Forms.Button btnlogout;
    }
}