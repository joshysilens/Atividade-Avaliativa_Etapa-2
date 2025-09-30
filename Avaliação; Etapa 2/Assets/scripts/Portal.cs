using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string Fase2;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && Fase2 != "")
        {
            SceneManager.LoadScene(Fase2);          
        }
    }
}