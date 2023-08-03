using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishParticlePlay : MonoBehaviour
{
    public ParticleSystem stars;
    
    void Start()
    {
        stars.Stop();
    }

    void OnCollisionEnter(Collision other)
    {
        stars.Play();
    }
}
