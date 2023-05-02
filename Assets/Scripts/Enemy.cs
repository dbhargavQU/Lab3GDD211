using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            Move(direction.x, direction.z);
        }
    }
}
