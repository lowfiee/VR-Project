using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerTrigger : MonoBehaviour
{
    public ScannedItemsManager scannedItemsManager;
    public AudioClip scanningSound; 

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = scanningSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the item to be scanned
        if (other.CompareTag("Item"))
        {
            // Add the scanned item to the list
            scannedItemsManager.AddScannedItem(other.gameObject);

            // Play scanning sound
            audioSource.Play();
        }
    }
}
