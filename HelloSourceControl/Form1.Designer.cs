namespace HelloSourceControl {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbxHelloWorld = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxHelloThere = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxHelloWorld
            // 
            this.tbxHelloWorld.Enabled = false;
            this.tbxHelloWorld.Location = new System.Drawing.Point(12, 12);
            this.tbxHelloWorld.Name = "tbxHelloWorld";
            this.tbxHelloWorld.Size = new System.Drawing.Size(162, 20);
            this.tbxHelloWorld.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(99, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxHelloThere
            // 
            this.cbxHelloThere.AutoSize = true;
            this.cbxHelloThere.Location = new System.Drawing.Point(12, 38);
            this.cbxHelloThere.Name = "cbxHelloThere";
            this.cbxHelloThere.Size = new System.Drawing.Size(81, 17);
            this.cbxHelloThere.TabIndex = 2;
            this.cbxHelloThere.Text = "Hello There";
            this.cbxHelloThere.UseVisualStyleBackColor = true;
            this.cbxHelloThere.CheckedChanged += new System.EventHandler(this.cbxHelloThere_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 74);
            this.Controls.Add(this.cbxHelloThere);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxHelloWorld;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbxHelloThere;
    }
}

