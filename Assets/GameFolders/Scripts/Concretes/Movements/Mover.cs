using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Movements
{
    public class Mover
    {
        Rigidbody rigidBody;
        public Mover(Rigidbody rBody)
        {
            rigidBody = rBody;
        }
        public void FixedTick()
        {
            rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * 55f);
        }

    }
}

