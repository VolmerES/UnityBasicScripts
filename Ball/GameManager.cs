using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public TMP_Text collectibleNumberText;
    private int collectiblesNumber;

    public TMP_Text TotalCollectibleNumberText;
    private int TotalCollectibleNumber;
    void Start()
    {
        TotalCollectibleNumber = transform.childCount;
        TotalCollectibleNumberText.text = TotalCollectibleNumber.ToString();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    public void AddCollectible()
    {
        audioSource.Play();
        collectiblesNumber++;
        collectibleNumberText.text = collectiblesNumber.ToString();
    }
}
