using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLights : MonoBehaviour
{

    public GameObject InteriorLights;
    public GameObject WindowLight;
    public GameObject StairBlock;
    public GameObject VolumeFive;

    void OnTriggerEnter(Collider other)
    {
        InteriorLights.SetActive(false);
        WindowLight.SetActive(false);
        VolumeFive.SetActive(false);
        StairBlock.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        StairBlock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
