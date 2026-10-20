using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", restartDelay);
            finishEffect.Play();
        }
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
