using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcomeAudioScript : MonoBehaviour
{
    AudioSource welcomeAudio;

    // Start is called before the first frame update
    void Start()
    {
        welcomeAudio = GetComponent<AudioSource>();
        welcomeAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(welcomeAudio.isPlaying) {
                welcomeAudio.Stop();
                welcomeAudio.Play();
            } else {
                welcomeAudio.Play();
            }
        }
        
    }
}
