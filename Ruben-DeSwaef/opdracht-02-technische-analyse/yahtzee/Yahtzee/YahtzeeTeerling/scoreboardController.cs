using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class scoreboardController
  {
    public scoreboardModel _model;
    public scorebordView _view;
    public GameController gameCont;

    public scoreboardController(GameController game)
    {
      _model = new scoreboardModel(this);
      _view = new scorebordView(this);

      gameCont = game;
    }

    public int telWorp
    {
      get
        {
           return gameCont.HuidigAantalWorpen;
        }
    }
    public int Score
    {
      get
      {
        return gameCont.HuidigScore;
      }
    }
    public int HighScore
    {
      get
      {
        return gameCont.getHighScore;
      }
    }
    public scorebordView getView()
    {
      return _view;

    }
    public void updateView()
    {
      _view.updateView();
    }
  }
}
