using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("��������� �������")]
    [SerializeField] private TextMeshProUGUI timerText; // ������ �� ��������� �������
    [SerializeField] private float lifeTime = 132f; // ����������� 30 ������

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
        // ���������� ������ ����� �������
        timerText.text = Mathf.CeilToInt(remainingTime).ToString();
    }

    private void EndGame()
    {
        isGameActive = false;
        Debug.Log("����� �����! ���� �����������.");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}