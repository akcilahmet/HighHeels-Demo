//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WallControl : MonoBehaviour
//{
//    public GameObject leftParent;
//    public GameObject rigtParent;

//    FootControl footControl;

//    private void Awake()
//    {
//        footControl = FindObjectOfType<FootControl>();
//    }
//    private void OnTriggerExit(Collider other)
//    {
//        if (other.gameObject.tag == "leftparenttag")
//        {

            
//            leftParent.transform.GetChild(footControl.heel).gameObject.SetActive(false);
//            rigtParent.transform.GetChild(footControl.heel).gameObject.SetActive(false);
//            if (footControl.heel > 0)
//            {
//                footControl.heel--;

//            }
//        }
//        if (other.gameObject.tag == "Player")
//        {
//            other.gameObject.GetComponent<PlayerMoveControl>().enabled = false;
//            other.gameObject.GetComponent<Animator>().SetTrigger("fallprm");
            
//        }
//    }

//    IEnumerator dropTime()
//    {
//        yield return new WaitForSeconds(.05f);
//        Debug.Log("duvara temas var");
       
       
//    }
//}
