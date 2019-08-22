using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private Transform player;
    private Transform Respawn1;
    private Transform Respawn2;
    private Transform Respawn3;
    private Transform Respawn4;
    private Transform Respawn5;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Respawn1 = GameObject.FindGameObjectWithTag("Respawn1").transform;
        Respawn2 = GameObject.FindGameObjectWithTag("Respawn2").transform;
        Respawn3 = GameObject.FindGameObjectWithTag("Respawn3").transform;
        Respawn4 = GameObject.FindGameObjectWithTag("Respawn4").transform;
        Respawn5 = GameObject.FindGameObjectWithTag("Respawn5").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("trabnsfiorn1");
            player.transform.position = Respawn1.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.transform.position = Respawn2.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.transform.position = Respawn3.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            player.transform.position = Respawn4.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            player.transform.position = Respawn5.transform.position;
        }

    }
}
