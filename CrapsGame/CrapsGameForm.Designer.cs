namespace CrapsGame
{
    partial class CrapsGameMain
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
            this.exitButton = new System.Windows.Forms.Button();
            this.bankbalanceLabel = new System.Windows.Forms.Label();
            this.rolldiceButton = new System.Windows.Forms.Button();
            this.messageTextbox = new System.Windows.Forms.TextBox();
            this.wagerLabel = new System.Windows.Forms.Label();
            this.bankbalanceTextbox = new System.Windows.Forms.TextBox();
            this.wagerTextbox = new System.Windows.Forms.TextBox();
            this.gameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(742, 817);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(196, 68);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // bankbalanceLabel
            // 
            this.bankbalanceLabel.AutoSize = true;
            this.bankbalanceLabel.Location = new System.Drawing.Point(717, 20);
            this.bankbalanceLabel.Name = "bankbalanceLabel";
            this.bankbalanceLabel.Size = new System.Drawing.Size(161, 32);
            this.bankbalanceLabel.TabIndex = 1;
            this.bankbalanceLabel.Text = "Bank Balance:";
            // 
            // rolldiceButton
            // 
            this.rolldiceButton.Location = new System.Drawing.Point(14, 654);
            this.rolldiceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rolldiceButton.Name = "rolldiceButton";
            this.rolldiceButton.Size = new System.Drawing.Size(157, 64);
            this.rolldiceButton.TabIndex = 2;
            this.rolldiceButton.Text = "Roll Dice";
            this.rolldiceButton.UseVisualStyleBackColor = true;
            // 
            // messageTextbox
            // 
            this.messageTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageTextbox.Location = new System.Drawing.Point(12, 726);
            this.messageTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageTextbox.Multiline = true;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.ReadOnly = true;
            this.messageTextbox.Size = new System.Drawing.Size(682, 159);
            this.messageTextbox.TabIndex = 3;
            // 
            // wagerLabel
            // 
            this.wagerLabel.AutoSize = true;
            this.wagerLabel.Location = new System.Drawing.Point(717, 126);
            this.wagerLabel.Name = "wagerLabel";
            this.wagerLabel.Size = new System.Drawing.Size(88, 32);
            this.wagerLabel.TabIndex = 4;
            this.wagerLabel.Text = "Wager:";
            // 
            // bankbalanceTextbox
            // 
            this.bankbalanceTextbox.Location = new System.Drawing.Point(723, 56);
            this.bankbalanceTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bankbalanceTextbox.Name = "bankbalanceTextbox";
            this.bankbalanceTextbox.ReadOnly = true;
            this.bankbalanceTextbox.Size = new System.Drawing.Size(158, 39);
            this.bankbalanceTextbox.TabIndex = 5;
            // 
            // wagerTextbox
            // 
            this.wagerTextbox.Location = new System.Drawing.Point(720, 162);
            this.wagerTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wagerTextbox.Name = "wagerTextbox";
            this.wagerTextbox.Size = new System.Drawing.Size(158, 39);
            this.wagerTextbox.TabIndex = 6;
            // 
            // gameTextbox
            // 
            this.gameTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameTextbox.Location = new System.Drawing.Point(14, 17);
            this.gameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameTextbox.Multiline = true;
            this.gameTextbox.Name = "gameTextbox";
            this.gameTextbox.ReadOnly = true;
            this.gameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameTextbox.Size = new System.Drawing.Size(682, 629);
            this.gameTextbox.TabIndex = 7;
            // 
            // CrapsGameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 900);
            this.Controls.Add(this.gameTextbox);
            this.Controls.Add(this.wagerTextbox);
            this.Controls.Add(this.bankbalanceTextbox);
            this.Controls.Add(this.wagerLabel);
            this.Controls.Add(this.messageTextbox);
            this.Controls.Add(this.rolldiceButton);
            this.Controls.Add(this.bankbalanceLabel);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrapsGameMain";
            this.Text = "CrapsGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label bankbalanceLabel;
        private System.Windows.Forms.Button rolldiceButton;
        private System.Windows.Forms.TextBox messageTextbox;
        private System.Windows.Forms.Label wagerLabel;
        private System.Windows.Forms.TextBox bankbalanceTextbox;
        private System.Windows.Forms.TextBox wagerTextbox;
        private System.Windows.Forms.TextBox gameTextbox;
    }
}

