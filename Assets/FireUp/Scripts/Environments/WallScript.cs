using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, _player.transform.position.y, transform.position.z);
    }
}
