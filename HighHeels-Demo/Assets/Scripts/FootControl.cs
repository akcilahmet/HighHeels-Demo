using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootControl : MonoBehaviour
{
    public GameObject leftParent;
    public GameObject rightParent;
    public static int heel = 0;


  

    private void Start()
    {
        heel = 0;
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "heeltag")
        {
            Debug.Log("Temas oldu");
            leftParent.transform.GetChild(heel).gameObject.SetActive(true);
            rightParent.transform.GetChild(heel).gameObject.SetActive(true);
            Destroy(collision.gameObject);
            heel++;

        }
    }
}
