using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameObject Portal;
    public Animator animator;
    public AudioSource Rubble;

    void OnTriggerEnter(Collider other)
    {
        Portal.SetActive(true);
        animator.SetBool("Rise", true);
        Rubble.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        Portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
