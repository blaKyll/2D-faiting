using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Настройки музыки")]
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField][Range(0, 1)] private float volume = 0.1f;
    [SerializeField] private bool loopMusic = true;

    private AudioSource audioSource;

    private void Awake()
    {
        // Создаем и настраиваем AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.volume = volume;
        audioSource.loop = loopMusic;

        // Делаем объект неуничтожаемым при загрузке новых сцен
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Запускаем музыку при старте игры
        audioSource.Play();
    }
}
