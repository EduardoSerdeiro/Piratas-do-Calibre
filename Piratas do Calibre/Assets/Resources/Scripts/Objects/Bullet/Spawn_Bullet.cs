using UnityEngine;
using System.Collections;

public class Spawn_Bullet : MonoBehaviour {

    [SerializeField]private GameObject bulletPrefab;

    [SerializeField]
    private float cooldown;
 

    [Header("Arma")]
    [SerializeField]private int QuantiMuni;
    [SerializeField]private int muniArma = 1;

    private float timeCurrShoot;

	void Start () {
        timeCurrShoot = cooldown;
	}
	
	void FixedUpdate () {

        timeCurrShoot += Time.fixedDeltaTime;

        if (Input.GetButtonDown("Fire1") && timeCurrShoot >= cooldown && muniArma > 0)
        {
            Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
            timeCurrShoot = 0;
            muniArma--;
        }

        if (Input.GetKeyDown(KeyCode.R) && QuantiMuni>0 && muniArma< 1)
        {
            muniArma++;
            QuantiMuni--;
        }

	}
}
