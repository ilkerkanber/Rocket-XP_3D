using SampleProject3D.Inputs;
using SampleProject3D.Movements;
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

        bool isForceUp;
        float LeftRight;

        public float TurnSpeed => turnSpeed;
        public float Force => force;
        private void Awake()
        {
            _Input = new DefaultInput();
            _Mover = new Mover(this);
            _Rotator = new Rotator(this);
        }
        private void Update()
        {
            if (_Input.IsForceUp) 
            {
                isForceUp = true; 
            }
            else 
            {
                isForceUp = false; 
            }
            LeftRight = _Input.LeftRight;
        }
        private void FixedUpdate()
        {
            if (isForceUp)
            {
                _Mover.FixedTick();
            }
            _Rotator.FixedTick(LeftRight);
       
        }

    }
}

