using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int currentGame = 1;
    public static string GameName = "Mountainous Walk";
    public TMP_Text gameNameBox;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameNameBox.text = "Current Pallet: " + GameName;
    }

}
