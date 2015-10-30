using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  class yahtzeeModel
  {
    private List<teerlingController> teerlingen = new List<teerlingController>();
    private int aantalTeerlingen = 3;
    private int _maxWorpen = 3;
    private int _counter = 0;
    private int _score = 0;
    private int _highScore = 0;
    public List<teerlingController> Teerlingen
    {
      get
      {
        return teerlingen;
      }
    }
    public int AantalTeerlingen
    {
      get
      {
        return aantalTeerlingen;
      }
      set
      {
        aantalTeerlingen = value;
      }
    }
    public int MaxWorpen
    {
      get
      {
        return _maxWorpen;
      }
      set
      {
        _maxWorpen = value;
      }
    }
    internal void addTeerling(teerlingController teerling)
    {
      teerlingen.Add(teerling);
    }
    public int aantalWorpen
    {
      get
      {
        return _counter;
      }
      set
      {
        _counter = value;
      }
    }
    public int telWorp()
    {
      return _counter++;
    }
    
    public int getScore
    {
      get
      {
        return _score;
      }
      set
      {
        _score = value;
      }
    }
    public int HighScore
    {
      get
      {
        return _highScore;
      }
      set
      {
        _highScore = value;
      }
    }
    public int telScore(int ogen)
    {
      _score = _score + ogen;
      return _score;
    }
    public int fixHighScore()
    {
      if(_score > _highScore)
      {
        _highScore = _score;
      }
      return _highScore;
    }

  }
}
