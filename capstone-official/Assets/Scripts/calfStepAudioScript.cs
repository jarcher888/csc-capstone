using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calfStepAudioScript : MonoBehaviour
{
    AudioSource calfStepAudio;

    // Start is called before the first frame update
    void Start()
    {
        calfStepAudio = GetComponent<AudioSource>();
        calfStepAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(calfStepAudio.isPlaying) {
                calfStepAudio.Stop();
                calfStepAudio.Play();
            } else {
                calfStepAudio.Play();
            }
        }
        
    }
}
