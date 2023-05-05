using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    public AudioSource music;
    public AudioSource noise;

    void OnTriggerEnter(Collider other)
    {
        music.Play();
        noise.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
