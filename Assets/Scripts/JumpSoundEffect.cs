using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSoundEffect : MonoBehaviour {
    public AudioSource jumpSound;
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space) && Time.timeScale == 1)
        {
            jumpSound.Play();
        }
	}
}
