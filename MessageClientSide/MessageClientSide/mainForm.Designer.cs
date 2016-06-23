namespace MessageClientSide
{
    partial class mainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sendBtt = new System.Windows.Forms.Button();
            this.hibBtt = new System.Windows.Forms.Button();
            this.messageRichBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioCheckBox = new System.Windows.Forms.CheckBox();
            this.mobileCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 39);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(718, 277);
            this.dataGridView.TabIndex = 0;
            // 
            // sendBtt
            // 
            this.sendBtt.Location = new System.Drawing.Point(16, 519);
            this.sendBtt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendBtt.Name = "sendBtt";
            this.sendBtt.Size = new System.Drawing.Size(100, 28);
            this.sendBtt.TabIndex = 1;
            this.sendBtt.Text = "Send";
            this.sendBtt.UseVisualStyleBackColor = true;
            this.sendBtt.Click += new System.EventHandler(this.sendBtt_Click);
            // 
            // hibBtt
            // 
            this.hibBtt.Location = new System.Drawing.Point(124, 519);
            this.hibBtt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hibBtt.Name = "hibBtt";
            this.hibBtt.Size = new System.Drawing.Size(100, 28);
            this.hibBtt.TabIndex = 3;
            this.hibBtt.Text = "HIB";
            this.hibBtt.UseVisualStyleBackColor = true;
            this.hibBtt.Click += new System.EventHandler(this.hibBtt_Click);
            // 
            // messageRichBox
            // 
            this.messageRichBox.Location = new System.Drawing.Point(16, 361);
            this.messageRichBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageRichBox.Name = "messageRichBox";
            this.messageRichBox.Size = new System.Drawing.Size(717, 150);
            this.messageRichBox.TabIndex = 4;
            this.messageRichBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "select multi-persons: Ctrl+click rows";
            // 
            // radioCheckBox
            // 
            this.radioCheckBox.AutoSize = true;
            this.radioCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCheckBox.Location = new System.Drawing.Point(290, 528);
            this.radioCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCheckBox.Name = "radioCheckBox";
            this.radioCheckBox.Size = new System.Drawing.Size(60, 20);
            this.radioCheckBox.TabIndex = 8;
            this.radioCheckBox.Text = "Radio";
            this.radioCheckBox.UseVisualStyleBackColor = true;
            // 
            // mobileCheckBox
            // 
            this.mobileCheckBox.AutoSize = true;
            this.mobileCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileCheckBox.Location = new System.Drawing.Point(377, 528);
            this.mobileCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mobileCheckBox.Name = "mobileCheckBox";
            this.mobileCheckBox.Size = new System.Drawing.Size(65, 20);
            this.mobileCheckBox.TabIndex = 9;
            this.mobileCheckBox.Text = "Mobile";
            this.mobileCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 569);
            this.Controls.Add(this.mobileCheckBox);
            this.Controls.Add(this.radioCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageRichBox);
            this.Controls.Add(this.hibBtt);
            this.Controls.Add(this.sendBtt);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.Text = "Message GUI Client Side";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button sendBtt;
        private System.Windows.Forms.Button hibBtt;
        private System.Windows.Forms.RichTextBox messageRichBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox radioCheckBox;
        private System.Windows.Forms.CheckBox mobileCheckBox;
    }
}

