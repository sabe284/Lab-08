﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class GridSpace : MonoBehaviour {

    public Button button;
    public Text buttonText;
    public string playerSide;

    private GameController gameController;

    public void SetGameControllerReference (GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = playerSide;
        button.interactable = false;
    }

}


