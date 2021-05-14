using SampleProject3D.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Movements
{
    public class Mover
    {
        Rigidbody rigidBody;
        PlayerController _playerController;
        public Mover(PlayerController plController)
        {
            _playerController = plController;
            rigidBody = plController.GetComponent<Rigidbody>();
        }
        public void FixedTick()
        {
            rigidBody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }

    }
}

