using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class teerlingController
  {
    teerlingView _view;

    private GameController gameCont;
    public teerlingModel _model;
    static Random random = new Random();

    public teerlingController(GameController game)
    {
      _view = new teerlingView(this);
      _model = new teerlingModel();
      gameCont = game;
      _model.teerlingVast = true; // true => teerling kan gegooid worden


    }
    public teerlingView getView()
    {
      return _view;
    }
    
    public void werpTeerling()
    {
      if(_model.teerlingVast)
      {  
        int teerlingGetal = random.Next(1, 7);
        _model.aantalOgen = teerlingGetal;
        _view.updateView();
        Console.WriteLine("Teerling");
      }

    }
    public int aantalOgen
    {
      get
      {
        return _model.aantalOgen;
      }
    }
    public bool teerlingVastzetten()
    {
      if(_model.teerlingVast)
      {
        return _model.teerlingVast = false;
      }
      else
      {
        return _model.teerlingVast = true;
      }
    }

    public void WerpBtnHide()
    {
      _model.WerpBtnDisplay = false;
      _view.updateView(); //anders verdwijne de knoppe pas na de werpallenknop
    }
  }
}
