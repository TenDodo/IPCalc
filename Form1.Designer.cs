
namespace IPCalc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NetworkLabel = new System.Windows.Forms.Label();
            this.NetworkBinLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BroadcastLabel = new System.Windows.Forms.Label();
            this.BroadcastBinLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HostMinLabel = new System.Windows.Forms.Label();
            this.HostMaxLabel = new System.Windows.Forms.Label();
            this.HostMinBinLabel = new System.Windows.Forms.Label();
            this.HostMaxBinLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HostsAmountLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPAddressTextBox.Location = new System.Drawing.Point(86, 12);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(120, 21);
            this.IPAddressTextBox.TabIndex = 0;
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaskTextBox.Location = new System.Drawing.Point(86, 39);
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(120, 21);
            this.MaskTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Netmask:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(212, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(284, 48);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Network:";
            // 
            // NetworkLabel
            // 
            this.NetworkLabel.AutoSize = true;
            this.NetworkLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NetworkLabel.Location = new System.Drawing.Point(104, 80);
            this.NetworkLabel.Name = "NetworkLabel";
            this.NetworkLabel.Size = new System.Drawing.Size(49, 14);
            this.NetworkLabel.TabIndex = 6;
            this.NetworkLabel.Text = "label4";
            // 
            // NetworkBinLabel
            // 
            this.NetworkBinLabel.AutoSize = true;
            this.NetworkBinLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NetworkBinLabel.Location = new System.Drawing.Point(223, 80);
            this.NetworkBinLabel.Name = "NetworkBinLabel";
            this.NetworkBinLabel.Size = new System.Drawing.Size(49, 14);
            this.NetworkBinLabel.TabIndex = 7;
            this.NetworkBinLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Class:";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassLabel.Location = new System.Drawing.Point(104, 124);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(49, 14);
            this.ClassLabel.TabIndex = 9;
            this.ClassLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broadcast:";
            // 
            // BroadcastLabel
            // 
            this.BroadcastLabel.AutoSize = true;
            this.BroadcastLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BroadcastLabel.Location = new System.Drawing.Point(104, 102);
            this.BroadcastLabel.Name = "BroadcastLabel";
            this.BroadcastLabel.Size = new System.Drawing.Size(49, 14);
            this.BroadcastLabel.TabIndex = 11;
            this.BroadcastLabel.Text = "label4";
            // 
            // BroadcastBinLabel
            // 
            this.BroadcastBinLabel.AutoSize = true;
            this.BroadcastBinLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BroadcastBinLabel.Location = new System.Drawing.Point(223, 102);
            this.BroadcastBinLabel.Name = "BroadcastBinLabel";
            this.BroadcastBinLabel.Size = new System.Drawing.Size(49, 14);
            this.BroadcastBinLabel.TabIndex = 12;
            this.BroadcastBinLabel.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Host Min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Host Max:";
            // 
            // HostMinLabel
            // 
            this.HostMinLabel.AutoSize = true;
            this.HostMinLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HostMinLabel.Location = new System.Drawing.Point(104, 146);
            this.HostMinLabel.Name = "HostMinLabel";
            this.HostMinLabel.Size = new System.Drawing.Size(49, 14);
            this.HostMinLabel.TabIndex = 15;
            this.HostMinLabel.Text = "label4";
            // 
            // HostMaxLabel
            // 
            this.HostMaxLabel.AutoSize = true;
            this.HostMaxLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HostMaxLabel.Location = new System.Drawing.Point(104, 168);
            this.HostMaxLabel.Name = "HostMaxLabel";
            this.HostMaxLabel.Size = new System.Drawing.Size(49, 14);
            this.HostMaxLabel.TabIndex = 16;
            this.HostMaxLabel.Text = "label4";
            // 
            // HostMinBinLabel
            // 
            this.HostMinBinLabel.AutoSize = true;
            this.HostMinBinLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HostMinBinLabel.Location = new System.Drawing.Point(223, 146);
            this.HostMinBinLabel.Name = "HostMinBinLabel";
            this.HostMinBinLabel.Size = new System.Drawing.Size(49, 14);
            this.HostMinBinLabel.TabIndex = 17;
            this.HostMinBinLabel.Text = "label4";
            // 
            // HostMaxBinLabel
            // 
            this.HostMaxBinLabel.AutoSize = true;
            this.HostMaxBinLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HostMaxBinLabel.Location = new System.Drawing.Point(223, 168);
            this.HostMaxBinLabel.Name = "HostMaxBinLabel";
            this.HostMaxBinLabel.Size = new System.Drawing.Size(49, 14);
            this.HostMaxBinLabel.TabIndex = 18;
            this.HostMaxBinLabel.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hosts Amount:";
            // 
            // HostsAmountLabel
            // 
            this.HostsAmountLabel.AutoSize = true;
            this.HostsAmountLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HostsAmountLabel.Location = new System.Drawing.Point(104, 190);
            this.HostsAmountLabel.Name = "HostsAmountLabel";
            this.HostsAmountLabel.Size = new System.Drawing.Size(49, 14);
            this.HostsAmountLabel.TabIndex = 20;
            this.HostsAmountLabel.Text = "label4";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoEllipsis = true;
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoteLabel.Location = new System.Drawing.Point(12, 210);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(36, 15);
            this.NoteLabel.TabIndex = 21;
            this.NoteLabel.Text = "Note:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 280);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.HostsAmountLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HostMaxBinLabel);
            this.Controls.Add(this.HostMinBinLabel);
            this.Controls.Add(this.HostMaxLabel);
            this.Controls.Add(this.HostMinLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BroadcastBinLabel);
            this.Controls.Add(this.BroadcastLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetworkBinLabel);
            this.Controls.Add(this.NetworkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.IPAddressTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NetworkLabel;
        private System.Windows.Forms.Label NetworkBinLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BroadcastLabel;
        private System.Windows.Forms.Label BroadcastBinLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HostMinLabel;
        private System.Windows.Forms.Label HostMaxLabel;
        private System.Windows.Forms.Label HostMinBinLabel;
        private System.Windows.Forms.Label HostMaxBinLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label HostsAmountLabel;
        private System.Windows.Forms.Label NoteLabel;
    }
}

