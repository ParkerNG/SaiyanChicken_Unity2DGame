using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SenceMangerScript : MonoBehaviour {
    public Text TimeText;

    private void Start()
    {
        TimeText.text = TimerSingleton._instance.timeValue.ToString();
    }

}
