using UnityEngine;

public class PowerupManager : MonoBehaviour
{   
   [SerializeField] PowerupSO powerup;
   PlayerController player;
   SpriteRenderer spriteRenderer;
   float timeLeft;
   void Start()
   { 
          player = FindFirstObjectByType<PlayerController>();
          spriteRenderer = GetComponent<SpriteRenderer>();
          timeLeft = powerup.GetTime();
   }
   void Update()
   {
    CountdownTimer();
   }
   void CountdownTimer()
{
    if (spriteRenderer.enabled == false)
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            player.DeactivatePowerup(powerup);
            spriteRenderer.enabled = true;     // tekrar alınabilsin
            timeLeft = powerup.GetTime();      // süreyi sıfırla
        }
    }
}
void OnTriggerEnter2D(Collider2D collision)
{
    int layerIndex = LayerMask.NameToLayer("Player");

    if (collision.gameObject.layer == layerIndex && spriteRenderer.enabled)
        {
            player = collision.GetComponentInParent<PlayerController>();
            if (player == null) return; // güvenlik

            spriteRenderer.enabled = false;
            player.ActivatePowerup(powerup); // Deactivate değil, Activate
            timeLeft = powerup.GetTime();
        }
    }   
}