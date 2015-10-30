using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class yahtzeeController
  {
    private yahtzeeModel _model;
    private yahtzeeView _view;
    private GameController gameCont;

    public yahtzeeController(GameController game)
    {
      _model = new yahtzeeModel();
      _view = new yahtzeeView(this);

      gameCont = game;
    }

    public void initialize()
    {
      creaTling();
    }

    private void creaTling()
    {
      for (int teerlingNummer = 0; teerlingNummer < _model.AantalTeerlingen; ++teerlingNummer)
      {
        teerlingController teerling = new teerlingController(gameCont);
        teerling.WerpBtnHide();

        _model.addTeerling(teerling);
      }
    }

    public void werpAllen()
    {
      _model.getScore = 0;
      if (_model.aantalWorpen < _model.MaxWorpen)
      {
        List<teerlingController> teerlingen = _model.Teerlingen;
        foreach (teerlingController teerling in teerlingen)
        {
          teerling.werpTeerling();
          _model.telScore(teerling.aantalOgen);
        }
        _model.telWorp();
        _model.fixHighScore();
        gameCont.scoreChange();
      }
    }
    public List<teerlingView> getTeerlingenView()
    {
      List<teerlingView> teerlingenView = new List<teerlingView>();
      foreach (teerlingController teerling in _model.Teerlingen)
      {
        teerlingView teerlingView = teerling.getView();
        teerlingenView.Add(teerlingView);
      }
      
      return teerlingenView;
    }
    public yahtzeeView getView()
    {
      return _view;
    }

    public int aantalWorp
    {
      get
      {
        return _model.aantalWorpen;
      }
    }
    public int giveScore
    {
      get
      {
        return _model.getScore;
      }
    }
    public int giveHighScore
    {
      get
      {
        return _model.HighScore;
      }
    }

  }
}
