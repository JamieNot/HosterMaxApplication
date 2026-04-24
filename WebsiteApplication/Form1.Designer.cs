namespace WebsiteApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            domainname = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 23);
            webView21.Margin = new Padding(3, 0, 3, 3);
            webView21.Name = "webView21";
            webView21.Size = new Size(800, 427);
            webView21.Source = new Uri("https://hostermax.co.uk", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.SourceChanged += webView21_SourceChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(78, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Main Page";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            button2.FlatAppearance.MouseDownBackColor = Color.Lime;
            button2.FlatAppearance.MouseOverBackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(159, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "OverPlan";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Navigate To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(350, 4);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Current URL:";
            // 
            // domainname
            // 
            domainname.AutoSize = true;
            domainname.ForeColor = SystemColors.HighlightText;
            domainname.Location = new Point(421, 4);
            domainname.Name = "domainname";
            domainname.Size = new Size(135, 15);
            domainname.TabIndex = 5;
            domainname.Text = "https://hostermax.co.uk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(267, 4);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Version 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(domainname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(webView21);
            Name = "Form1";
            ShowIcon = false;
            Text = "HosterMax integrated app";
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label domainname;
        private Label label3;
    }
}
