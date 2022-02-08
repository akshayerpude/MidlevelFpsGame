using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource fireSound;
    public AudioSource ReloadSound;
    public AudioSource WalkSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoundOfFire()
    {
        fireSound.Play();
    }

    public void Reload()
    {
        ReloadSound.Play();
    }

    public void Walk()
    {
        WalkSound.Play();
    }
}
