using SampleProject3D.Abstracts.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Controller
{
    public class MoverWall : WallController
    {
        [SerializeField] Vector3 direction;

        [Range(0f, 1f)]
        [SerializeField] float factor;

        Vector3 startPosition;

        void Awake()
        {
            startPosition = transform.position;
        }
        private void Update()
        {
            Vector3 offset = direction * factor;
            transform.position = offset + startPosition;
        }
    }

}

