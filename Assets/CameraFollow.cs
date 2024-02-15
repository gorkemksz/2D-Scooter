using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset = new Vector3(1.96f, 3.47f, -10);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
