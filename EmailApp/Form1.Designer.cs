namespace EmailApp
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
            this.tb_From = new System.Windows.Forms.TextBox();
            this.tb_To = new System.Windows.Forms.TextBox();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tb_From
            // 
            this.tb_From.Location = new System.Drawing.Point(68, 40);
            this.tb_From.Name = "tb_From";
            this.tb_From.ReadOnly = true;
            this.tb_From.Size = new System.Drawing.Size(368, 20);
            this.tb_From.TabIndex = 0;
            this.tb_From.TabStop = false;
            // 
            // tb_To
            // 
            this.tb_To.Location = new System.Drawing.Point(68, 76);
            this.tb_To.Name = "tb_To";
            this.tb_To.Size = new System.Drawing.Size(368, 20);
            this.tb_To.TabIndex = 1;
            this.tb_To.TextChanged += new System.EventHandler(this.tb_To_TextChanged);
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(68, 113);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(538, 20);
            this.tb_Title.TabIndex = 2;
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(68, 149);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(538, 215);
            this.tb_Message.TabIndex = 3;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(29, 43);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(33, 13);
            this.lbl_From.TabIndex = 4;
            this.lbl_From.Text = "From:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(29, 79);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(23, 13);
            this.lbl_To.TabIndex = 5;
            this.lbl_To.Text = "To:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(29, 116);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // btn_Attach
            // 
            this.btn_Attach.Location = new System.Drawing.Point(68, 408);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(75, 23);
            this.btn_Attach.TabIndex = 8;
            this.btn_Attach.Text = "Attach file...";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(530, 408);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(170, 413);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(0, 13);
            this.lbl_FileName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Attach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.tb_To);
            this.Controls.Add(this.tb_From);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_From;
        private System.Windows.Forms.TextBox tb_To;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Attach;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

