using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] EventChannelSO onPlayerDeath;
    [SerializeField] IntDataSO scoreData;
    [SerializeField] TextMeshProUGUI scoreText;

    private PlayerCharacter player;

    private void Update()
    {
        scoreText.text = "Score: " + player.scoreData.Value.ToString();
    }

    private void Start()
    {
        player = FindObjectOfType<PlayerCharacter>();
        onPlayerDeath.AddListener(OnPlayDeath);
    }

    public void OnPlayDeath()
    {
        print("Player has died.");
    }
}
