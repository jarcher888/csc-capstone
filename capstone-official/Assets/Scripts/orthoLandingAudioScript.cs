using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orthoLandingAudioScript : MonoBehaviour
{
    AudioSource orthoLandingAudio;

    // Start is called before the first frame update
    void Start()
    {
        orthoLandingAudio = GetComponent<AudioSource>();
        orthoLandingAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(orthoLandingAudio.isPlaying) {
                orthoLandingAudio.Stop();
                orthoLandingAudio.Play();
            } else {
                orthoLandingAudio.Play();
            }
        }
        
    }
}
