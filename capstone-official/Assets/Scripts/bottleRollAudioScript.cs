using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleRollAudioScript : MonoBehaviour
{
    AudioSource bottleRollAudio;

    // Start is called before the first frame update
    void Start()
    {
        bottleRollAudio = GetComponent<AudioSource>();
        bottleRollAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(bottleRollAudio.isPlaying) {
                bottleRollAudio.Stop();
                bottleRollAudio.Play();
            } else {
                bottleRollAudio.Play();
            }
        }
        
    }
}
