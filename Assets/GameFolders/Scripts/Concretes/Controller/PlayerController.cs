using SampleProject3D.Inputs;
using SampleProject3D.Managers;
using SampleProject3D.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Controller {
    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float turnSpeed = 10f;
        [SerializeField] float force=55f;
        
        DefaultInput _Input;
        Mover _Mover;
        Rotator _Rotator;
        Fuel _Fuel;

        bool canForceUp;
        float LeftRight;
        bool canMove;

        public float TurnSpeed => turnSpeed;
        public float Force => force;
        public bool CanMove => canMove;

        private void Awake()
        {
            _Input = new DefaultInput();
            _Mover = new Mover(this);
            _Rotator = new Rotator(this);
            _Fuel = GetComponent<Fuel>();
            
        }
        private void Start()
        {
            canMove = true;
            GameManager.Instance.OnGameOver += FreezePlayerEvent;
            GameManager.Instance.OnMissionSucced += FreezePlayerEvent;
        }


        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= FreezePlayerEvent;
            GameManager.Instance.OnMissionSucced -= FreezePlayerEvent;
        }

        private void Update()
        {
            if (!canMove)
            {
                return; 
            }
            if (_Input.IsForceUp && !_Fuel.isEmpty ) 
            {
                canForceUp = true; 
            }
            else 
            {
                canForceUp = false;
                _Fuel.FuelIncrease(0.1f);
            }
            LeftRight = _Input.LeftRight;
        }
        private void FixedUpdate()
        {
            if (canForceUp)
            {
                _Mover.FixedTick();
                _Fuel.FuelDecrease(0.2f);
            }
            _Rotator.FixedTick(LeftRight);
        }

        private void FreezePlayerEvent()
        {
            canMove = false;
            canForceUp = false;
            LeftRight = 0f;
            _Fuel.FuelIncrease(0f);
        }


    }
}

