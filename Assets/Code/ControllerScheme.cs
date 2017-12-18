using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScheme : MonoBehaviour
{
  private Dictionary<InputAction, KeyCode> keyInput;
  private Dictionary<InputAction, string> axisInput;
  private Dictionary<InputAction, Action> actions;

  private int length;

  Player player;

  public ControlScheme()
  {
    keyInput = new Dictionary<InputAction, KeyCode>();
    axisInput = new Dictionary<InputAction, string>();

    length = System.Enum.GetNames(typeof(InputAction)).Length;

    for (int i = 0; i < length; i++)
    {
      keyInput.Add((InputAction)i, KeyCode.None);
      axisInput.Add((InputAction)i, "");
    }
  }
  public void Update()
  {
    for (int i = 0; i < axisInput.Count; i++)
    {
      KeyCode code = keyInput[(InputAction)i];
      string axis = axisInput[(InputAction)i];

      if (Input.GetKey(code) || Input.GetAxis(axis) != 0)
        actions[(InputAction)i].Invoke();
    }
  }

  public void SetAxes(Dictionary<InputAction, string> axes)
  {
    axisInput = axes;
  }

  public void SetKeys(Dictionary<InputAction, KeyCode> keys)
  {
    keyInput = keys;
  }
}
}
