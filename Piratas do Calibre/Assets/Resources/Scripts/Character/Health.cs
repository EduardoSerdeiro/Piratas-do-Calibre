using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{

    [SerializeField]
    private float maxHealth;

    private static float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {



    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }

    }

    public float GetCurrHealth()
    {
        return currentHealth;
    }

}
