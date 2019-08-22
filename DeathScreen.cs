using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeathScreen : MonoBehaviour
{
    public Image deathImage;
    bool isImageOn;
    int imageflashAmount = 1;
    public GameObject player;
    public NPC_Chaser chaserNPC;
    public EventTrigger eventTrigger;
    public MusicManager musicManager;
    public InteractableTransition interactTransition;
    public BoxCollider boxColliderChaseEvent;

    private void Start()
    {
        musicManager = FindObjectOfType<MusicManager>();
        player = GameObject.FindGameObjectWithTag("Player");   //first way but throws exception
        deathImage.canvasRenderer.SetAlpha(0.0f);
    }

    //whenever UI canvas is set to active again, the opacity is 1 for some reason, adding this so that we can call it manually - John
    public void SetDeathScreenOpacity()
    {
        deathImage.canvasRenderer.SetAlpha(0.0f);
    }

    public void PlayerDeath(NPC_Chaser chaser = null)
    {
        if(chaser != null)chaserNPC = chaser;
        StartCoroutine(deathEvent());
    }

    IEnumerator deathEvent()
    {
        eventTrigger.isDisabled = true;
        //musicManager.MFadeOutIntense(); 
        musicManager.MPlayerDeathHit();
        interactTransition.LockDoor();
        boxColliderChaseEvent.enabled = false;
        yield return new WaitForSeconds(3f);
        FadeIn();
        yield return new WaitForSeconds(4f);
        if (chaserNPC != null) chaserNPC.ResetPosition();
        FadeOut();
    }

    //void PlayerRespawning()
    //{
    //    Debug.Log("RespawnScript");
    //    player.transform.position = respawnPoint.transform.position;
        
    //}


    void FadeIn()
    {
        Debug.Log("FadeIN");
        deathImage.CrossFadeAlpha(1.0f, 1f, false);
    }

    void FadeOut()
    {
        Debug.Log("FadeOUT");
        deathImage.CrossFadeAlpha(0.0f, 2f, true);
    }



}
