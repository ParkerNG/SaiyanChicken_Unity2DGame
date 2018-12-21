using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMenu : MonoBehaviour {
    [SerializeField] public Canvas PopupMenu;
    public AudioSource SoundEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PopupMenu.enabled = true;
            Time.timeScale = 0;
            SoundEffect.Play();
        }
    }
}
