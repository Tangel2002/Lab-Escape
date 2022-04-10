using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Collider2D col;
    public ParticleSystem gib;
    GameObject TP;
    ContactFilter2D player;
    bool gibbed = false;

    private void Start()
    {
        TP = GameObject.FindGameObjectWithTag("Spawn");
        player.SetLayerMask(LayerMask.GetMask("Player"));
    }
    private void Update()
    {
        if(col.IsTouching(player) && !gibbed)
        {
            Instantiate(gib, col.transform);
            Teleport();
        }
    }

    void Teleport()
    {
        gibbed = true;
        GameObject play = GameObject.FindGameObjectWithTag("Player");
        play.transform.position = TP.transform.position;
    }
}
