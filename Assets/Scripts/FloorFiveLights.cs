using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFiveLights : MonoBehaviour
{
    public GameObject FloorFive;

    void OnTriggerEnter(Collider other)
    {
        FloorFive.SetActive(true);

    }

    // Start is called before the first frame update
    void Start()
    {
        FloorFive.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
