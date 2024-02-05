using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private bool isThirdPerson = false;

    // Start is called before the first frame update
    void Start()
    {
        // Adjusting the camera's position 
        offset = new Vector3(0, 2.5f, -6.5f); 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isThirdPerson = !isThirdPerson;
        }

        if (isThirdPerson)
        {
            transform.position = new Vector3(0, 10, -15);
            transform.rotation = Quaternion.Euler(45, 0, 0);
        }
        else
        {
            transform.position = player.transform.position + offset;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
