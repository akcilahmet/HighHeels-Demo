using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clyinderControl : MonoBehaviour
{
    public GameObject Player;

  

    private void Update()
    {
        Debug.Log(FootControl.heel);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leftparenttag")
        {
            
                Player.GetComponent<Rigidbody>().useGravity = false;
                Debug.Log("Temas oldu silindire");
                Player.GetComponent<Animator>().SetBool("clapprm", true);
           
        }

       
       
    } 
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "leftparenttag")
        {
            Debug.Log("Temas oldu silindire");
            Player.GetComponent<Animator>().SetBool("clapprm", false);
            Player.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
