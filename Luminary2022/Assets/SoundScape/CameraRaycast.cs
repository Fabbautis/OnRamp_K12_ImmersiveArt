using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject curser;
    public RaycastHit hit;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.collider.CompareTag("curser")) return;
            curser.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
            //Debug.Log("Curser position: " + curser.transform.position);
            //Debug.Log("Hit position: " + hit.transform.position);
        }
        else curser.transform.position = Vector3.zero;
    }
}
