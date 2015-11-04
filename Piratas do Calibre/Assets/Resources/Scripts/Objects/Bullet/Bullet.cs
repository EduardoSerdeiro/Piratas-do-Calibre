using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private float maxSegLife = 3.0f;

    // private float Life;
    private Rigidbody rigidbody;

	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {

        rigidbody.velocity = transform.forward * speed;
        Destroy(this.gameObject, maxSegLife);
	}

   
}
