using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoring1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "puck")
        {
            Debug.Log("Gooool");
            SceneManager.LoadScene("Cena 3d");
        }
    }
}
