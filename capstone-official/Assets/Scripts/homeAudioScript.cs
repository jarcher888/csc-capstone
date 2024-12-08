using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeAudioScript : MonoBehaviour
{
    AudioSource homeAudio;

    // Start is called before the first frame update
    void Start()
    {
        homeAudio = GetComponent<AudioSource>();
        homeAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(homeAudio.isPlaying) {
                homeAudio.Stop();
                homeAudio.Play();
            } else {
                homeAudio.Play();
            }
        }
        
    }
}
