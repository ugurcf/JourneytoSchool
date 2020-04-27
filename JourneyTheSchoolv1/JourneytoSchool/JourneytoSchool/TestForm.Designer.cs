namespace JourneytoSchool
{
    partial class TestForm
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
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxDist = new System.Windows.Forms.TextBox();
            this.txtBoxFriends = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblFriend = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAge.Location = new System.Drawing.Point(434, 37);
            this.txtBoxAge.Multiline = true;
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(83, 33);
            this.txtBoxAge.TabIndex = 4;
            this.txtBoxAge.Text = "0";
            // 
            // txtBoxDist
            // 
            this.txtBoxDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDist.Location = new System.Drawing.Point(434, 91);
            this.txtBoxDist.Multiline = true;
            this.txtBoxDist.Name = "txtBoxDist";
            this.txtBoxDist.Size = new System.Drawing.Size(83, 33);
            this.txtBoxDist.TabIndex = 5;
            this.txtBoxDist.Text = "0";
            // 
            // txtBoxFriends
            // 
            this.txtBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxFriends.Location = new System.Drawing.Point(434, 148);
            this.txtBoxFriends.Multiline = true;
            this.txtBoxFriends.Name = "txtBoxFriends";
            this.txtBoxFriends.Size = new System.Drawing.Size(83, 33);
            this.txtBoxFriends.TabIndex = 6;
            this.txtBoxFriends.Text = "0";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(37, 45);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 25);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age:";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDist.Location = new System.Drawing.Point(37, 99);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(94, 25);
            this.lblDist.TabIndex = 12;
            this.lblDist.Text = "Distance:";
            // 
            // lblFriend
            // 
            this.lblFriend.AutoSize = true;
            this.lblFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFriend.Location = new System.Drawing.Point(37, 156);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(234, 25);
            this.lblFriend.TabIndex = 13;
            this.lblFriend.Text = "Nearbly Siblings & Friends:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMethod.Location = new System.Drawing.Point(37, 217);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(347, 25);
            this.lblMethod.TabIndex = 15;
            this.lblMethod.Text = "Most common method to get to school:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(429, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "0";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtBoxFriends);
            this.Controls.Add(this.txtBoxDist);
            this.Controls.Add(this.txtBoxAge);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxDist;
        private System.Windows.Forms.TextBox txtBoxFriends;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label label1;
    }
}