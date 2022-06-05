
namespace DataLabs_TheCompany
{
    partial class PowersForm
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
            this.lb_Powers = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tb_Power = new System.Windows.Forms.TextBox();
            this.tb_PowerDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Powers
            // 
            this.lb_Powers.FormattingEnabled = true;
            this.lb_Powers.Location = new System.Drawing.Point(12, 12);
            this.lb_Powers.Name = "lb_Powers";
            this.lb_Powers.Size = new System.Drawing.Size(171, 290);
            this.lb_Powers.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(235, 30);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add new";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(235, 250);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(129, 392);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Cancel";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tb_Power
            // 
            this.tb_Power.Location = new System.Drawing.Point(212, 73);
            this.tb_Power.Name = "tb_Power";
            this.tb_Power.Size = new System.Drawing.Size(113, 20);
            this.tb_Power.TabIndex = 4;
            // 
            // tb_PowerDescription
            // 
            this.tb_PowerDescription.Location = new System.Drawing.Point(212, 120);
            this.tb_PowerDescription.Multiline = true;
            this.tb_PowerDescription.Name = "tb_PowerDescription";
            this.tb_PowerDescription.Size = new System.Drawing.Size(113, 107);
            this.tb_PowerDescription.TabIndex = 5;
            // 
            // PowersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.tb_PowerDescription);
            this.Controls.Add(this.tb_Power);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_Powers);
            this.Name = "PowersForm";
            this.Text = "Powers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Powers;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_Power;
        private System.Windows.Forms.TextBox tb_PowerDescription;
    }
}