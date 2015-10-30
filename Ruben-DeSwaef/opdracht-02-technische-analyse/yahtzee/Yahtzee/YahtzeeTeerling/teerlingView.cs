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
  public partial class teerlingView : UserControl
  {
    teerlingController _controller;
    

    public teerlingView(teerlingController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void teerlingView_Load(object sender, EventArgs e)
    {
      
    }

    public void werpButton_Click(object sender, EventArgs e)
    {
      if (_controller.teerlingVastzetten())
      {
        _controller.werpTeerling();
        this.updateView();
      }
    }

    private void teerlingLabel_Click(object sender, EventArgs e)
    {
      if (_controller.teerlingVastzetten())
      {
        werpButton.Enabled = false;
        this.updateView();
      }
      else
      {
        werpButton.Enabled = true;
        this.updateView();
      }
    }

    public void updateView()
    {
      if (!_controller._model.teerlingVast)
      {
        teerlingLabel.BackColor = Color.Red;
      }
      else
      {
        teerlingLabel.BackColor = Color.White;
      }
      teerlingLabel.Text = _controller._model.aantalOgen.ToString();
      werpButton.Visible = _controller._model.WerpBtnDisplay;
 
    }
  }
}
