namespace QueueWindowsFormsApplication
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
            this.QueueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateQueueBtn = new System.Windows.Forms.Button();
            this.SortByAge = new System.Windows.Forms.Button();
            this.SortByName = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ClearQueueTextBox = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetUserFromQueue = new System.Windows.Forms.Button();
            this.PrintQueue = new System.Windows.Forms.Button();
            this.ClearQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QueueTextBox
            // 
            this.QueueTextBox.Location = new System.Drawing.Point(237, 64);
            this.QueueTextBox.Multiline = true;
            this.QueueTextBox.Name = "QueueTextBox";
            this.QueueTextBox.ReadOnly = true;
            this.QueueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QueueTextBox.Size = new System.Drawing.Size(304, 297);
            this.QueueTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queue";
            // 
            // CreateQueueBtn
            // 
            this.CreateQueueBtn.Location = new System.Drawing.Point(22, 64);
            this.CreateQueueBtn.Name = "CreateQueueBtn";
            this.CreateQueueBtn.Size = new System.Drawing.Size(159, 23);
            this.CreateQueueBtn.TabIndex = 2;
            this.CreateQueueBtn.Text = "Create Queue";
            this.CreateQueueBtn.UseVisualStyleBackColor = true;
            this.CreateQueueBtn.Click += new System.EventHandler(this.CreateQueueBtn_Click);
            // 
            // SortByAge
            // 
            this.SortByAge.Location = new System.Drawing.Point(22, 93);
            this.SortByAge.Name = "SortByAge";
            this.SortByAge.Size = new System.Drawing.Size(159, 23);
            this.SortByAge.TabIndex = 3;
            this.SortByAge.Text = "Sort by user age";
            this.SortByAge.UseVisualStyleBackColor = true;
            this.SortByAge.Click += new System.EventHandler(this.SortByAge_Click);
            // 
            // SortByName
            // 
            this.SortByName.Location = new System.Drawing.Point(22, 122);
            this.SortByName.Name = "SortByName";
            this.SortByName.Size = new System.Drawing.Size(159, 23);
            this.SortByName.TabIndex = 4;
            this.SortByName.Text = "Sort by user name";
            this.SortByName.UseVisualStyleBackColor = true;
            this.SortByName.Click += new System.EventHandler(this.SortByName_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add user to queue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // ClearQueueTextBox
            // 
            this.ClearQueueTextBox.Location = new System.Drawing.Point(237, 367);
            this.ClearQueueTextBox.Name = "ClearQueueTextBox";
            this.ClearQueueTextBox.Size = new System.Drawing.Size(304, 23);
            this.ClearQueueTextBox.TabIndex = 6;
            this.ClearQueueTextBox.Text = "Clear output";
            this.ClearQueueTextBox.UseVisualStyleBackColor = true;
            this.ClearQueueTextBox.Click += new System.EventHandler(this.ClearQueueTextBox_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(22, 296);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(159, 20);
            this.UserName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name";
            // 
            // UserAge
            // 
            this.UserAge.Location = new System.Drawing.Point(22, 341);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(159, 20);
            this.UserAge.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Age";
            // 
            // GetUserFromQueue
            // 
            this.GetUserFromQueue.Location = new System.Drawing.Point(22, 151);
            this.GetUserFromQueue.Name = "GetUserFromQueue";
            this.GetUserFromQueue.Size = new System.Drawing.Size(159, 23);
            this.GetUserFromQueue.TabIndex = 11;
            this.GetUserFromQueue.Text = "Get user from queue";
            this.GetUserFromQueue.UseVisualStyleBackColor = true;
            this.GetUserFromQueue.Click += new System.EventHandler(this.GetUserFromQueue_Click);
            // 
            // PrintQueue
            // 
            this.PrintQueue.Location = new System.Drawing.Point(25, 210);
            this.PrintQueue.Name = "PrintQueue";
            this.PrintQueue.Size = new System.Drawing.Size(156, 23);
            this.PrintQueue.TabIndex = 12;
            this.PrintQueue.Text = "Print";
            this.PrintQueue.UseVisualStyleBackColor = true;
            this.PrintQueue.Click += new System.EventHandler(this.PrintQueue_Click);
            // 
            // ClearQueue
            // 
            this.ClearQueue.Location = new System.Drawing.Point(25, 181);
            this.ClearQueue.Name = "ClearQueue";
            this.ClearQueue.Size = new System.Drawing.Size(156, 23);
            this.ClearQueue.TabIndex = 13;
            this.ClearQueue.Text = "Clear";
            this.ClearQueue.UseVisualStyleBackColor = true;
            this.ClearQueue.Click += new System.EventHandler(this.ClearQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 459);
            this.Controls.Add(this.ClearQueue);
            this.Controls.Add(this.PrintQueue);
            this.Controls.Add(this.GetUserFromQueue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ClearQueueTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SortByName);
            this.Controls.Add(this.SortByAge);
            this.Controls.Add(this.CreateQueueBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateQueueBtn;
        private System.Windows.Forms.Button SortByAge;
        private System.Windows.Forms.Button SortByName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ClearQueueTextBox;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetUserFromQueue;
        private System.Windows.Forms.Button PrintQueue;
        private System.Windows.Forms.Button ClearQueue;
    }
}

