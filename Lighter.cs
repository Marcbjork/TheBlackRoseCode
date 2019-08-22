using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    bool Lighterisup = false;
    //public Animator anim;
    public GameObject theFire;
    public bool hasLighter = false;
    private GameObject arm;
    [SerializeField] private SoundContainer lighterSFX;
    public GameObject armMesh;
    public GameObject lighterMesh;
    public LighterUIManager lighterUIManager;

    [HideInInspector]
    public bool lighterInUse = false;

    void Start()
    {
        //lighterUIManager = FindObjectOfType<LighterUIManager>();

        arm = GameObject.FindGameObjectWithTag("Arm");
        theFire.SetActive(false);
        //gameObject.SetActive(false);
        //anim = GetComponent<Animator>();
        armMesh.SetActive(false);
        lighterMesh.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q) && !lighterInUse)
        {

            if (Lighterisup)
            {
               
                RemoveLighter();
                Debug.Log("Remove");
            }
            else if (hasLighter)
            {
                ActivateLighter();
                Debug.Log("Activate");
            }
        }
    }

    public void RemoveLighter()
    {
        //gameObject.SetActive(false);
        theFire.SetActive(false);
        //anim.SetBool("Lighter", false);
        Lighterisup = false;
        //StartCoroutine(TurnLighterOff());
        lighterSFX.PlayClipSet2();
        lighterMesh.SetActive(false);
    }

    public void BlowOutLighter()
    {
        theFire.SetActive(false);
        //anim.SetBool("Lighter", false);
        Lighterisup = false;
        StartCoroutine(TurnLighterOff());
        print("blow out lighter");
        lighterMesh.SetActive(false);
    }

    void ActivateLighter()
    {
        theFire.SetActive(true);
        //StartCoroutine("changecondition");
        //gameObject.SetActive(true);
        //anim.SetBool("Lighter", true);
        Lighterisup = true;
        lighterMesh.SetActive(true);
        lighterSFX.PlayClipSet1();
        if (lighterUIManager.canDeactivate)
        {
            lighterUIManager.qToActivateState(false);
            lighterUIManager.lighthAcquiredState(false);
            lighterUIManager.canDeactivate = false;
        }

    }

    public void PlayLighterSound()
    {
        if (Lighterisup)
            lighterSFX.PlayClipSet1();
    }

    IEnumerator changecondition()
    {
        lighterInUse = true;
        //armMesh.SetActive(true);
        lighterMesh.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        theFire.SetActive(true);
        lighterInUse = false;
    }

    IEnumerator TurnLighterOff()
    {
        lighterInUse = true;
        yield return new WaitForSeconds(1.2f);
        //armMesh.SetActive(false);
        lighterMesh.SetActive(false);
        lighterInUse = false;
    }
    //if (Input.GetKeyUp(KeyCode.K))
    //{
    //    anim.SetInteger("condition", 0);
    //}



    //anim.Play("Lighter-pick up");

    //anim.Play("Lighter- Idle");



}
