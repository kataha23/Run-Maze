using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitItem : MonoBehaviour
{
    public string Itemname;
    public bool IsActivate;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);
            IsActivate = true;
            GameManager.Instance.GetKey();
        }
        Debug.Log(other.name);
    }
}
