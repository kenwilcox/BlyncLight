using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blynclight;

namespace BlyncN
{
  public class ColorController
  {
    private BlynclightController _con;
    private List<LightColor> _colors;
    private int _deviceCount;
    private int _colorIndex;

    public ColorController()
    {
      _colors = new List<LightColor>();
      _con = new BlynclightController();
      _deviceCount = _con.InitBlyncDevices();
      _colorIndex = -1;
    }

    public int DeviceCount
    {
      get { return _deviceCount; }
    }

    private BlynclightController.Color Map(LightColor color)
    {
      BlynclightController.Color ret;
      switch(color)
      {
        case LightColor.Cyan: ret = BlynclightController.Color.Cyan; break;
        case LightColor.White: ret = BlynclightController.Color.White; break;
        case LightColor.Blue: ret = BlynclightController.Color.Blue; break;
        case LightColor.Yellow: ret = BlynclightController.Color.Yellow; break;
        case LightColor.Green: ret = BlynclightController.Color.Green; break;
        case LightColor.Red: ret = BlynclightController.Color.Red; break;
        case LightColor.Purple: ret = BlynclightController.Color.Purple; break;
        
        default: ret = BlynclightController.Color.Off; break;
      }
      return ret;
    }

    public void Add(LightColor color)
    {
      _colors.Add(color);
      _colorIndex = 0;
    }

    public void Clear()
    {
      _colors.Clear();
      _colorIndex = -1;
    }

    public List<LightColor> Recipe
    {
      get 
      {
        List<LightColor> ret = new List<LightColor>();
        foreach (LightColor color in _colors)
          ret.Add(color);
        return ret;
      }

      set
      {
        _colorIndex = -1;
        _colors = value;
        _colorIndex = 0;
      }
    }

    public void Off()
    {
      if (_con != null) _con.Display(Map(LightColor.Off));
    }

    public void On(LightColor color)
    {
      if (_con != null) _con.Display(Map(color));
    }

    public void SetColor()
    {
      if (_con != null)
      {
        if (_colorIndex > -1)
        {
          _con.Display(Map(_colors[_colorIndex]));
          _colorIndex++;
          if (_colorIndex >= _colors.Count) _colorIndex = 0;
        }
      }
    }
  }
}
