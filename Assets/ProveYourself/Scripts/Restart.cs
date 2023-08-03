using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public ParticleSystem smoke;

    void Start()
    {
        smoke.Stop();
    }
    void OnCollisionEnter(Collision other)
    {
        //if hit a wall, play smoke animation and restart game in 1 frame
        if(other.gameObject.CompareTag("wall")){
            smoke.Play();
            Invoke("Reset", .8f);
        }
    }

    void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
