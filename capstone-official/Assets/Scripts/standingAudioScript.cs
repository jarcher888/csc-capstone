using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standingAudioScript : MonoBehaviour
{
    AudioSource standingAudio;

    // Start is called before the first frame update
    void Start()
    {
        standingAudio = GetComponent<AudioSource>();
        standingAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(standingAudio.isPlaying) {
                standingAudio.Stop();
                standingAudio.Play();
            } else {
                standingAudio.Play();
            }
        }
        
    }
}
