using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleProject3D.Managers
{
    public class SoundManager : SingletonObject<SoundManager>
    {
        AudioSource[] audioSource;
        private void Awake()
        {
            SetupSingleTon(this);
            audioSource = GetComponentsInChildren<AudioSource>();
        }
        public void PlaySound(int index)
        {
            if (!audioSource[index].isPlaying)
            {
                audioSource[index].Play();
            }
        }
        public void StopSound(int index)
        {
            if (audioSource[index].isPlaying)
            {
                audioSource[index].Stop();
            }
        }

    }

}
