using SampleProject3D.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.UI
{
    public class WinPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}
