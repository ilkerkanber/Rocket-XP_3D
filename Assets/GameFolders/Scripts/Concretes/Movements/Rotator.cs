using SampleProject3D.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SampleProject3D.Movements
{
    public class Rotator : MonoBehaviour
    {
        Rigidbody rBody;
        PlayerController _playerController;

        public Rotator(PlayerController pController)
        {
            _playerController = pController;
            rBody = pController.GetComponent<Rigidbody>();
        }
        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                if (rBody.freezeRotation)
                {
                    rBody.freezeRotation = false;
                }
                return;
            }

            if (!rBody.freezeRotation)
            {
                rBody.freezeRotation = true;
            }
            _playerController.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);

        }

    }

}
