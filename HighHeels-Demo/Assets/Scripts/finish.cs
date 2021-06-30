using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "testtag")
        {
            player.GetComponent<PlayerMoveControl>().enabled = false;
            player.GetComponent<Animator>().SetTrigger("finishprm");
            StartCoroutine(FinishTime());
        }
    }

    IEnumerator FinishTime()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);

    }
}
