using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorExit : MonoBehaviour
{
    [SerializeField] GameObject storeDoor;
    // Start is called before the first frame update
    void Start()
    {
        if (storeDoor == null)
            storeDoor = GameObject.FindGameObjectWithTag("StoreDoor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.gameObject.tag == "StoreDoor")
        {
            SceneManager.LoadScene("Land&Pier");
        }

    }
}
