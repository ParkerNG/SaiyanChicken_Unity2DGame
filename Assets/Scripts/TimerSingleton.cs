using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerSingleton : MonoBehaviour {

    public static TimerSingleton _instance { get; private set; }
    public float timeValue;

    private void Start()
    {
        timeValue = 0;
    }

    private void Awake()
    {
        if ((_instance != null) && (_instance != this))
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scene1") {
            timeValue = Time.timeSinceLevelLoad;
        }else if (SceneManager.GetActiveScene().name == "Menu")
        {
            timeValue = 0;
        }
    }
}
