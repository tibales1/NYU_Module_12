using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public GameObject winMessage;
    // Start is called before the first frame update
    void Start()
    {
        winMessage.SetActive(true);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            Debug.Log("Main camers collided");
            if (winMessage.activeInHierarchy)
            {
                winMessage.SetActive(true);
            }
            
        }
    }
}
