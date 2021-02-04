using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public Transform up;
    public Transform down;
    public Transform left;
    public Transform right;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnNotes());
    }

    IEnumerator spawnNotes() {
        yield return new WaitForSeconds(1);
        Instantiate(up, transform.GetChild(3));

        yield return new WaitForSeconds(1);
        Instantiate(up, transform.GetChild(3));

        yield return new WaitForSeconds(1);
        Instantiate(up, transform.GetChild(3));
    }
}
