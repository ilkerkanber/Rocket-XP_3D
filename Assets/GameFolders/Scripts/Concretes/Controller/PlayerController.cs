using SampleProject3D.Inputs;
using SampleProject3D.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Controller {
    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float force;
        
        DefaultInput _Input;
        Mover _Mover;

        bool isForceUp;
        
        private void Awake()
        {
            _Input = new DefaultInput();
            _Mover = new Mover(GetComponent<Rigidbody>());
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
        }
        private void FixedUpdate()
        {
            if (isForceUp)
            {
                _Mover.FixedTick();
            }
        }

    }
}

