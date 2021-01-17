namespace ChemistryApp
{
    partial class frmMWC
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
            this.txtMolecule = new System.Windows.Forms.TextBox();
            this.lblMolecule = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMolecule
            // 
            this.txtMolecule.Location = new System.Drawing.Point(100, 39);
            this.txtMolecule.Name = "txtMolecule";
            this.txtMolecule.Size = new System.Drawing.Size(100, 20);
            this.txtMolecule.TabIndex = 0;
            this.txtMolecule.TextChanged += new System.EventHandler(this.txtMolecule_TextChanged);
            // 
            // lblMolecule
            // 
            this.lblMolecule.AutoSize = true;
            this.lblMolecule.Location = new System.Drawing.Point(13, 42);
            this.lblMolecule.Name = "lblMolecule";
            this.lblMolecule.Size = new System.Drawing.Size(81, 13);
            this.lblMolecule.TabIndex = 1;
            this.lblMolecule.Text = "Enter Molecule:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(233, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(217, 185);
            this.txtOutput.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(125, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMWC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 218);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblMolecule);
            this.Controls.Add(this.txtMolecule);
            this.Name = "frmMWC";
            this.Text = "Molecular Weight Calculator";
            this.Load += new System.EventHandler(this.frmMWC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMolecule;
        private System.Windows.Forms.Label lblMolecule;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCalculate;
    }
}