using UnityEngine;
using UnityEngine.UI;
public class HpBar : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    [SerializeField] private Image healthBar; // —сылка на Image дл€ полоски HP

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = (float)currentHealth / maxHealth;
    }

}
