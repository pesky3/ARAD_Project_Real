using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lectern : MonoBehaviour
{
    public GameObject uiPanel;
    public Transform arCamera;
    public float activationDistance = 2f;

    void Update()
    {
        if (arCamera == null) return;

        float distance = Vector3.Distance(transform.position, arCamera.position);

        if(distance < activationDistance)
        {
            uiPanel.SetActive(true);
        }
        else
        {
            uiPanel.SetActive(false);
        }
    }
}


