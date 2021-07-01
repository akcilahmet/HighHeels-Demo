using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            //in contact with the wall, the activity is closed according to the number of heels in contact
            leftParent.transform.GetChild(footHeelControl.heel).gameObject.SetActive(false);
            rightParent.transform.GetChild(footHeelControl.heel).gameObject.SetActive(false);
            if (footHeelControl.heel > 1) 
            {
                footHeelControl.heel--;

            }
        }
        if (other.gameObject.tag == "Player")
        {
            //If the player hits the wall, the game is ended.
            other.gameObject.GetComponent<Animator>().SetTrigger("fallprm");
            other.gameObject.GetComponent<PlayerMoveControl>().enabled=false;
            StartCoroutine(LoadLevelTime());
        }
    }

    IEnumerator LoadLevelTime()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);

    }
}
