
namespace DataLabs_TheCompany
{
    partial class MainForm
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
            this.bt_AddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_AddPerson
            // 
            this.bt_AddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AddPerson.Location = new System.Drawing.Point(143, 99);
            this.bt_AddPerson.Name = "bt_AddPerson";
            this.bt_AddPerson.Size = new System.Drawing.Size(95, 36);
            this.bt_AddPerson.TabIndex = 0;
            this.bt_AddPerson.Text = "Add Person";
            this.bt_AddPerson.UseVisualStyleBackColor = true;
            this.bt_AddPerson.Click += new System.EventHandler(this.bt_AddPerson_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.bt_AddPerson);
            this.Name = "MainForm";
            this.Text = "The Company Mainfraim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_AddPerson;
    }
}

