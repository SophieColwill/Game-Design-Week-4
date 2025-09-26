using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingItem : Command
{
    public override void Execute()
    {
        GameManager.currentGame++;

        if (GameManager.currentGame > 4)
        {
            GameManager.currentGame = 1;
        }

        if (GameManager.currentGame == 1)
        {
            GameManager.GameName = "Mountainous Walk";
        }
        else if (GameManager.currentGame == 2)
        {
            GameManager.GameName = "Forest Breeze";
        }
        else if (GameManager.currentGame == 3)
        {
            GameManager.GameName = "Ocean Wave";
        }
        else if (GameManager.currentGame == 4)
        {
            GameManager.GameName = "Void Calling";
        }
    }
}
