namespace BeerPubProject.GUI
{
    partial class BeerPubForm
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
            this.lbBeersInPub = new System.Windows.Forms.ListBox();
            this.btnShowAllBeers = new System.Windows.Forms.Button();
            this.btnCheapestBeer = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCreateBeer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbBeerInfo = new System.Windows.Forms.GroupBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.gbBeerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBeersInPub
            // 
            this.lbBeersInPub.FormattingEnabled = true;
            this.lbBeersInPub.Location = new System.Drawing.Point(12, 13);
            this.lbBeersInPub.Name = "lbBeersInPub";
            this.lbBeersInPub.Size = new System.Drawing.Size(236, 238);
            this.lbBeersInPub.TabIndex = 0;
            this.lbBeersInPub.SelectedIndexChanged += new System.EventHandler(this.lbBeersInPub_SelectedIndexChanged);
            // 
            // btnShowAllBeers
            // 
            this.btnShowAllBeers.Location = new System.Drawing.Point(12, 265);
            this.btnShowAllBeers.Name = "btnShowAllBeers";
            this.btnShowAllBeers.Size = new System.Drawing.Size(86, 40);
            this.btnShowAllBeers.TabIndex = 1;
            this.btnShowAllBeers.Text = "Show All Beers";
            this.btnShowAllBeers.UseVisualStyleBackColor = true;
            // 
            // btnCheapestBeer
            // 
            this.btnCheapestBeer.Location = new System.Drawing.Point(104, 265);
            this.btnCheapestBeer.Name = "btnCheapestBeer";
            this.btnCheapestBeer.Size = new System.Drawing.Size(86, 40);
            this.btnCheapestBeer.TabIndex = 2;
            this.btnCheapestBeer.Text = "Cheapest Beer";
            this.btnCheapestBeer.UseVisualStyleBackColor = true;
            this.btnCheapestBeer.Click += new System.EventHandler(this.btnCheapestBeer_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(28, 90);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(61, 20);
            this.txtVolume.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(28, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(61, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(25, 74);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(25, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // btnCreateBeer
            // 
            this.btnCreateBeer.Location = new System.Drawing.Point(260, 265);
            this.btnCreateBeer.Name = "btnCreateBeer";
            this.btnCreateBeer.Size = new System.Drawing.Size(61, 40);
            this.btnCreateBeer.TabIndex = 9;
            this.btnCreateBeer.Text = "Create";
            this.btnCreateBeer.UseVisualStyleBackColor = true;
            this.btnCreateBeer.Click += new System.EventHandler(this.btnCreateBeer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(327, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbBeerInfo
            // 
            this.gbBeerInfo.Controls.Add(this.lblName);
            this.gbBeerInfo.Controls.Add(this.txtName);
            this.gbBeerInfo.Controls.Add(this.txtVolume);
            this.gbBeerInfo.Controls.Add(this.txtPrice);
            this.gbBeerInfo.Controls.Add(this.lblVolume);
            this.gbBeerInfo.Controls.Add(this.lblPrice);
            this.gbBeerInfo.Location = new System.Drawing.Point(254, 12);
            this.gbBeerInfo.Name = "gbBeerInfo";
            this.gbBeerInfo.Size = new System.Drawing.Size(200, 239);
            this.gbBeerInfo.TabIndex = 14;
            this.gbBeerInfo.TabStop = false;
            this.gbBeerInfo.Text = "Beer Information";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(260, 323);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(61, 40);
            this.btnClearForm.TabIndex = 15;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // BeerPubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 372);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.gbBeerInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateBeer);
            this.Controls.Add(this.btnCheapestBeer);
            this.Controls.Add(this.btnShowAllBeers);
            this.Controls.Add(this.lbBeersInPub);
            this.Name = "BeerPubForm";
            this.Text = "BeerPub";
            this.gbBeerInfo.ResumeLayout(false);
            this.gbBeerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBeersInPub;
        private System.Windows.Forms.Button btnShowAllBeers;
        private System.Windows.Forms.Button btnCheapestBeer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCreateBeer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbBeerInfo;
        private System.Windows.Forms.Button btnClearForm;
    }
}

