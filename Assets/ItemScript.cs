using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Get");
        audioSource.Play();
    }

    private void DestroySelf() 
    {
        Destroy(gameObject);
    }

    private Animator animator;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
