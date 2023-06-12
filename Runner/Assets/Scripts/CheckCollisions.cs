using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCollisions : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();

            other.gameObject.SetActive(false);
        }
    }

    void AddCoin()
    {
        score++;
        coinText.text = "Score: " + score;
    }

}
