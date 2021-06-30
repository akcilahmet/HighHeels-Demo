using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallControl : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player grounda tems etti");
            other.gameObject.GetComponent<Animator>().SetTrigger("fallprm");
        }
    }
}
