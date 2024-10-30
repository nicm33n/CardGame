using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class ButtonAppear : MonoBehaviour
{
    public GameObject button;
    public float waitTime = 3;

    void Start ()
    {
        StartCoroutine(Delay());
        button.SetActive(false);
    }


    private void Update()
    {
        
    }


    IEnumerator Delay()

    {
            yield return new WaitForSeconds(3);
            SpawnButton();
 
    }

    public void SpawnButton()
    {
        if (button.activeInHierarchy == false)
        { 
        button.SetActive(true);
        }
    }
       
}
