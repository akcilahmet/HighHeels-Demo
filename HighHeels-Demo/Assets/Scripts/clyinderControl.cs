using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clyinderControl : MonoBehaviour
{
    public GameObject LeftUpleg;
    public GameObject RightUpleg;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetBool("clapprm", true);
            LeftUpleg.GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);
            RightUpleg.GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -90);
        }
    }

}
