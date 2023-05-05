using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPortal : MonoBehaviour
{

    public GameObject EndTitle;
    //public Animator animator;


    void OnTriggerEnter(Collider other)
    {
        //animator.SetBool("Fade Out", true);
        EndTitle.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        EndTitle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
