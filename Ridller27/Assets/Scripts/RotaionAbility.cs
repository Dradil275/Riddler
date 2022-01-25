using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaionAbility : MonoBehaviour
{
    public GameObject Skeleton;
    public GameObject Protector;
    public GameObject Angel;
    public GameObject Girl;
    public GameObject Camera;
    Vector3 origin;
    Vector3 addRotationToAnegel;
    RaycastHit hit;
    float maxDistance;
    bool isAbilty;
    // Start is called before the first frame update
    void Start()
    {
        maxDistance = 30;
        isAbilty = true;
        addRotationToAnegel =new Vector3(0, -105, 0);
    }

    // Update is called once per frame
    void Update()
    {
        origin = Camera.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        if (isAbilty)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Debug.DrawRay(origin, Camera.transform.forward * maxDistance);
                if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance))
                {

                    if (hit.collider.tag == "Protector")
                    {
                        Debug.Log("hit protector");
                       hit.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y - 94, gameObject.transform.eulerAngles.z);
                    }
                    if(hit.collider.tag == "Angel")
                    {
                        Debug.Log("Angel");
                        hit.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y - 94, gameObject.transform.eulerAngles.z);
                    }
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                Debug.DrawRay(origin, Camera.transform.forward * maxDistance);
                if (Physics.Raycast(origin, Camera.transform.forward, out hit, maxDistance))
                {

                    if (hit.collider.tag == "Protector")
                    {
                        Debug.Log("hit protector");
                        
                    }
                    if (hit.collider.tag == "Angel")
                    {
                        Debug.Log("Angel");
                        hit.transform.Rotate(addRotationToAnegel);
                    }
                }
            }
        }

    }
}
