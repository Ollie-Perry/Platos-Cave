using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOff : MonoBehaviour
{

    public GameObject ScriptLight;
    public AudioSource LampSwitch;
    public bool playSound;

    // Start is called before the first frame update
    void Start()
    {
        playSound = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        ScriptLight.SetActive(false);
        if (playSound)
        {
            LampSwitch.Play();
            playSound = false;
        }

    }

    void OnTriggerExit(Collider other)
    {
    }
}
