using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blynclight;

namespace BlinkNotes
{
  public enum ColorNote
  {
    A = BlynclightController.Color.Blue,
    B = BlynclightController.Color.Cyan,
    C = BlynclightController.Color.Green,
    D = BlynclightController.Color.Purple,
    E = BlynclightController.Color.Red,
    F = BlynclightController.Color.Yellow,
    G = BlynclightController.Color.White,
    Rest = BlynclightController.Color.Off,
  }

  public static class ColorNoteExt
  {
    public static BlynclightController.Color ToColor(this Enum value)
    {
      BlynclightController.Color ret = BlynclightController.Color.Off;
      switch((ColorNote)value)
      {
        case ColorNote.A: ret = BlynclightController.Color.Blue; break;
        case ColorNote.B: ret = BlynclightController.Color.Cyan; break;
        case ColorNote.C: ret = BlynclightController.Color.Green; break;
        case ColorNote.D: ret = BlynclightController.Color.Purple; break;
        case ColorNote.E: ret = BlynclightController.Color.Red; break;
        case ColorNote.F: ret = BlynclightController.Color.Yellow; break;
        case ColorNote.G: ret = BlynclightController.Color.White; break;
      }
      return ret;
    }
  }
}
