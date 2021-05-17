﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Managers {
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public static GameManager Instance { get; private set; }
        

        private void Awake()
        {
            SingletonPattern();
        }

        void SingletonPattern()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
    }
}