namespace Bunkerrh_Final_Project
{
    partial class stateForm
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
            this.lblStates = new System.Windows.Forms.Label();
            this.CB_States = new System.Windows.Forms.ComboBox();
            this.btn_stateSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStates.Location = new System.Drawing.Point(34, 60);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(603, 46);
            this.lblStates.TabIndex = 0;
            this.lblStates.Text = "What State Are You Traveling To";
            // 
            // CB_States
            // 
            this.CB_States.FormattingEnabled = true;
            this.CB_States.Location = new System.Drawing.Point(222, 109);
            this.CB_States.Name = "CB_States";
            this.CB_States.Size = new System.Drawing.Size(196, 24);
            this.CB_States.TabIndex = 2;
            // 
            // btn_stateSubmit
            // 
            this.btn_stateSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stateSubmit.Location = new System.Drawing.Point(149, 139);
            this.btn_stateSubmit.Name = "btn_stateSubmit";
            this.btn_stateSubmit.Size = new System.Drawing.Size(356, 188);
            this.btn_stateSubmit.TabIndex = 3;
            this.btn_stateSubmit.Text = "Submit";
            this.btn_stateSubmit.UseVisualStyleBackColor = true;
            this.btn_stateSubmit.Click += new System.EventHandler(this.btn_stateSubmit_Click);
            // 
            // stateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 363);
            this.Controls.Add(this.btn_stateSubmit);
            this.Controls.Add(this.CB_States);
            this.Controls.Add(this.lblStates);
            this.Name = "stateForm";
            this.Text = "stateForm";
            this.Load += new System.EventHandler(this.stateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.ComboBox CB_States;
        private System.Windows.Forms.Button btn_stateSubmit;
    }
}