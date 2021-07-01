using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footHeelControl : MonoBehaviour
{
    
    //parent values ​​created in the player
    public GameObject leftParent;
    public GameObject rightParent;
    public  int heel=1;

    private void Start()
    {
        heel = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leftheeltag")
        {
            //Left parent's children are activated according to the heel object taken from the ground
            Destroy(other.gameObject);
            leftParent.transform.GetChild(heel).gameObject.SetActive(true);
            rightParent.transform.GetChild(heel).gameObject.SetActive(true);
            heel++;
        }
    }
}
