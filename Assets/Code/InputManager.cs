using GameInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Manager
{
  private static ControlScheme[] controlSchemes;

  public InputManager()
  {
    ControlScheme player1 = new ControlScheme();
    ControlScheme player2 = new ControlScheme();

    Dictionary<InputAction, KeyCode> keys = new Dictionary<InputAction, KeyCode>()
    {
      { InputAction.MoveLeft, KeyCode.A },
      { InputAction.MoveRight, KeyCode.D },
      { InputAction.MoveUp, KeyCode.W },
      { InputAction.MoveDown, KeyCode.LeftControl },
      { InputAction.Shoot, KeyCode.E },
    };

    player1.SetKeys(keys);

    controlSchemes = new ControlScheme[2]
    {
      player1,
      player2,
    };
  }

  public override void Awake()
  {
    base.Awake();
  }
}
