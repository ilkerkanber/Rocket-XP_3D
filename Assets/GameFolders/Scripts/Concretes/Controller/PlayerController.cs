using SampleProject3D.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Controller {
    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float force;
        Rigidbody rigidBody;
        DefaultInput Input;
        bool isForceUp;
        
        private void Awake()
        {
            rigidBody = GetComponent <Rigidbody>();
            Input = new DefaultInput();
        }
        private void Update()
        {
            if (Input.IsForceUp) 
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
                rigidBody.AddForce(Vector3.up * Time.deltaTime * force);
            }
        }

    }
}

