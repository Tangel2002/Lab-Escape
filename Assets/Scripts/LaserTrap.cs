using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    ContactFilter2D contactFilter;
    public Collider2D laserCol;
    public CircuitBox power;
    GameObject TP;
    private void Start()
    {
        contactFilter.SetLayerMask(LayerMask.GetMask("Player"));
        TP = GameObject.FindGameObjectWithTag("Spawn");
    }
    void Update()
    {
        if (laserCol.IsTouching(contactFilter))
        {
            Teleport();
        }
        if (!power.checkStatus())
        {
            laserCol.gameObject.SetActive(false);
        }
    }

    void Teleport()
    {
        GameObject play = GameObject.FindGameObjectWithTag("Player");
        play.transform.position = TP.transform.position;
    }
}
