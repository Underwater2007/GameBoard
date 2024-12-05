
namespace GameBoard
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRoll100Dice = new System.Windows.Forms.Button();
            this.btnRoll1 = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.IndianRed;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(271, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(258, 80);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRoll100Dice
            // 
            this.btnRoll100Dice.BackColor = System.Drawing.Color.IndianRed;
            this.btnRoll100Dice.Location = new System.Drawing.Point(336, 174);
            this.btnRoll100Dice.Name = "btnRoll100Dice";
            this.btnRoll100Dice.Size = new System.Drawing.Size(128, 51);
            this.btnRoll100Dice.TabIndex = 1;
            this.btnRoll100Dice.Text = "R&oll 100 dice";
            this.btnRoll100Dice.UseVisualStyleBackColor = false;
            this.btnRoll100Dice.Visible = false;
            this.btnRoll100Dice.Click += new System.EventHandler(this.btnRoll100Dice_Click);
            // 
            // btnRoll1
            // 
            this.btnRoll1.BackColor = System.Drawing.Color.IndianRed;
            this.btnRoll1.Location = new System.Drawing.Point(336, 108);
            this.btnRoll1.Name = "btnRoll1";
            this.btnRoll1.Size = new System.Drawing.Size(128, 51);
            this.btnRoll1.TabIndex = 2;
            this.btnRoll1.Tag = "";
            this.btnRoll1.Text = "&Roll 1 dice";
            this.btnRoll1.UseVisualStyleBackColor = false;
            this.btnRoll1.Visible = false;
            this.btnRoll1.Click += new System.EventHandler(this.btnRoll1_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(305, 239);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(0, 17);
            this.lblPrompt.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(225, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(351, 84);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "In this board game if you land on a yellow block you move back 2 spaces and if yo" +
    "u land on a red block you move back to the start ";
            // 
            // GameBoard
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnRoll1);
            this.Controls.Add(this.btnRoll100Dice);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.Text = "Game Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRoll100Dice;
        private System.Windows.Forms.Button btnRoll1;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblInfo;
    }
}

