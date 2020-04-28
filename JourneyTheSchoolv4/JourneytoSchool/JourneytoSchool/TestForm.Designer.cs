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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxDist = new System.Windows.Forms.TextBox();
            this.txtBoxFriends = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblFriend = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSchool2 = new System.Windows.Forms.PictureBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAge.Location = new System.Drawing.Point(511, 276);
            this.txtBoxAge.Multiline = true;
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(184, 33);
            this.txtBoxAge.TabIndex = 4;
            this.txtBoxAge.Text = "0";
            // 
            // txtBoxDist
            // 
            this.txtBoxDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDist.Location = new System.Drawing.Point(511, 330);
            this.txtBoxDist.Multiline = true;
            this.txtBoxDist.Name = "txtBoxDist";
            this.txtBoxDist.Size = new System.Drawing.Size(184, 33);
            this.txtBoxDist.TabIndex = 5;
            this.txtBoxDist.Text = "0";
            // 
            // txtBoxFriends
            // 
            this.txtBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxFriends.Location = new System.Drawing.Point(511, 387);
            this.txtBoxFriends.Multiline = true;
            this.txtBoxFriends.Name = "txtBoxFriends";
            this.txtBoxFriends.Size = new System.Drawing.Size(184, 33);
            this.txtBoxFriends.TabIndex = 6;
            this.txtBoxFriends.Text = "0";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(114, 284);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 25);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age:";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDist.Location = new System.Drawing.Point(114, 338);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(94, 25);
            this.lblDist.TabIndex = 12;
            this.lblDist.Text = "Distance:";
            // 
            // lblFriend
            // 
            this.lblFriend.AutoSize = true;
            this.lblFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFriend.Location = new System.Drawing.Point(114, 395);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(234, 25);
            this.lblFriend.TabIndex = 13;
            this.lblFriend.Text = "Nearbly Siblings & Friends:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMethod.Location = new System.Drawing.Point(114, 456);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(347, 25);
            this.lblMethod.TabIndex = 15;
            this.lblMethod.Text = "Most common method to get to school:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(506, 456);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(23, 25);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxSchool2);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 237);
            this.panel1.TabIndex = 17;
            // 
            // pictureBoxSchool2
            // 
            this.pictureBoxSchool2.BackColor = System.Drawing.Color.White;
            this.pictureBoxSchool2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchool2.Image")));
            this.pictureBoxSchool2.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxSchool2.Name = "pictureBoxSchool2";
            this.pictureBoxSchool2.Size = new System.Drawing.Size(765, 235);
            this.pictureBoxSchool2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchool2.TabIndex = 0;
            this.pictureBoxSchool2.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.Location = new System.Drawing.Point(580, 552);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(115, 52);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 632);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblFriend);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtBoxFriends);
            this.Controls.Add(this.txtBoxDist);
            this.Controls.Add(this.txtBoxAge);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchool2)).EndInit();
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxSchool2;
        private System.Windows.Forms.Button btnTest;
    }
}