using SampleProject3D.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.UI
{
    public class WinObject : MonoBehaviour
    {
        [SerializeField] GameObject winObjectPanel;
        private void Awake()
        {
            if (winObjectPanel.activeSelf)
            {
                winObjectPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += ActivedWinPanel;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= ActivedWinPanel;
        }

        private void ActivedWinPanel()
        {
            if (!winObjectPanel.activeSelf) {

                winObjectPanel.SetActive(true);
            }

        }
    
    }
}
