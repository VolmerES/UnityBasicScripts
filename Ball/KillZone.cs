using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("El player entro en la killzone");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
