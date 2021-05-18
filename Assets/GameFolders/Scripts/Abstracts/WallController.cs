using SampleProject3D.Controller;
using SampleProject3D.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SampleProject3D.Abstracts.Controller {

    public abstract class WallController : MonoBehaviour
    {
         void OnCollisionEnter(Collision collision)
        {
            PlayerController pController = collision.collider.GetComponent<PlayerController>();
            if (pController != null && pController.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    
    }
}
