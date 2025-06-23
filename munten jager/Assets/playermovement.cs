using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Maak de snelheid van de speler aanpasbaar in de inspector

    public ScoreManager scoreManager; // Zorg dat je een referentie naar je score-script kunt ontvangen

    void Start()
    {
        // Controleer of er een referentie naar je score-script is meegegeven
        if (scoreManager == null)
        {
            // Debug het met een eigen error

        }
    }

    void Update()
    {
        // Beweeg de speler links en rechts met pijltjestoetsen of A,D, gebruik de aanpasbare snelheid
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 move = new Vector3(moveX, 0f, 0f);
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check of het een munt is
        if (other.name == "Coin")
        {
            // Roep de AddScore methode van je score-script aan en geef 10 punten mee
            scoreManager.AddScore(10);

            // Geef in de console een bericht dat je een munt hebt gepakt!
            Debug.Log("Munt gepakt!");

            // Vernietig de munt
            Destroy(other.gameObject);
        }
    }
}