namespace VendingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbFlashDrive = new PictureBox();
            pbGamerFuel = new PictureBox();
            pbPeach = new PictureBox();
            pbRedPony = new PictureBox();
            pbZergling = new PictureBox();
            txtDisplay = new TextBox();
            btnVendOver = new Button();
            btnCard = new Button();
            pbLogo = new PictureBox();
            pbFungiFriends = new PictureBox();
            pbTravelingGuitarist = new PictureBox();
            pbNurse = new PictureBox();
            pbMotorcycle = new PictureBox();
            splitContainer1 = new SplitContainer();
            txtCardValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFlashDrive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGamerFuel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPeach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRedPony).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbZergling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFungiFriends).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTravelingGuitarist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNurse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMotorcycle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // pbFlashDrive
            // 
            pbFlashDrive.Image = (Image)resources.GetObject("pbFlashDrive.Image");
            pbFlashDrive.Location = new Point(182, 533);
            pbFlashDrive.Margin = new Padding(4);
            pbFlashDrive.Name = "pbFlashDrive";
            pbFlashDrive.Size = new Size(106, 64);
            pbFlashDrive.TabIndex = 1;
            pbFlashDrive.TabStop = false;
            pbFlashDrive.Click += pbFlashDrive_Click;
            // 
            // pbGamerFuel
            // 
            pbGamerFuel.Image = (Image)resources.GetObject("pbGamerFuel.Image");
            pbGamerFuel.Location = new Point(182, 407);
            pbGamerFuel.Margin = new Padding(4);
            pbGamerFuel.Name = "pbGamerFuel";
            pbGamerFuel.Size = new Size(97, 101);
            pbGamerFuel.TabIndex = 2;
            pbGamerFuel.TabStop = false;
            pbGamerFuel.Click += pbGamerFuel_Click;
            // 
            // pbPeach
            // 
            pbPeach.Image = (Image)resources.GetObject("pbPeach.Image");
            pbPeach.Location = new Point(187, 627);
            pbPeach.Margin = new Padding(4);
            pbPeach.Name = "pbPeach";
            pbPeach.Size = new Size(101, 59);
            pbPeach.TabIndex = 3;
            pbPeach.TabStop = false;
            pbPeach.Click += pbPeach_Click;
            // 
            // pbRedPony
            // 
            pbRedPony.Image = (Image)resources.GetObject("pbRedPony.Image");
            pbRedPony.Location = new Point(182, 341);
            pbRedPony.Margin = new Padding(4);
            pbRedPony.Name = "pbRedPony";
            pbRedPony.Size = new Size(97, 44);
            pbRedPony.TabIndex = 4;
            pbRedPony.TabStop = false;
            pbRedPony.Click += pbRedPony_Click;
            // 
            // pbZergling
            // 
            pbZergling.Image = (Image)resources.GetObject("pbZergling.Image");
            pbZergling.Location = new Point(59, 341);
            pbZergling.Margin = new Padding(4);
            pbZergling.Name = "pbZergling";
            pbZergling.Size = new Size(101, 102);
            pbZergling.TabIndex = 5;
            pbZergling.TabStop = false;
            pbZergling.Click += pbZergling_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(59, 25);
            txtDisplay.Margin = new Padding(4);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(598, 229);
            txtDisplay.TabIndex = 6;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnVendOver
            // 
            btnVendOver.Location = new Point(216, 341);
            btnVendOver.Margin = new Padding(4);
            btnVendOver.Name = "btnVendOver";
            btnVendOver.Size = new Size(125, 32);
            btnVendOver.TabIndex = 7;
            btnVendOver.Text = "End Purchase";
            btnVendOver.UseVisualStyleBackColor = true;
            btnVendOver.Click += btnVendOver_Click;
            // 
            // btnCard
            // 
            btnCard.Location = new Point(20, 341);
            btnCard.Margin = new Padding(4);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(96, 32);
            btnCard.TabIndex = 8;
            btnCard.Text = "Insert Card";
            btnCard.UseVisualStyleBackColor = true;
            btnCard.Click += btnCard_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(91, 37);
            pbLogo.Margin = new Padding(4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(193, 196);
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // pbFungiFriends
            // 
            pbFungiFriends.Image = (Image)resources.GetObject("pbFungiFriends.Image");
            pbFungiFriends.Location = new Point(305, 341);
            pbFungiFriends.Margin = new Padding(4);
            pbFungiFriends.Name = "pbFungiFriends";
            pbFungiFriends.Size = new Size(114, 153);
            pbFungiFriends.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFungiFriends.TabIndex = 10;
            pbFungiFriends.TabStop = false;
            pbFungiFriends.Click += pbFungiFriends_Click;
            // 
            // pbTravelingGuitarist
            // 
            pbTravelingGuitarist.Image = (Image)resources.GetObject("pbTravelingGuitarist.Image");
            pbTravelingGuitarist.Location = new Point(438, 341);
            pbTravelingGuitarist.Margin = new Padding(4);
            pbTravelingGuitarist.Name = "pbTravelingGuitarist";
            pbTravelingGuitarist.Size = new Size(219, 345);
            pbTravelingGuitarist.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTravelingGuitarist.TabIndex = 11;
            pbTravelingGuitarist.TabStop = false;
            pbTravelingGuitarist.Click += pbTravelingGuitarist_Click;
            // 
            // pbNurse
            // 
            pbNurse.Image = (Image)resources.GetObject("pbNurse.Image");
            pbNurse.Location = new Point(59, 533);
            pbNurse.Margin = new Padding(4);
            pbNurse.Name = "pbNurse";
            pbNurse.Size = new Size(105, 153);
            pbNurse.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNurse.TabIndex = 12;
            pbNurse.TabStop = false;
            pbNurse.Click += pbNurse_Click;
            // 
            // pbMotorcycle
            // 
            pbMotorcycle.Image = (Image)resources.GetObject("pbMotorcycle.Image");
            pbMotorcycle.Location = new Point(305, 533);
            pbMotorcycle.Margin = new Padding(4);
            pbMotorcycle.Name = "pbMotorcycle";
            pbMotorcycle.Size = new Size(105, 153);
            pbMotorcycle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMotorcycle.TabIndex = 13;
            pbMotorcycle.TabStop = false;
            pbMotorcycle.Click += pbMotorcycle_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pbZergling);
            splitContainer1.Panel1.Controls.Add(txtDisplay);
            splitContainer1.Panel1.Controls.Add(pbTravelingGuitarist);
            splitContainer1.Panel1.Controls.Add(pbNurse);
            splitContainer1.Panel1.Controls.Add(pbMotorcycle);
            splitContainer1.Panel1.Controls.Add(pbRedPony);
            splitContainer1.Panel1.Controls.Add(pbFlashDrive);
            splitContainer1.Panel1.Controls.Add(pbGamerFuel);
            splitContainer1.Panel1.Controls.Add(pbPeach);
            splitContainer1.Panel1.Controls.Add(pbFungiFriends);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtCardValue);
            splitContainer1.Panel2.Controls.Add(btnCard);
            splitContainer1.Panel2.Controls.Add(btnVendOver);
            splitContainer1.Panel2.Controls.Add(pbLogo);
            splitContainer1.Size = new Size(1064, 746);
            splitContainer1.SplitterDistance = 704;
            splitContainer1.TabIndex = 14;
            // 
            // txtCardValue
            // 
            txtCardValue.Location = new Point(78, 427);
            txtCardValue.Multiline = true;
            txtCardValue.Name = "txtCardValue";
            txtCardValue.ReadOnly = true;
            txtCardValue.Size = new Size(206, 217);
            txtCardValue.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 963);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbFlashDrive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGamerFuel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPeach).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRedPony).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbZergling).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFungiFriends).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTravelingGuitarist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNurse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMotorcycle).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFlashDrive;
        private PictureBox pbGamerFuel;
        private PictureBox pbPeach;
        private PictureBox pbRedPony;
        private PictureBox pbZergling;
        private TextBox txtDisplay;
        private Button btnVendOver;
        private Button btnCard;
        private PictureBox pbLogo;
        private PictureBox pbFungiFriends;
        private PictureBox pbTravelingGuitarist;
        private PictureBox pbNurse;
        private PictureBox pbMotorcycle;
        private SplitContainer splitContainer1;
        private TextBox txtCardValue;
    }
}
