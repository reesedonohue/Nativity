using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugLocation : MonoBehaviour {

    private Text text;

    private void Start()
    {
        text = GetComponentInChildren<Text>();
    }
    void Update () {
        text.text = transform.position.ToString();
	}
}
