namespace YahtzeeTeerling
{
  partial class teerlingView
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
      this.werpButton = new System.Windows.Forms.Button();
      this.teerlingLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // werpButton
      // 
      this.werpButton.Location = new System.Drawing.Point(36, 140);
      this.werpButton.Name = "werpButton";
      this.werpButton.Size = new System.Drawing.Size(83, 20);
      this.werpButton.TabIndex = 0;
      this.werpButton.Text = "werp";
      this.werpButton.UseVisualStyleBackColor = true;
      this.werpButton.Click += new System.EventHandler(this.werpButton_Click);
      // 
      // teerlingLabel
      // 
      this.teerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teerlingLabel.ForeColor = System.Drawing.Color.Black;
      this.teerlingLabel.Location = new System.Drawing.Point(26, 19);
      this.teerlingLabel.Name = "teerlingLabel";
      this.teerlingLabel.Size = new System.Drawing.Size(105, 102);
      this.teerlingLabel.TabIndex = 1;
      this.teerlingLabel.Text = "waag je kans";
      this.teerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.teerlingLabel.Click += new System.EventHandler(this.teerlingLabel_Click);
      // 
      // teerlingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.teerlingLabel);
      this.Controls.Add(this.werpButton);
      this.Name = "teerlingView";
      this.Size = new System.Drawing.Size(160, 178);
      this.Load += new System.EventHandler(this.teerlingView_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button werpButton;
    private System.Windows.Forms.Label teerlingLabel;
  }
}
