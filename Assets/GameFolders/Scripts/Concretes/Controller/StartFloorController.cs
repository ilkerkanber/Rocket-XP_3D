
using UnityEngine;

namespace SampleProject3D.Controller
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            if (collision.collider.GetComponent<PlayerController>() != null)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
