using UnityEngine;
using Unity.Cinemachine;   // Eski Cinemachine 2.x ise: using Cinemachine;

public class CharSelectManager : MonoBehaviour
{
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] GameObject dinoSprite;
    [SerializeField] GameObject frogSprite;
    [SerializeField] CinemachineCamera followCamera;   // 2.x ise: CinemachineVirtualCamera

    void Start()
    {
        Time.timeScale = 0;
    }

    void BeginGame(GameObject chosenCharacter)
    {
        chosenCharacter.SetActive(true);
        followCamera.Follow = chosenCharacter.transform;

        Time.timeScale = 1f;
        scoreCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ChooseDino()
    {
        BeginGame(dinoSprite);
    }

    public void ChooseFrog()
    {
        BeginGame(frogSprite);
    }
}
