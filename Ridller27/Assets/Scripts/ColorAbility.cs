using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAbility : MonoBehaviour
{
    public GameObject Camera;
    Vector3 origin;
    RaycastHit hit;
    float maxDistance;
    Material newMaterial;
    // Start is called before the first frame update
    void Start()
    {
        maxDistance = 100f;
        origin = origin = Camera.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {

            if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance) == true)
            {
                newMaterial = hit.transform.GetComponent<MeshRenderer>().material;
            }
        }
        if(Input.GetMouseButton(1) == true)
        {
            hit.transform.GetComponent<MeshRenderer>().material = newMaterial;
        }
    }
}
