namespace CatchButton
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
            running_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // running_button
            // 
            running_button.BackColor = Color.Yellow;
            running_button.Font = new Font("휴먼엑스포", 20F);
            running_button.ForeColor = Color.FromArgb(192, 64, 0);
            running_button.Location = new Point(260, 141);
            running_button.Name = "running_button";
            running_button.Size = new Size(300, 150);
            running_button.TabIndex = 0;
            running_button.Text = "나를 잡아봐";
            running_button.UseVisualStyleBackColor = false;
            running_button.Click += running_button_Click;
            running_button.MouseEnter += running_button_MouseEnter;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 50F);
            button1.Location = new Point(81, 61);
            button1.Name = "button1";
            button1.Size = new Size(691, 317);
            button1.TabIndex = 1;
            button1.Text = "다시시작";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(882, 453);
            Controls.Add(running_button);
            Controls.Add(button1);
            Name = "Form1";
            Text = "버튼 잡기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button running_button;
        private Button button1;
    }
}
