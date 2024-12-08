using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigToeAudioScript : MonoBehaviour
{
    AudioSource bigToeAudio;

    // Start is called before the first frame update
    void Start()
    {
        bigToeAudio = GetComponent<AudioSource>();
        bigToeAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(bigToeAudio.isPlaying) {
                bigToeAudio.Stop();
                bigToeAudio.Play();
            } else {
                bigToeAudio.Play();
            }
        }
        
    }
}
