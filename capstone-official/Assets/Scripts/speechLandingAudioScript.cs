using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speechLandingAudioScript : MonoBehaviour
{
    AudioSource speechLandingAudio;

    // Start is called before the first frame update
    void Start()
    {
        speechLandingAudio = GetComponent<AudioSource>();
        speechLandingAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(speechLandingAudio.isPlaying) {
                speechLandingAudio.Stop();
                speechLandingAudio.Play();
            } else {
                speechLandingAudio.Play();
            }
        }
        
    }
}
