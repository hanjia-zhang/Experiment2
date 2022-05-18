using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunattact : MonoBehaviour
{
    private PlayerController player;

    public int hitpoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D feedback)
    {
        if (feedback.name == "Player")
        {
            player.health  -= hitpoint;
        }
        Debug.Log("I'M bleeding!");
    }
}
