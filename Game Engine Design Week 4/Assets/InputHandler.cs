using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Command ChangeCurrentGame;

    private void Start()
    {
        ChangeCurrentGame = new ChangingItem();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ChangeCurrentGame.Execute();
        }
    }
}
