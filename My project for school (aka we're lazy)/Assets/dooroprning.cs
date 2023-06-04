using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooroprning : MonoBehaviour
{
    public GameObject DoorClose, DoorOpen;
    // Start is called before the first frame update
    void Start()
    {
        DoorClose.SetActive(true);
        DoorOpen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        DoorClose.SetActive(false);
        DoorOpen.SetActive(true);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        DoorClose.SetActive(true);
        DoorOpen.SetActive(false);
    }
}
