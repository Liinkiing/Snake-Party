﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour {

    private GameObject _canvas;

    public void Start() {
        _canvas = GameObject.Find("Canvas");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void ShowMenu(Transform menu) {
        foreach (Transform t in _canvas.transform) {
            if(t.CompareTag("Menu")) t.gameObject.SetActive(false);
        }
        menu.gameObject.SetActive(true);
    }

    public void LaunchGame(int nbPlayers) {
        GameManager.instance.NbPlayers = nbPlayers;
    }
}
