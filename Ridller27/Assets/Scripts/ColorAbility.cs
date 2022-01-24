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
    
   
    void Start()
    {
        maxDistance = 100f;
        origin = Camera.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {

            if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance))
            {
                newMaterial = hit.transform.GetComponent<MeshRenderer>().material;
             /*   if (hit.transform.tag == "color")
                {
                    newMaterial = hit.transform.GetComponent<MeshRenderer>().material;
                }*/
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
         
            if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance))
            {
                hit.transform.GetComponent<MeshRenderer>().material = newMaterial;
             /*   if (hit.transform.tag == "colorObject")
                {
                    hit.transform.GetComponent<MeshRenderer>().material = newMaterial;
                }*/
            }
        }
       
    }
}
