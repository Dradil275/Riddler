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
    public GameObject Door;
    public Material Green;
    public Material Yellow;
    public Material Red;
    Material originalCrystalMat;
    public GameObject SphereG;
    public GameObject SphereY;
    public GameObject SphereR;
    public GameObject WandCrystal;
    bool isGreen;
    bool isYellow;
    bool isRed; // and flags
    bool isAbilty;


    //FLAGS
    public GameObject stripR;
    public GameObject stripW;
    public GameObject stripB;
    bool isBlue;
    bool isWhite;
    bool isFlagAbilty;
    public Material white;
    public Material blue;
    public GameObject door4;

    void Start()
    {
        isAbilty = true;
        maxDistance = 30f;
        originalCrystalMat = WandCrystal.GetComponent<MeshRenderer>().material;
    }


    void Update()
    {
        if (isAbilty)
        { //color ability (raycast)
            origin = Camera.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            if (Input.GetMouseButtonDown(1))
            {
                Debug.DrawRay(origin, Camera.transform.forward * maxDistance);
                if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance))
                {

                    if (hit.collider.tag == "color")
                    {
                        newMaterial = hit.transform.GetComponent<MeshRenderer>().material;
                        WandCrystal.GetComponent<MeshRenderer>().material = newMaterial;
                    }
                }
            }
            if (Input.GetMouseButtonDown(0))
            {

                if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance))
                {

                    if (hit.collider.tag == "colorObject")
                    {
                        hit.transform.GetComponent<MeshRenderer>().material = newMaterial;
                    }
                }
            }
        }
        // check if solcved
        if (SphereG.GetComponent<MeshRenderer>().material.color == Green.color)
        {
            isGreen = true;
            
        }
        else isGreen = false;

        if (SphereY.GetComponent<MeshRenderer>().material.color == Yellow.color)
        {
            isYellow = true;
            
        }
        else isYellow = false;

        if (SphereR.GetComponent<MeshRenderer>().material.color == Red.color)
        {
            isRed = true;
           
        }
        else isRed = false;

        //if solved
        if(isGreen == true && isYellow == true && isRed == true)
        {
            Destroy(Door);
            WandCrystal.GetComponent<MeshRenderer>().material = originalCrystalMat;
        }

        //    FLAGS LEVEL 4 !!!

        // check if solcved
        if (stripR.GetComponent<MeshRenderer>().material.color == Red.color)
        {
            isRed = true;

        }
        else isRed = false;

        if (stripW.GetComponent<MeshRenderer>().material.color == white.color)
        {
            isWhite = true;

        }
        else isWhite = false;

        if (stripB.GetComponent<MeshRenderer>().material.color == blue.color)
        {
            isRed = true;

        }
        else isRed = false;

        //if solved
        if (isWhite == true && isBlue == true && isRed == true)
        {
            Destroy(door4);
            WandCrystal.GetComponent<MeshRenderer>().material = originalCrystalMat;
            isAbilty = false;
        }

    }
}
