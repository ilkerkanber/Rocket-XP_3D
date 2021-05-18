using SampleProject3D.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObject : MonoBehaviour
{

    [SerializeField] GameObject gameoverPanel;
    private void Awake()
    {
        if (gameoverPanel.activeSelf)
        {
            gameoverPanel.SetActive(false);
        }
     }
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += ActivedGameOverPanel;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= ActivedGameOverPanel;
    }
    private void ActivedGameOverPanel()
    {
        if (!gameoverPanel.activeSelf)
        {
            gameoverPanel.SetActive(true);
        }
    }
}
