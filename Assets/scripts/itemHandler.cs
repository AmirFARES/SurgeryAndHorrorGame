using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHandler : MonoBehaviour
{
    private int sItem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            int sItem = GameObject.Find("itemHolder").GetComponent<itemSwapper>().selectedItem;
            if (sItem == 0)
            {
                Vector3 oldPos = new Vector3(0.6f, 0.43f, 0.65f);
                Vector3 newPos = new Vector3(0f, 0.9f, 1.6f);
                transform.localPosition = Vector3.Lerp(newPos, oldPos, Time.deltaTime);
                transform.localEulerAngles = Vector3.Lerp(new Vector3(0f, 0f, 0f), new Vector3(10f, -20f, 40f), Time.deltaTime);
            }
            else if (sItem == 1)
            {
                Vector3 oldPos = new Vector3(0.5f, 0.5f, 0.5f);
                Vector3 newPos = new Vector3(0f, 0.9f, 1.4f);
                transform.localPosition = Vector3.Lerp(newPos, oldPos, Time.deltaTime);
            }
            else if (sItem == 2)
            {
                Vector3 oldPos = new Vector3(0.85f, 1f, 1.45f);
                Vector3 newPos = new Vector3(0.1f, 0.9f, 1.4f);
                transform.localPosition = Vector3.Lerp(newPos, oldPos, Time.deltaTime);
                transform.localEulerAngles = Vector3.Lerp(new Vector3(40f, 70f, -20f), new Vector3(40f, 70f, -20f), Time.deltaTime);
            }
            else if (sItem == 3)
            {
                Vector3 oldPos = new Vector3(0.4f, 0.8f, 0.4f);
                Vector3 newPos = new Vector3(0.1f,0.9f,1.5f);
                transform.localPosition = Vector3.Lerp(newPos, oldPos, Time.deltaTime);
                transform.localEulerAngles = Vector3.Lerp(new Vector3(95f, -50f, 0f), new Vector3(100f, -10f, 0f), Time.deltaTime);
                bool isSti= GameObject.Find("bodypart_05").GetComponent<bodyHandler>().isSticked;
                if (isSti)
                {
                    FixedJoint joint = gameObject.AddComponent<FixedJoint>();
                    joint.anchor = gameObject.transform.position;
                    joint.connectedBody = GameObject.Find("bodypart_05").GetComponent<Rigidbody>();
                    joint.enableCollision = false;
                }
            }

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            int sItem = GameObject.Find("itemHolder").GetComponent<itemSwapper>().selectedItem;
            if (sItem == 0)
            {
                Vector3 oldPos1 = new Vector3(0f, 0.9f, 1.6f);
                Vector3 newPos1 = new Vector3(0.6f, 0.43f, 0.65f);
                transform.localPosition = Vector3.Lerp(newPos1, oldPos1, Time.deltaTime);
                transform.localEulerAngles = Vector3.Lerp(new Vector3(10f, -20f, 40f), new Vector3(0f, 0f, 0f), Time.deltaTime);
            }
            else if (sItem == 1)
            {
                Vector3 oldPos1 = new Vector3(0f, 0.9f, 1.4f);
                Vector3 newPos1 = new Vector3(0.5f, 0.5f, 0.5f);
                transform.localPosition = Vector3.Lerp(newPos1, oldPos1, Time.deltaTime);
            }
            else if (sItem == 2)
            {
                Vector3 oldPos1 = new Vector3(0.1f, 0.9f, 1.4f);
                Vector3 newPos1 = new Vector3(0.85f, 1f, 1.45f);
                transform.localPosition = Vector3.Lerp(newPos1, oldPos1, Time.deltaTime);
                transform.localEulerAngles = Vector3.Lerp(new Vector3(40f, 70f, -20f), new Vector3(40f, 70f, -20f), Time.deltaTime);
            }
            else if (sItem == 3)
            {
                Vector3 oldPos1 = new Vector3(0.1f, 0.9f, 1.5f);
                Vector3 newPos1 = new Vector3(0.4f, 0.8f, 0.4f);
                transform.localPosition = Vector3.Lerp(newPos1, oldPos1, Time.deltaTime);
                transform.localEulerAngles = Vector3.Lerp(new Vector3(100f, -10f, 0f), new Vector3(95f, -50f, 0f), Time.deltaTime);
            }
        }
        int sItem2 = GameObject.Find("itemHolder").GetComponent<itemSwapper>().selectedItem;
        bool isSti2 = GameObject.Find("bodypart_05").GetComponent<bodyHandler>().isSticked;
        if (sItem2 == 3 && isSti2)
        {
            transform.localPosition= new Vector3(0.85f, 1f, 1.45f);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1)&&sItem2==3)
        {
            GameObject.Find("bodypart_05").GetComponent<bodyHandler>().isSticked = false;
            bool isSti = GameObject.Find("bodypart_05").GetComponent<bodyHandler>().isSticked;
            FixedJoint[] jointss = GetComponents<FixedJoint>();
            for (int i = 0; i < jointss.Length; i++)
            {
                Destroy(jointss[i]);
            }
        }
    }
}
