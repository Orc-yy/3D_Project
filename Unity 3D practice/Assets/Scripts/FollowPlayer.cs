using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(20, 1, 0);
    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
