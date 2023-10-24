using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    // public GameObject soundObject;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX()
    {
        //GameObject sfx = Instantiate(soundObject);
        //Destroy(sfx, 5f);
        audioSource.Play();

    }





}
