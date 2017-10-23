using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthbar;
    public Text ratioText;

    private float health = 100;
    private float max_health = 100;

    float timer = 3;
    void OnCollisionEnter(Collision hit)
    {
        if (hit.collider.tag == "Enemy")
        {
            TakeDamge(10);
        }

        if(hit.collider.tag == "Health")
        {
            HealDamage(10);
        }
    }

    void UpdateHealthBar()
    {
        float ratio = health / max_health;

        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString() + '%';
    }

    private void TakeDamge(float damage)
    {
        health -= damage;

        if (health < 0)
            health = 100; // set health back to 100 if the player dies

        UpdateHealthBar();
    }

    private void HealDamage(float heal)
    {
        health += heal;

        if (health > 100)
            health = max_health;

        UpdateHealthBar();
    }
}
