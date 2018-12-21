using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {
    //Use this for looping audio file
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
