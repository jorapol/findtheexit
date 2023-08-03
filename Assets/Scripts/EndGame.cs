using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public ParticleSystem stars;
   
    void Start()
    {
        stars.Stop();
    }

    void OnTriggerEnter(Collider other){
        //if go through the exit, play the star particle system
        if(other.gameObject.CompareTag("Player")){
            stars.Play();
            Destroy(this);
        }
    }
}
