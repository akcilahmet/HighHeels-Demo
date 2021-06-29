using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    public GameObject leftParent;
    public GameObject rigtParent;


  
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "leftparenttag")
        {
            StartCoroutine(dropTime());
        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMoveControl>().enabled = false;
            other.gameObject.GetComponent<Animator>().SetTrigger("fallprm");
            
        }
    }

    IEnumerator dropTime()
    {
        yield return new WaitForSeconds(.2f);
        Debug.Log("duvara temas var");
        leftParent.transform.GetChild(FootControl.heel).gameObject.SetActive(false);
        rigtParent.transform.GetChild(FootControl.heel).gameObject.SetActive(false);
        if (FootControl.heel > 0)
        {
            FootControl.heel--;

        }
    }
}
