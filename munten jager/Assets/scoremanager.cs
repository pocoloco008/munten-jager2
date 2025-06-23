using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Zorg voor een logische startscore; deze is aanpasbaar in de Inspector
    [SerializeField] private int score = 0;

    // Zorg dat de methode AddScore vanaf een ander script ook punten kan doorgeven als argument
    public void AddScore(int points)
    {
        // Tel de meegegeven punten op bij de score
        score += points;

        // Debug de score naar de console
        Debug.Log("Score bijgewerkt: " + score);
    }
}