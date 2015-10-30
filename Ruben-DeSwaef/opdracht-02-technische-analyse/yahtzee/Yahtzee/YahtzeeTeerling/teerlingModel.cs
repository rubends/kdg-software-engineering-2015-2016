using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
  public class teerlingModel
  {
    int _aantalOgen;
    public bool _teerlingVast;
    public bool _werpBtnDisplay = true;
    public int aantalOgen
    {
      get
      {
        return _aantalOgen;
      }
      set 
      {
        _aantalOgen = value;
      }
    }
    public bool teerlingVast
    {
      get
      {
        return _teerlingVast;
      }
      set
      {
        _teerlingVast = value;
      }
    }
    public bool WerpBtnDisplay
    {
      get
      {
        return _werpBtnDisplay;
      }
      set
      {
        _werpBtnDisplay = value;
      }
    }

  }
}
