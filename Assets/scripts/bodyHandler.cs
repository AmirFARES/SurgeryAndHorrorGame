using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyHandler : MonoBehaviour
{
    public bool isSticked = false;
    public GameObject blood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("hhh");
    //    Debug.Log(collision.contacts[0].point);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "item")
        {
            Instantiate(blood, other.transform.position, Quaternion.FromToRotation(Vector3.up, other.transform.position));
        }
        if (other.gameObject.tag == "fork")
        {
            isSticked = true;
        }
    }
}
