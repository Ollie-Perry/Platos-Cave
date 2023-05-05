using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchControl : MonoBehaviour
{
    Light torch;
    AudioSource torchClick;

    // Start is called before the first frame update
    void Start()
    {
        torch = GetComponent<Light>();
        torchClick = GetComponent<AudioSource>();
        //torchClick.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            torch.enabled = !torch.enabled;
            torchClick.PlayDelayed(0);
        }
    }
}