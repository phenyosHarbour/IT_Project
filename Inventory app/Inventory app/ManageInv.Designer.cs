namespace Inventory_app
{
    partial class ManageInv
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvinvview1 = new System.Windows.Forms.DataGridView();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btnsave1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Items list: ";
            // 
            // dgvinvview1
            // 
            this.dgvinvview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvview1.Location = new System.Drawing.Point(13, 84);
            this.dgvinvview1.Name = "dgvinvview1";
            this.dgvinvview1.Size = new System.Drawing.Size(775, 282);
            this.dgvinvview1.TabIndex = 2;
            // 
            // btndelete1
            // 
            this.btndelete1.BackColor = System.Drawing.Color.Red;
            this.btndelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete1.Location = new System.Drawing.Point(70, 391);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(131, 33);
            this.btndelete1.TabIndex = 3;
            this.btndelete1.Text = "Delete Row";
            this.btndelete1.UseVisualStyleBackColor = false;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btnsave1
            // 
            this.btnsave1.BackColor = System.Drawing.Color.Lime;
            this.btnsave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave1.Location = new System.Drawing.Point(612, 391);
            this.btnsave1.Name = "btnsave1";
            this.btnsave1.Size = new System.Drawing.Size(133, 33);
            this.btnsave1.TabIndex = 4;
            this.btnsave1.Text = "Save Changes";
            this.btnsave1.UseVisualStyleBackColor = false;
            this.btnsave1.Click += new System.EventHandler(this.btnsave1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(606, 11);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 27;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.Location = new System.Drawing.Point(693, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(95, 23);
            this.btnlogout.TabIndex = 26;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // ManageInv
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsave1);
            this.Controls.Add(this.btndelete1);
            this.Controls.Add(this.dgvinvview1);
            this.Controls.Add(this.label3);
            this.Name = "ManageInv";
            this.Load += new System.EventHandler(this.ManageInv_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInvview;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip munu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvinvview1;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btnsave1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnlogout;
    }
}