using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float maxStamina;

    private float currentHealth;
    private float currentStamina;

    public HealthBar healthBar;
    public StaminaBar staminaBar;
    public GameOver gameover;
    public bool attaked = false;
    public float cooldown, time;

    private void Start()
    {
        cooldown = 0.5f;
        time = 0.5f;

        currentHealth = maxHealth;
        currentStamina = maxStamina;

        healthBar.SetSliderMax(maxHealth);
        staminaBar.SetSliderMax(maxStamina);
    }

    void Update()
    {
        cooldown -= Time.deltaTime;
        if (attaked && cooldown <= 0)
        {
            TakeDamage(5);
            cooldown = time;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            attaked = true;
        }
        else
        {
            attaked = false;
        }
    }

    private void LateUpdate()
    {

        if (currentHealth == 0)
        {
            gameover.Setup();
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    private void UseStamina(float amount)
    {
        currentStamina -= amount * Time.deltaTime;
        staminaBar.SetSlider(currentHealth);
    }
}
