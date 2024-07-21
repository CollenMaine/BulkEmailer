namespace Emailer
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
            this.btnLoadEmails = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnViewEmails = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Label();
            this.isHTML = new System.Windows.Forms.CheckBox();
            this.btnClearEmails = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadEmails
            // 
            this.btnLoadEmails.Location = new System.Drawing.Point(12, 21);
            this.btnLoadEmails.Name = "btnLoadEmails";
            this.btnLoadEmails.Size = new System.Drawing.Size(159, 28);
            this.btnLoadEmails.TabIndex = 0;
            this.btnLoadEmails.Text = "Load Emails";
            this.btnLoadEmails.UseVisualStyleBackColor = true;
            this.btnLoadEmails.Click += new System.EventHandler(this.btnLoadEmails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(758, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(630, 495);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 40);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send Emails";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnViewEmails
            // 
            this.btnViewEmails.Location = new System.Drawing.Point(210, 21);
            this.btnViewEmails.Name = "btnViewEmails";
            this.btnViewEmails.Size = new System.Drawing.Size(159, 28);
            this.btnViewEmails.TabIndex = 4;
            this.btnViewEmails.Text = "View emails";
            this.btnViewEmails.UseVisualStyleBackColor = true;
            this.btnViewEmails.Click += new System.EventHandler(this.btnViewEmails_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(12, 138);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(857, 351);
            this.txtBody.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(12, 84);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(857, 20);
            this.txtSubject.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Body";
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(12, 68);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(43, 13);
            this.Body.TabIndex = 8;
            this.Body.Text = "Subject";
            // 
            // isHTML
            // 
            this.isHTML.AutoSize = true;
            this.isHTML.Location = new System.Drawing.Point(15, 508);
            this.isHTML.Name = "isHTML";
            this.isHTML.Size = new System.Drawing.Size(64, 17);
            this.isHTML.TabIndex = 9;
            this.isHTML.Text = "IsHTML";
            this.isHTML.UseVisualStyleBackColor = true;
            // 
            // btnClearEmails
            // 
            this.btnClearEmails.Location = new System.Drawing.Point(408, 21);
            this.btnClearEmails.Name = "btnClearEmails";
            this.btnClearEmails.Size = new System.Drawing.Size(124, 28);
            this.btnClearEmails.TabIndex = 10;
            this.btnClearEmails.Text = "Clear Emails";
            this.btnClearEmails.UseVisualStyleBackColor = true;
            this.btnClearEmails.Click += new System.EventHandler(this.btnClearEmails_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(115, 504);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(110, 23);
            this.btnAttach.TabIndex = 11;
            this.btnAttach.Text = "Attach File";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 547);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnClearEmails);
            this.Controls.Add(this.isHTML);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnViewEmails);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoadEmails);
            this.Name = "Form1";
            this.Text = "Emailer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadEmails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnViewEmails;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.CheckBox isHTML;
        private System.Windows.Forms.Button btnClearEmails;
        private System.Windows.Forms.Button btnAttach;
    }
}

