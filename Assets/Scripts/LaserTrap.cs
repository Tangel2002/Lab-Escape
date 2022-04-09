using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    ContactFilter2D contactFilter;
    public Collider2D laserCol;
    public CircuitBox power;
    private void Start()
    {
        contactFilter.SetLayerMask(LayerMask.GetMask("Player"));
    }
    void Update()
    {
        if (laserCol.IsTouching(contactFilter))
        {
        }
        if (power.checkStatus())
        {
            laserCol.gameObject.SetActive(false);
        }
    }
}
