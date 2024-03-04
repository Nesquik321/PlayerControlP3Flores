using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -17);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetKey(KeyCode.R))
        {

        }
    }
}
