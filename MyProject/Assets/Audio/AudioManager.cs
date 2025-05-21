using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("��������� ������")]
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField][Range(0, 1)] private float volume = 0.1f;
    [SerializeField] private bool loopMusic = true;

    private AudioSource audioSource;

    private void Awake()
    {
        // ������� � ����������� AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.volume = volume;
        audioSource.loop = loopMusic;

        // ������ ������ �������������� ��� �������� ����� ����
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // ��������� ������ ��� ������ ����
        audioSource.Play();
    }
}
