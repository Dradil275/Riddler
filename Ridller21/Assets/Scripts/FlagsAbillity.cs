using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagsAbillity : MonoBehaviour
{
    public GameObject Camera;
    Vector3 origin;
    RaycastHit hit;
    float maxDistance;
    Material newMaterial;
    public GameObject Door;
    public Material white;
    public Material blue;
    public Material red;
    Material originalCrystalMat;
    public GameObject stripR;
    public GameObject stripW;
    public GameObject stripB;
    public GameObject WandCrystal;
    bool isBlue;
    bool isWhite;
    bool isRed;
    bool isAbilty;
    // Start is called before the first frame update
    void Start()
    {
        isAbilty = true;
        maxDistance = 30f;
        originalCrystalMat = WandCrystal.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // check if solcved
        if (stripR.GetComponent<MeshRenderer>().material.color == red.color)
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
            Destroy(Door);
            WandCrystal.GetComponent<MeshRenderer>().material = originalCrystalMat;
            isAbilty = false;
        }

        
    }
}
