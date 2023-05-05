using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPitch : MonoBehaviour
{

    public int enterPitch = 2;
    public int exitPitch = 1;
    public AudioSource music;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        music.pitch = enterPitch;
    }

    void OnTriggerExit(Collider other)
    {
        music.pitch = exitPitch;
    }
}
