using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LighterUIManager : MonoBehaviour
{

    [SerializeField] private GameObject lightAcquired;
    [SerializeField] private GameObject qToActivate;
    public bool canDeactivate;

    private void Awake()
    {
        lightAcquired.SetActive(false);
        qToActivate.SetActive(false);
    }

    public void lighthAcquiredState(bool canShow)
    {
        if (canShow)
            lightAcquired.SetActive(true);
        else
            lightAcquired.SetActive(false);
    }

    public void qToActivateState(bool canShow)
    {
        if (canShow)
            qToActivate.SetActive(true);
        else
            qToActivate.SetActive(false);
    }

}
