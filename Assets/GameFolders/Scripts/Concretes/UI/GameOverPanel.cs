using SampleProject3D.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.UI {
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }

}
