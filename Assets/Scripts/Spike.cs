using UnityEngine;

public class Spike : MonoBehaviour
{
    public Collider2D col;
    public ParticleSystem gib;
    GameObject TP;
    ContactFilter2D player;
    bool gibbed = false;
    float cooldown = 1;

    private void Start()
    {
        TP = GameObject.FindGameObjectWithTag("Spawn");
        player.SetLayerMask(LayerMask.GetMask("Player"));
    }
    private void Update()
    {
        if(gibbed == true)
        {
            cooldown -= 1 * Time.deltaTime;
        }
        if(cooldown <= 0)
        {
            gibbed = false;
            cooldown = 1;
        }
        if(col.IsTouching(player) && !gibbed)
        {
            gibbed = true;
            Instantiate(gib, col.transform);
            Teleport();
        }
    }

    void Teleport()
    {
        GameObject play = GameObject.FindGameObjectWithTag("Player");
        play.transform.position = TP.transform.position;
    }
}
