using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameSelector : MonoBehaviour
{
    private void OnTriggerStay(Collider other) {
        if (!Input.GetButtonDown("Submit"))
            return;
        
        switch (gameObject.name)
        {
            case "piraShips":
            SceneManager.LoadScene("piraShips");
            break;
             case "piraPong":
             SceneManager.LoadScene("main");
            break;
             case "piraBreak":
             SceneManager.LoadScene("taverna");
            break;

            default:
            break;
        }
    }
}
