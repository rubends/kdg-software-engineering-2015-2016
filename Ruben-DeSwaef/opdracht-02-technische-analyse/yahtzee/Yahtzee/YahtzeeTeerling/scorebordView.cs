using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
  public partial class scorebordView : UserControl
  {
    private scoreboardController _controller;
    public scorebordView(scoreboardController contr)
    {
      _controller = contr;
      InitializeComponent();
    }

    public void updateView()
    {

      worplbl.Text = _controller.telWorp.ToString() + "/3";
      scorelbl.Text = _controller.Score.ToString();
      highlbl.Text = _controller.HighScore.ToString();
    }

    private void scorebordView_Load(object sender, EventArgs e)
    {
      
    }
  }
}
