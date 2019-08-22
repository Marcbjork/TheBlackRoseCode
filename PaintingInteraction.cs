//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Cinemachine;

//public class PaintingInteraction : Interactable
//{
//    //FPSPlayer playermovref;
//    //CameraLook camera;
   
//    //float normal;
//    //public int zoom = 20;
//    //public float smooth = 30;
//    //public GameObject NoteMessageUI;
//    //bool isreadingnote = false;
    
//    //public static bool NoteMessage = false;

//    //private bool isZoomed = false;

//    //public CinemachineVirtualCamera cam;

//    //public InteractableTransition door;

//    //private void Start()
//    //{
//    //    playermovref = FindObjectOfType<FPSPlayer>();
//    //    camera = FindObjectOfType<CameraLook>();

//    //    normal = cam.m_Lens.FieldOfView;

//    //    NoteMessageUI.SetActive(false);

//    //    this.enabled = false;
//    //}

//    //public override void Activate()
//    //{
//    //    this.enabled = true;
//    //    isZoomed = !isZoomed;
//    //    StartCoroutine("DisableScript");
//    //}

//    //IEnumerator DisableScript()
//    //{
//    //    playermovref.GetComponent<Rigidbody>().velocity = Vector3.zero;
//    //    playermovref.enabled = false;
//    //    camera.enabled = false;
//    //    isZoomed = true;

//    //    yield return new WaitForSeconds(1f);
//    //    NoteMessageUI.SetActive(true);
   
//    //    yield return new WaitForSeconds(6f);
//    //    isZoomed = false;
//    //    NoteMessageUI.SetActive(false);

//    //}

//    //void Update()
//    //{
//    //    if (isZoomed)
//    //    {
//    //        Debug.Log("Zoomar");
//    //        cam.m_Lens.FieldOfView = Mathf.Lerp(cam.m_Lens.FieldOfView, zoom, Time.deltaTime * smooth);
//    //    }
//    //    else
//    //    {
//    //        Debug.Log("ZoomarINTE");
//    //        cam.m_Lens.FieldOfView = Mathf.Lerp(cam.m_Lens.FieldOfView, normal, Time.deltaTime * smooth);
//    //        if (Mathf.Approximately(normal, cam.m_Lens.FieldOfView))
//    //        {
//    //            camera.enabled = true;
//    //            playermovref.enabled = true;

//    //            if (door != null)
//    //                door.UnlockDoor();

//    //            this.enabled = false;
//    //        }
//    //    }
//    //}
//}

