using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GameInput
{
  public class ControlScheme
  {
    private Dictionary<InputAction, InputBinding> Bindings;
    //private Dictionary<InputAction, string> axisInput;
    //private Dictionary<InputAction, Action> actions;

    private int length;

    Player player;

    public ControlScheme()
    {
      Bindings = new Dictionary<InputAction, InputBinding>();

      length = Enum.GetNames(typeof(InputAction)).Length;

      for (int i = 0; i < length; i++)
      {
        Bindings.Add((InputAction)i, new InputBinding());

        //keyInput.Add((InputAction)i, KeyCode.None);
        //axisInput.Add((InputAction)i, "");
      }
    }
    public void Update()
    {
      for (int i = 0; i < Bindings.Count; i++)
      {
        KeyCode code = Bindings[(InputAction)i].Key;
        string axis = Bindings[(InputAction)i].Axis;

        if (Input.GetKey(code) || Input.GetAxis(axis) != 0)
          Bindings[(InputAction)i].Action.Invoke();
      }
    }
    public void SetAxis(InputAction action, string axis)
    {
      //Bindings[action].Axis;
    }

    public void SetAction(InputAction action, Action method)
    {
      Bindings[action].Action = method;
    }

    public void SetAxes(Dictionary<InputAction, string> axes)
    {
      //axisInput = axes;
    }

    public void SetKey(InputAction action, KeyCode key)
    {

    }

    public void SetKeys(Dictionary<InputAction, KeyCode> keys)
    {
      //keyInput = keys;
    }
  }
}  