/************************************
 * Ryan Bunker
 * Final Project
 * IT 3045
 * Due December 4 2017
 * Prof: Bill Nicholson
 * Create the GUI for GPS software
 * 
 * *********************************/
namespace Bunkerrh_Final_Project
{
    partial class addressNumber
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
            this.tb_addressNumber = new System.Windows.Forms.TextBox();
            this.lbl_addressNumber = new System.Windows.Forms.Label();
            this.btn_addressNumberSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_addressNumber
            // 
            this.tb_addressNumber.Location = new System.Drawing.Point(12, 93);
            this.tb_addressNumber.Name = "tb_addressNumber";
            this.tb_addressNumber.Size = new System.Drawing.Size(659, 22);
            this.tb_addressNumber.TabIndex = 0;
            // 
            // lbl_addressNumber
            // 
            this.lbl_addressNumber.AutoSize = true;
            this.lbl_addressNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addressNumber.Location = new System.Drawing.Point(161, 9);
            this.lbl_addressNumber.Name = "lbl_addressNumber";
            this.lbl_addressNumber.Size = new System.Drawing.Size(345, 51);
            this.lbl_addressNumber.TabIndex = 1;
            this.lbl_addressNumber.Text = "Address Number";
            // 
            // btn_addressNumberSubmit
            // 
            this.btn_addressNumberSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addressNumberSubmit.Location = new System.Drawing.Point(77, 121);
            this.btn_addressNumberSubmit.Name = "btn_addressNumberSubmit";
            this.btn_addressNumberSubmit.Size = new System.Drawing.Size(208, 77);
            this.btn_addressNumberSubmit.TabIndex = 2;
            this.btn_addressNumberSubmit.Text = "Submit";
            this.btn_addressNumberSubmit.UseVisualStyleBackColor = true;
            this.btn_addressNumberSubmit.Click += new System.EventHandler(this.btn_addressNumberSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(291, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 77);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addressNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 363);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_addressNumberSubmit);
            this.Controls.Add(this.lbl_addressNumber);
            this.Controls.Add(this.tb_addressNumber);
            this.Name = "addressNumber";
            this.Text = "addressNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_addressNumber;
        private System.Windows.Forms.Label lbl_addressNumber;
        private System.Windows.Forms.Button btn_addressNumberSubmit;
        private System.Windows.Forms.Button btnBack;
    }
}