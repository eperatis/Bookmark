namespace restapi3
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
            this.button_get = new System.Windows.Forms.Button();
            this.button_getid = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_post = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_put = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(47, 28);
            this.button_get.Margin = new System.Windows.Forms.Padding(4);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(451, 28);
            this.button_get.TabIndex = 1;
            this.button_get.Text = "GET";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // button_getid
            // 
            this.button_getid.Location = new System.Drawing.Point(32, 382);
            this.button_getid.Margin = new System.Windows.Forms.Padding(4);
            this.button_getid.Name = "button_getid";
            this.button_getid.Size = new System.Drawing.Size(100, 28);
            this.button_getid.TabIndex = 2;
            this.button_getid.Text = "GET + id";
            this.button_getid.UseVisualStyleBackColor = true;
            this.button_getid.Click += new System.EventHandler(this.button_getid_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 385);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Ide írd az id-t!";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 69);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 292);
            this.listBox1.TabIndex = 4;
            // 
            // button_post
            // 
            this.button_post.Location = new System.Drawing.Point(32, 449);
            this.button_post.Margin = new System.Windows.Forms.Padding(4);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(100, 28);
            this.button_post.TabIndex = 5;
            this.button_post.Text = "POST (ADD)";
            this.button_post.UseVisualStyleBackColor = true;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(397, 383);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 28);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_put
            // 
            this.button_put.Location = new System.Drawing.Point(175, 591);
            this.button_put.Margin = new System.Windows.Forms.Padding(4);
            this.button_put.Name = "button_put";
            this.button_put.Size = new System.Drawing.Size(141, 33);
            this.button_put.TabIndex = 7;
            this.button_put.Text = "Módosít (PUT)";
            this.button_put.UseVisualStyleBackColor = true;
            this.button_put.Click += new System.EventHandler(this.button_put_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 417);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "URL:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(36, 507);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(460, 22);
            this.textBox_name.TabIndex = 11;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(36, 559);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(460, 22);
            this.textBox_url.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 642);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Módosításhoz írd be a módosítandó ID-ját, majd írd be a név szekcióba \r\na nevet é" +
    "s az url-t az url szekcióba.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_put);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_post);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_getid);
            this.Controls.Add(this.button_get);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bookmarker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.Button button_getid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_post;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_put;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label3;
    }
}

