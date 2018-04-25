using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BasicMove : NetworkBehaviour {

    private float speed = 0.5f;

    public override void OnStartLocalPlayer()
    {
        Material mat = GetComponent<Renderer>().material;
        mat.color = Color.blue;
    }
	
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed/10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * -speed/10);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -speed*10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * speed*10);
        }
    }
}
