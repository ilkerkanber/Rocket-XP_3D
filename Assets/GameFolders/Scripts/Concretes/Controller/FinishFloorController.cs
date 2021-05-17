using SampleProject3D.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SampleProject3D.Controller {
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject finishFireWork;
        [SerializeField] GameObject finishLight;

        private void OnCollisionEnter(Collision obj)
        {
            PlayerController player = obj.collider.GetComponent<PlayerController>();
            if (player == null) { 
                return;
            }
                if (obj.GetContact(0).normal.y == -1)
                {
                    finishFireWork.SetActive(true);
                    finishLight.SetActive(true);
                    GameManager.Instance.MissionSucced();
                }
                else
                {
                   GameManager.Instance.GameOver();
                }
        }
    }
}
