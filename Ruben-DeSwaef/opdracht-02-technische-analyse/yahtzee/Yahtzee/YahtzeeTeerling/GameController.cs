using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class GameController
  {

    private yahtzeeController yahtzeeCont;
    private scoreboardController scoreCont;
    private teerlingController teerlingCont;
    GameView _view;

    public GameController()
    {
      _view = new GameView(this);
      yahtzeeCont = new yahtzeeController(this);
      yahtzeeCont.initialize();
      scoreCont = new scoreboardController(this);
      teerlingCont = new teerlingController(this);
    }

    public yahtzeeView getYahtzeeView()
    {
      return yahtzeeCont.getView();
    }
    public scorebordView getScoreView()
    {
      return scoreCont.getView();
    }

    public GameView getView()
    {
      return _view;
    }

    public int HuidigAantalWorpen
    {
      get
      {
        return yahtzeeCont.aantalWorp;
      }
    }

    public int HuidigScore
    {
      get
      {
        return yahtzeeCont.giveScore;
      }
    }
    public int getHighScore
    {
      get
      {
        return yahtzeeCont.giveHighScore;
      }
    }

    public void scoreChange()
    {
      scoreCont.updateView();
    }
    
  }
}
