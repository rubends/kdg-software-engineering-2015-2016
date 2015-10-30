namespace YahtzeeTeerling
{
  partial class scorebordView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.scorelbl = new System.Windows.Forms.Label();
      this.worplbl = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.highlbl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // scorelbl
      // 
      this.scorelbl.AutoSize = true;
      this.scorelbl.Location = new System.Drawing.Point(101, 27);
      this.scorelbl.Name = "scorelbl";
      this.scorelbl.Size = new System.Drawing.Size(13, 13);
      this.scorelbl.TabIndex = 11;
      this.scorelbl.Text = "0";
      // 
      // worplbl
      // 
      this.worplbl.AutoSize = true;
      this.worplbl.Location = new System.Drawing.Point(90, 9);
      this.worplbl.Name = "worplbl";
      this.worplbl.Size = new System.Drawing.Size(24, 13);
      this.worplbl.TabIndex = 10;
      this.worplbl.Text = "0/5";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "score:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "huidige worp:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 48);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Highscore:";
      // 
      // highlbl
      // 
      this.highlbl.AutoSize = true;
      this.highlbl.Location = new System.Drawing.Point(101, 48);
      this.highlbl.Name = "highlbl";
      this.highlbl.Size = new System.Drawing.Size(13, 13);
      this.highlbl.TabIndex = 13;
      this.highlbl.Text = "0";
      // 
      // scorebordView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.highlbl);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.scorelbl);
      this.Controls.Add(this.worplbl);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "scorebordView";
      this.Size = new System.Drawing.Size(133, 67);
      this.Load += new System.EventHandler(this.scorebordView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label scorelbl;
    private System.Windows.Forms.Label worplbl;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label highlbl;
  }
}
