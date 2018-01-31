using System.Collections;
using UnityEngine;

public class Hand : MonoBehaviour {
/*
    public float RayDistance = 5;
    public float damage = 10f;

    public GameObject destroyedVersion;

    public Inventory inventory;

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
            print(theDistance + " " + hit.collider.gameObject.name);

            //หยิบของเข้ากระเป๋า
            ItemPickUp itemPickUp = hit.transform.GetComponent<ItemPickUp>();
            if (itemPickUp != null)
            {
                itemPickUp.PickUp();
            }

            //ทำลายสิ่งของ
            TargetHit target = hit.transform.GetComponent<TargetHit>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            //เปลียนหน้าดิน
            if (hit.collider.tag.Equals("Dirt"))
            {
                Destruction swapTarget = hit.transform.GetComponent<Destruction>();
                if (swapTarget != null)
                {
                    swapTarget.SwapObject();
                    
                }
                Instantiate(destroyedVersion, transform.position, transform.rotation);
            }

    
            
            if (hit.collider.tag.Equals("Wood"))
            {
                Destruction swapTarget = hit.transform.GetComponent<Destruction>();
                if (swapTarget != null)
                {
                    inventory.Add(GetComponent<Item>());
                    swapTarget.SwapObject();
                }

            }


            
            
                
            


        }




        //เลเอ๊าช่อง
    }*/
}


