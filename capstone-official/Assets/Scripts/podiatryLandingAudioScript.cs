using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podiatryLandingAudioScript : MonoBehaviour
{
    AudioSource podiatryLandingAudio;

    // Start is called before the first frame update
    void Start()
    {
        podiatryLandingAudio = GetComponent<AudioSource>();
        podiatryLandingAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(podiatryLandingAudio.isPlaying) {
                podiatryLandingAudio.Stop();
                podiatryLandingAudio.Play();
            } else {
                podiatryLandingAudio.Play();
            }
        }
        
    }
}
