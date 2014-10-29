using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Blynclight;

namespace BlinkNotes
{
  public class BlinkNoteBase
  {
    private static BlynclightController _con;

    public BlinkNoteBase()
    {
      if (_con == null)
      {
        _con = new BlynclightController();
        _con.InitBlyncDevices();
      }
    }

    public void Play(ColorNote note, int toneFreq, int durationInMS)
    {
      _con.Display(note.ToColor());
      if (toneFreq != 0)
        Console.Beep(toneFreq, durationInMS);
      else
        Thread.Sleep(durationInMS);
      _con.Display(BlynclightController.Color.Off);
      Thread.Sleep(10); // so we can actually see the off state...
    }
  }
}
