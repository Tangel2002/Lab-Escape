using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject laserPrefab;
    public Transform shootPos;
    public Vector2 screenPos;
    public Transform eye;
    public AudioSource aud;
    public AudioClip pew;
    void Start()
    {
        
    }

    void Update()
    {
        screenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            Shoot(screenPos);
        }

        Vector2 Direction = new Vector3(screenPos.x, screenPos.y, 0) - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        Quaternion lookRot = Quaternion.AngleAxis(angle, Vector3.forward);
        eye.rotation = Quaternion.Slerp(eye.rotation, lookRot, 20f * Time.deltaTime);


    }


    void Shoot(Vector2 pos)
    {
        aud.clip = pew;
        aud.volume = 0.30f;
        aud.Play();
        GameObject laserClone = (GameObject)Instantiate(laserPrefab, shootPos.position, shootPos.rotation);
        Laser las = laserClone.GetComponent<Laser>();
        //this.gameObject.GetComponent<AudioSource>().Play();
        if (las != null && screenPos != null)
        {
            las.Attack(pos, eye);
        }
    }
}
