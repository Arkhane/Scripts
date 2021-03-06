﻿using System.Collections;
using UnityEngine;

public class Axe : MonoBehaviour {

    public float RayDistance = 5;
    public float damage = 10f;

    public GameObject destroyedVersion;

    RaycastHit hit;
    float theDistance;

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Fire1"))
        {
            RaycastPlayer();
        }


    }

    void RaycastPlayer()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * RayDistance;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            theDistance = hit.distance;
            //print(theDistance + " " + hit.collider.gameObject.name);



            //เปลียนหน้าดิน
            if (hit.collider.tag.Equals("Wood"))
            {
                TargetHit target = hit.transform.GetComponent<TargetHit>();
                Destruction swapTarget = hit.transform.GetComponent<Destruction>();
                if (swapTarget != null)
                {
                    swapTarget.SwapObject();
                    target.TakeDamage(damage);
                }
                //Instantiate(destroyedVersion, transform.position, transform.rotation);
            }



        }




    }
}