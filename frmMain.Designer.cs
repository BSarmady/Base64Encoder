namespace Base64 {
    partial class frmMain {
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
            this.edt_base64string = new System.Windows.Forms.TextBox();
            this.edt_plain_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edt_base64string
            // 
            this.edt_base64string.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_base64string.Location = new System.Drawing.Point(9, 30);
            this.edt_base64string.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edt_base64string.Multiline = true;
            this.edt_base64string.Name = "edt_base64string";
            this.edt_base64string.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edt_base64string.Size = new System.Drawing.Size(459, 162);
            this.edt_base64string.TabIndex = 0;
            this.edt_base64string.TextChanged += new System.EventHandler(this.edt_base64string_TextChanged);
            // 
            // edt_plain_text
            // 
            this.edt_plain_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_plain_text.Location = new System.Drawing.Point(8, 232);
            this.edt_plain_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edt_plain_text.Multiline = true;
            this.edt_plain_text.Name = "edt_plain_text";
            this.edt_plain_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edt_plain_text.Size = new System.Drawing.Size(460, 188);
            this.edt_plain_text.TabIndex = 1;
            this.edt_plain_text.TextChanged += new System.EventHandler(this.edt_plain_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base64";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(384, 200);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(83, 24);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "From File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(476, 434);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edt_plain_text);
            this.Controls.Add(this.edt_base64string);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Convert from/to base64 ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_base64string;
        private System.Windows.Forms.TextBox edt_plain_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFile;
    }
}

