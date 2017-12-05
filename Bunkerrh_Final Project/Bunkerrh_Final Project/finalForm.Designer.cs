namespace Bunkerrh_Final_Project
{
    partial class finalForm
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
            this.tb_streetAddress = new System.Windows.Forms.TextBox();
            this.tb_cityStateZip = new System.Windows.Forms.TextBox();
            this.pb_destination = new System.Windows.Forms.PictureBox();
            this.btn_newDest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_destination)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_streetAddress
            // 
            this.tb_streetAddress.Location = new System.Drawing.Point(13, 40);
            this.tb_streetAddress.Name = "tb_streetAddress";
            this.tb_streetAddress.Size = new System.Drawing.Size(284, 22);
            this.tb_streetAddress.TabIndex = 0;
            // 
            // tb_cityStateZip
            // 
            this.tb_cityStateZip.Location = new System.Drawing.Point(13, 69);
            this.tb_cityStateZip.Name = "tb_cityStateZip";
            this.tb_cityStateZip.Size = new System.Drawing.Size(284, 22);
            this.tb_cityStateZip.TabIndex = 1;
            // 
            // pb_destination
            // 
            this.pb_destination.Location = new System.Drawing.Point(303, 12);
            this.pb_destination.Name = "pb_destination";
            this.pb_destination.Size = new System.Drawing.Size(1134, 730);
            this.pb_destination.TabIndex = 2;
            this.pb_destination.TabStop = false;
            // 
            // btn_newDest
            // 
            this.btn_newDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newDest.Location = new System.Drawing.Point(13, 113);
            this.btn_newDest.Name = "btn_newDest";
            this.btn_newDest.Size = new System.Drawing.Size(284, 95);
            this.btn_newDest.TabIndex = 3;
            this.btn_newDest.Text = "New Destination";
            this.btn_newDest.UseVisualStyleBackColor = true;
            this.btn_newDest.Click += new System.EventHandler(this.btn_newDest_Click);
            // 
            // finalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 754);
            this.Controls.Add(this.btn_newDest);
            this.Controls.Add(this.pb_destination);
            this.Controls.Add(this.tb_cityStateZip);
            this.Controls.Add(this.tb_streetAddress);
            this.Name = "finalForm";
            this.Text = "finalForm";
            this.Load += new System.EventHandler(this.finalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_destination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_streetAddress;
        private System.Windows.Forms.TextBox tb_cityStateZip;
        private System.Windows.Forms.PictureBox pb_destination;
        private System.Windows.Forms.Button btn_newDest;
    }
}