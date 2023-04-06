namespace Lottery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.btnDice = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayısal Loto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(240, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(325, 69);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(168, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Red;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicket.Location = new System.Drawing.Point(193, 199);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(126, 47);
            this.btnTicket.TabIndex = 4;
            this.btnTicket.Text = "Bilet Sat";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Location = new System.Drawing.Point(168, 144);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.ReadOnly = true;
            this.txtTicketNumber.Size = new System.Drawing.Size(287, 20);
            this.txtTicketNumber.TabIndex = 5;
            this.txtTicketNumber.Text = "  ";
            this.txtTicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDice
            // 
            this.btnDice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDice.BackgroundImage")));
            this.btnDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDice.FlatAppearance.BorderSize = 0;
            this.btnDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDice.Location = new System.Drawing.Point(32, 117);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(108, 73);
            this.btnDice.TabIndex = 6;
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(418, 231);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 23);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "Kontrol";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(252, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bilet Numaranız:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SAYISAL LOTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label4;
    }
}

