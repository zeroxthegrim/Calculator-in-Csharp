namespace SimpleCalculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.Num7Button = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.Num0Button = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(263, 20);
            this.UserInputText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter an equation and press Enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.Num3Button, 2, 3);
            this.ButtonsPanel.Controls.Add(this.Num2Button, 1, 3);
            this.ButtonsPanel.Controls.Add(this.Num1Button, 0, 3);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Num6Button, 2, 2);
            this.ButtonsPanel.Controls.Add(this.Num5Button, 1, 2);
            this.ButtonsPanel.Controls.Add(this.Num4Button, 0, 2);
            this.ButtonsPanel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Num9Button, 2, 1);
            this.ButtonsPanel.Controls.Add(this.Num8Button, 1, 1);
            this.ButtonsPanel.Controls.Add(this.Num7Button, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DivButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.Num0Button, 1, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 80);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(263, 309);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(59, 55);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(133, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(59, 55);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "DEL";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivButton.Location = new System.Drawing.Point(198, 3);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(62, 55);
            this.DivButton.TabIndex = 3;
            this.DivButton.Text = "÷";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // Num7Button
            // 
            this.Num7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7Button.Location = new System.Drawing.Point(3, 64);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(59, 55);
            this.Num7Button.TabIndex = 4;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            this.Num7Button.Click += new System.EventHandler(this.Num7Button_Click);
            // 
            // Num8Button
            // 
            this.Num8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8Button.Location = new System.Drawing.Point(68, 64);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(59, 55);
            this.Num8Button.TabIndex = 5;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            this.Num8Button.Click += new System.EventHandler(this.Num8Button_Click);
            // 
            // Num9Button
            // 
            this.Num9Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9Button.Location = new System.Drawing.Point(133, 64);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(59, 55);
            this.Num9Button.TabIndex = 6;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.Num9Button_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(198, 64);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(62, 55);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // Num4Button
            // 
            this.Num4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4Button.Location = new System.Drawing.Point(3, 125);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(59, 55);
            this.Num4Button.TabIndex = 8;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            this.Num4Button.Click += new System.EventHandler(this.Num4Button_Click);
            // 
            // Num5Button
            // 
            this.Num5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5Button.Location = new System.Drawing.Point(68, 125);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(59, 55);
            this.Num5Button.TabIndex = 9;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            this.Num5Button.Click += new System.EventHandler(this.Num5Button_Click);
            // 
            // Num6Button
            // 
            this.Num6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6Button.Location = new System.Drawing.Point(133, 125);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(59, 55);
            this.Num6Button.TabIndex = 10;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            this.Num6Button.Click += new System.EventHandler(this.Num6Button_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(198, 125);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(62, 55);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Num1Button
            // 
            this.Num1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1Button.Location = new System.Drawing.Point(3, 186);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(59, 55);
            this.Num1Button.TabIndex = 12;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            this.Num1Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num2Button
            // 
            this.Num2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2Button.Location = new System.Drawing.Point(68, 186);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(59, 55);
            this.Num2Button.TabIndex = 13;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            this.Num2Button.Click += new System.EventHandler(this.Num2Button_Click);
            // 
            // Num3Button
            // 
            this.Num3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3Button.Location = new System.Drawing.Point(133, 186);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(59, 55);
            this.Num3Button.TabIndex = 14;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            this.Num3Button.Click += new System.EventHandler(this.Num3Button_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(198, 186);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(62, 55);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // Num0Button
            // 
            this.Num0Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0Button.Location = new System.Drawing.Point(68, 247);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(59, 59);
            this.Num0Button.TabIndex = 16;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            this.Num0Button.Click += new System.EventHandler(this.Num0Button_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(133, 247);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(59, 59);
            this.DotButton.TabIndex = 17;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(198, 247);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(62, 59);
            this.EqualsButton.TabIndex = 18;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 402);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserInputText);
            this.MaximumSize = new System.Drawing.Size(303, 440);
            this.MinimumSize = new System.Drawing.Size(303, 440);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num7Button;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button EqualsButton;
    }
}

