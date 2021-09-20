
namespace EventsInForm
{
    partial class converter
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblChsUnit = new System.Windows.Forms.Label();
            this.radMetrToKilo = new System.Windows.Forms.RadioButton();
            this.radMToMile = new System.Windows.Forms.RadioButton();
            this.radMileToM = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(31, 66);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(59, 28);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(31, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 28);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // lblChsUnit
            // 
            this.lblChsUnit.AutoSize = true;
            this.lblChsUnit.ForeColor = System.Drawing.Color.White;
            this.lblChsUnit.Location = new System.Drawing.Point(339, 20);
            this.lblChsUnit.Name = "lblChsUnit";
            this.lblChsUnit.Size = new System.Drawing.Size(119, 28);
            this.lblChsUnit.TabIndex = 0;
            this.lblChsUnit.Text = "Choose Unit";
            // 
            // radMetrToKilo
            // 
            this.radMetrToKilo.AutoSize = true;
            this.radMetrToKilo.Checked = true;
            this.radMetrToKilo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMetrToKilo.Location = new System.Drawing.Point(322, 61);
            this.radMetrToKilo.Name = "radMetrToKilo";
            this.radMetrToKilo.Size = new System.Drawing.Size(133, 29);
            this.radMetrToKilo.TabIndex = 1;
            this.radMetrToKilo.TabStop = true;
            this.radMetrToKilo.Text = "Meter To Kilo";
            this.radMetrToKilo.UseVisualStyleBackColor = true;
            // 
            // radMToMile
            // 
            this.radMToMile.AutoSize = true;
            this.radMToMile.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMToMile.Location = new System.Drawing.Point(322, 99);
            this.radMToMile.Name = "radMToMile";
            this.radMToMile.Size = new System.Drawing.Size(137, 29);
            this.radMToMile.TabIndex = 1;
            this.radMToMile.Text = "Meter To Mile";
            this.radMToMile.UseVisualStyleBackColor = true;
            // 
            // radMileToM
            // 
            this.radMileToM.AutoSize = true;
            this.radMileToM.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMileToM.ForeColor = System.Drawing.Color.Black;
            this.radMileToM.Location = new System.Drawing.Point(322, 137);
            this.radMileToM.Name = "radMileToM";
            this.radMileToM.Size = new System.Drawing.Size(137, 29);
            this.radMileToM.TabIndex = 1;
            this.radMileToM.Text = "Mile To Meter";
            this.radMileToM.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.MistyRose;
            this.btnConvert.Location = new System.Drawing.Point(171, 199);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(172, 48);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(112, 61);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(167, 34);
            this.txtValue.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(112, 125);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(167, 34);
            this.txtResult.TabIndex = 3;
            // 
            // converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(509, 271);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radMileToM);
            this.Controls.Add(this.radMToMile);
            this.Controls.Add(this.radMetrToKilo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblChsUnit);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblChsUnit;
        private System.Windows.Forms.RadioButton radMetrToKilo;
        private System.Windows.Forms.RadioButton radMToMile;
        private System.Windows.Forms.RadioButton radMileToM;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
    }
}

