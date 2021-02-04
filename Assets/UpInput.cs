using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpInput : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            if (collision.gameObject.CompareTag("Perfect")
                && collision.gameObject.CompareTag("Good")
                && collision.gameObject.CompareTag("Bad"))
            {
                GameManager.score += 300;
                GameManager.health += 5;
                Destroy(gameObject);
            }
            else if (collision.gameObject.CompareTag("Good")
                && collision.gameObject.CompareTag("Bad")) {
                GameManager.score += 150;
                GameManager.health += 3;
                Destroy(gameObject);
            }
            else if (collision.gameObject.CompareTag("Bad")) {
                GameManager.score += 50;
                Destroy(gameObject);
            }
        }
    }
}
