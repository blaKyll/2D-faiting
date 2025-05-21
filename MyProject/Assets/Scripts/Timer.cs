using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Настройки таймера")]
    [SerializeField] private TextMeshProUGUI timerText; // Ссылка на текстовый элемент
    [SerializeField] private float lifeTime = 132f; // Установлено 30 секунд

    private float remainingTime;
    private bool isGameActive = true;

    private void Start()
    {
        remainingTime = lifeTime;
        UpdateTimerDisplay();
    }

    private void Update()
    {
        if (!isGameActive || timerText == null) return;

        remainingTime -= Time.deltaTime;
        UpdateTimerDisplay();

        if (remainingTime <= 0f)
        {
            remainingTime = 0f;
            EndGame();
        }
    }

    private void UpdateTimerDisplay()
    {
        // Отображаем только целые секунды
        timerText.text = Mathf.CeilToInt(remainingTime).ToString();
    }

    private void EndGame()
    {
        isGameActive = false;
        Debug.Log("Время вышло! Игра завершается.");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}