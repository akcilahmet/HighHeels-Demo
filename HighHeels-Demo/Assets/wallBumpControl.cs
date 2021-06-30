using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBumpControl : MonoBehaviour
{
    public GameObject leftParent;
    public GameObject rightParent;

    footHeelControl footHeelControl;

    private void Awake()
    {
        footHeelControl= FindObjectOfType<footHeelControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wallbumptag")
        {
            leftParent.transform.GetChild(footHeelControl.heel).gameObject.SetActive(false);
            rightParent.transform.GetChild(footHeelControl.heel).gameObject.SetActive(false);
            if (footHeelControl.heel > 1) 
            {
                footHeelControl.heel--;

            }
        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fallprm");
            other.gameObject.GetComponent<PlayerMoveControl>().enabled=false;
            
        }
    }
}
