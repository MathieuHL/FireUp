using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    
    void Update()
    {
        transform.position = new Vector3(0, _player.transform.position.y, -10);
    }
}
