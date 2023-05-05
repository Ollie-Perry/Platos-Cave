using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogDistance : MonoBehaviour
{

    public GameObject player;
    public float fogValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        Debug.Log(dist);
        fogValue = 1 / dist;
        RenderSettings.fogDensity = fogValue;
    }
}
