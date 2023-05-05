using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceTrigger : MonoBehaviour
{
    public GameObject Reverb;

    void OnTriggerEnter(Collider other)
    {
        Reverb.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Reverb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
