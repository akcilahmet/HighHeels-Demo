using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footHeelControl : MonoBehaviour
{

    public GameObject leftParent;
    public GameObject rightParent;
    public  int heel=1;

    private void Start()
    {
        heel = 1;
    }
    private void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        //    Debug.Log("Player temas etti");
        //    leftParent.transform.GetChild(heel).gameObject.SetActive(true);
        //    rightParent.transform.GetChild(heel).gameObject.SetActive(true);
        //    heel++;
        //    Debug.Break();

        //}
        if (other.gameObject.tag == "leftheeltag")
        {

            Destroy(other.gameObject);
            leftParent.transform.GetChild(heel).gameObject.SetActive(true);
            rightParent.transform.GetChild(heel).gameObject.SetActive(true);
            heel++;
            Debug.Log("heeldegeri" + heel);
        }
    }
}
