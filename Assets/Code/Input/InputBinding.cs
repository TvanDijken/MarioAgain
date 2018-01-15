using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GameInput
{
  public class InputBinding
  {
    private KeyCode key;
    private string axis;
    private Action action;

    public InputBinding()
    {
      Key = KeyCode.None;
      Axis = "";
      Action = null;
    }

    public KeyCode Key
    {
      get
      {
        return key;
      }

      set
      {
        key = value;
      }
    }

    public string Axis
    {
      get
      {
        return axis;
      }

      set
      {
        axis = value;
      }
    }

    public Action Action
    {
      get
      {
        return action;
      }

      set
      {
        action = value;
      }
    }
  }
}
