using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
  public partial class GameView : Form
  {
    GameController _controller;
    public GameView(GameController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void GameView_Load(object sender, EventArgs e)
    {
      
      yahtzeeView yahtzee = _controller.getYahtzeeView();
      scorebordView scoreboard = _controller.getScoreView();
      yahtzee.Location = new Point(0, scoreboard.Height);
      Controls.Add(scoreboard);
      Controls.Add(yahtzee);
    }
  }
}
