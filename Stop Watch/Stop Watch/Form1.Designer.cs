
namespace Stop_Watch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.starttext = new System.Windows.Forms.TextBox();
            this.endtext = new System.Windows.Forms.TextBox();
            this.endbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.elapsedtime = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timenow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time";
            // 
            // startbtn
            // 
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(136, 75);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(110, 39);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // starttext
            // 
            this.starttext.Location = new System.Drawing.Point(535, 87);
            this.starttext.Name = "starttext";
            this.starttext.Size = new System.Drawing.Size(134, 22);
            this.starttext.TabIndex = 2;
            // 
            // endtext
            // 
            this.endtext.Location = new System.Drawing.Point(535, 164);
            this.endtext.Name = "endtext";
            this.endtext.Size = new System.Drawing.Size(134, 22);
            this.endtext.TabIndex = 5;
            // 
            // endbtn
            // 
            this.endbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endbtn.Location = new System.Drawing.Point(136, 152);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(110, 39);
            this.endbtn.TabIndex = 4;
            this.endbtn.Text = "End";
            this.endbtn.UseVisualStyleBackColor = true;
            this.endbtn.Click += new System.EventHandler(this.endbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time";
            // 
            // elapsedtime
            // 
            this.elapsedtime.Location = new System.Drawing.Point(535, 237);
            this.elapsedtime.Name = "elapsedtime";
            this.elapsedtime.Size = new System.Drawing.Size(134, 22);
            this.elapsedtime.TabIndex = 8;
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(136, 225);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(110, 39);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elaspse in Seconds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timenow
            // 
            this.timenow.AutoSize = true;
            this.timenow.Location = new System.Drawing.Point(348, 370);
            this.timenow.Name = "timenow";
            this.timenow.Size = new System.Drawing.Size(0, 17);
            this.timenow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timenow);
            this.Controls.Add(this.elapsedtime);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endtext);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.starttext);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stop Watch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.TextBox starttext;
        private System.Windows.Forms.TextBox endtext;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox elapsedtime;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timenow;
    }
}

