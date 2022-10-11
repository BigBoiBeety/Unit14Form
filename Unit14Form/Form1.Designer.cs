
namespace Unit14Form
{
    partial class Form1
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
            this.btnStartSerial = new System.Windows.Forms.Button();
            this.cbPortSelector = new System.Windows.Forms.ComboBox();
            this.tbSerialInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRadar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRadar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSerial
            // 
            this.btnStartSerial.Location = new System.Drawing.Point(12, 39);
            this.btnStartSerial.Name = "btnStartSerial";
            this.btnStartSerial.Size = new System.Drawing.Size(102, 52);
            this.btnStartSerial.TabIndex = 0;
            this.btnStartSerial.Text = "Start Serial";
            this.btnStartSerial.UseVisualStyleBackColor = true;
            this.btnStartSerial.Click += new System.EventHandler(this.btnStartSerial_Click);
            // 
            // cbPortSelector
            // 
            this.cbPortSelector.FormattingEnabled = true;
            this.cbPortSelector.Location = new System.Drawing.Point(12, 12);
            this.cbPortSelector.Name = "cbPortSelector";
            this.cbPortSelector.Size = new System.Drawing.Size(102, 21);
            this.cbPortSelector.TabIndex = 1;
            // 
            // tbSerialInput
            // 
            this.tbSerialInput.Location = new System.Drawing.Point(136, 39);
            this.tbSerialInput.Multiline = true;
            this.tbSerialInput.Name = "tbSerialInput";
            this.tbSerialInput.Size = new System.Drawing.Size(311, 399);
            this.tbSerialInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial Input";
            // 
            // pbRadar
            // 
            this.pbRadar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRadar.Location = new System.Drawing.Point(474, 39);
            this.pbRadar.Name = "pbRadar";
            this.pbRadar.Size = new System.Drawing.Size(297, 399);
            this.pbRadar.TabIndex = 4;
            this.pbRadar.TabStop = false;
            this.pbRadar.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRadar_Paint);
            this.pbRadar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRadar_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbRadar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSerialInput);
            this.Controls.Add(this.cbPortSelector);
            this.Controls.Add(this.btnStartSerial);
            this.Name = "Form1";
            this.Text = "Robot Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRadar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSerial;
        private System.Windows.Forms.ComboBox cbPortSelector;
        private System.Windows.Forms.TextBox tbSerialInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRadar;
    }
}

