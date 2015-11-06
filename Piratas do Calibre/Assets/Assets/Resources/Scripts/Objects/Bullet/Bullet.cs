using UnityEngine;
using System.Collections;


public class Bullet : MonoBehaviour
{
    Health health;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float maxSegLife = 3.0f;

    public static int damageBullet = 50;
    // private float Life;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        rigidbody.velocity = transform.forward * speed;
        Destroy(this.gameObject, maxSegLife);
    }



}
