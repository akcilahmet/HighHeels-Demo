using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clyinderControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject LeftUpleg;
    public GameObject RightUpleg;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        //Debug.Log(footControl.heel);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leftparenttag")
        {
            
            Player.GetComponent<Rigidbody>().useGravity = false;
            Debug.Log("Temas oldu silindire");
            Player.GetComponent<Animator>().SetBool("clapprm", true);
            //Debug.Break();
            LeftUpleg.GetComponent<Transform>().localEulerAngles =new Vector3(0, 0 ,-90);
            RightUpleg.GetComponent<Transform>().localEulerAngles = new Vector3(0, 0, 90);
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
