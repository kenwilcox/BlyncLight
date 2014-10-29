using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlinkNotes
{
  // Just a collection of Blink Notes
  public class BlinkSong
  {
    private List<BlinkNote> _notes;

    public BlinkSong()
    {
      _notes = new List<BlinkNote>();
    }

    public void Add(BlinkNote note)
    {
      _notes.Add(note);
    }

    public void Play()
    {
      foreach (BlinkNote note in _notes)
        note.Play();
    }
  }
}
