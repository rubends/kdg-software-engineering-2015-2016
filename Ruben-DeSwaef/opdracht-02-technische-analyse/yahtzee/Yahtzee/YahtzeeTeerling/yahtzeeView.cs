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
  public partial class yahtzeeView : UserControl
  {
    private yahtzeeController _controller;
    
    public yahtzeeView(yahtzeeController YahtzeeController)
    {
      _controller = YahtzeeController;
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _controller.werpAllen();
    }

    private void yahtzeeView_Load(object sender, EventArgs e)
    {
      List<teerlingView> teerlingen = _controller.getTeerlingenView();
      int teerlingHeight = teerlingen.First().Height;
      int teerlingWidth = teerlingen.First().Width;
      button1.Location = new Point(10, teerlingHeight);
      foreach (teerlingView teerling in teerlingen)
      {
        
        teerlingView huidigeTeerling = teerling;
        int xPos = teerlingen.IndexOf(teerling) * teerlingWidth;
        huidigeTeerling.Location = new Point(xPos, 0);
        Controls.Add(huidigeTeerling);
      }
      button1.Location = new Point(10, teerlingHeight);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

  }
}
