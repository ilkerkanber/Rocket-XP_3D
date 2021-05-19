using SampleProject3D.Abstracts.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Controller
{
    public class MoverWall : WallController
    {
        [SerializeField] Vector3 direction;
        [SerializeField] float speed=15f;

        Vector3 startPosition;
        float factor;
        const float CIRCLE = Mathf.PI * 2f;

        void Awake()
        {
            startPosition = transform.position;
        }
        private void Update()
        {
            float cycle = Time.time / speed;
            float sinWave = Mathf.Sin(cycle * CIRCLE);

            factor = (sinWave / 2f) + 0.5f;

            Vector3 offset = direction * factor;
            transform.position = offset + startPosition;
        }
    }

}

