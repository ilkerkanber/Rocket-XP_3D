using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] float maxFuel=100f;
    [SerializeField] float currentFuel;
    [SerializeField] ParticleSystem particle;

    public bool isEmpty => currentFuel < 1f;
    public float CurrentFuel => currentFuel;
    
    private void Awake()
    {
        currentFuel = maxFuel;
    }
    public void FuelIncrease(float increase)
    {
        currentFuel += increase;
        currentFuel = Mathf.Min(currentFuel, maxFuel);

        if (particle.isPlaying) { 
            particle.Stop(); 
        }
    }

    public void FuelDecrease(float decrease)
    {
        currentFuel -= decrease;
        currentFuel = Mathf.Max(currentFuel, 0f);

        if (particle.isStopped)
        {
            particle.Play();
        }
    }
}
