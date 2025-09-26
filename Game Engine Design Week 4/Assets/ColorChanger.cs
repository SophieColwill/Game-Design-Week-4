using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DLLTest;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] private ObjectType thisObject;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        string objID = "";

        if (thisObject == ObjectType.Ground)
        {
            objID = "ground";
        }
        else if (thisObject == ObjectType.Goal)
        {
            objID = "goal";
        }
        else if (thisObject == ObjectType.Enemy)
        {
            objID = "enemy";
        }

        float[] newColor = Class1.LocateColor(objID, GameManager.currentGame);
        spriteRenderer.color = new Color(newColor[0], newColor[1], newColor[2]);
    }
}

public enum ObjectType
{
    Ground,
    Enemy,
    Goal
}