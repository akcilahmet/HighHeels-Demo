using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallControl : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            //fall animation activated
            other.gameObject.GetComponent<Animator>().SetTrigger("fallprm");
            StartCoroutine(LoadLevelTime());
        }
    }

    IEnumerator LoadLevelTime()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);

    }
}
