using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blynclight;

namespace BlinkNotes
{
  public class BlinkNote : BlinkNoteBase
  {
    private ColorNote _note;
    private int _tone;
    private int _duration;

    public BlinkNote(ColorNote note, int toneFreq, int duration)
    {
      _note = note;
      _tone = toneFreq;
      _duration = duration;
    }

    public void Play()
    {
      base.Play(_note, _tone, _duration);
    }
  }
}
