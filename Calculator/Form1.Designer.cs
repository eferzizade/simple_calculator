namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nb1 = new MaskedTextBox();
            nb2 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            operation = new ComboBox();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // nb1
            // 
            nb1.Location = new Point(16, 51);
            nb1.Name = "nb1";
            nb1.Size = new Size(242, 23);
            nb1.TabIndex = 0;
            nb1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // nb2
            // 
            nb2.Location = new Point(16, 122);
            nb2.Name = "nb2";
            nb2.Size = new Size(242, 23);
            nb2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Number one";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 104);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Number two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 326);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "History";
            // 
            // operation
            // 
            operation.FormattingEnabled = true;
            operation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operation.Location = new Point(16, 186);
            operation.Name = "operation";
            operation.Size = new Size(242, 23);
            operation.TabIndex = 5;
            operation.Text = "Operations";
            // 
            // button1
            // 
            button1.Location = new Point(16, 257);
            button1.Name = "button1";
            button1.Size = new Size(242, 34);
            button1.TabIndex = 6;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 344);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(242, 94);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(270, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(operation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nb2);
            Controls.Add(nb1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox nb1;
        private MaskedTextBox nb2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox operation;
        private Button button1;
        private ListBox listBox1;
    }
}
