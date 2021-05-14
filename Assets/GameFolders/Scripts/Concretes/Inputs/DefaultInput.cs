using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Inputs
{
    public class DefaultInput : MonoBehaviour
    {

        DefaultAction input;

        public bool IsForceUp { get; private set; }
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            input = new DefaultAction();
            input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton(); //W Keyboard
            input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>(); //A D Keyboard
            input.Enable();
        }
    }
}


