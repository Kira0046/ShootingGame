using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] enemy;

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemy.Length == 0)
        {
            panel.SetActive(true);
        }
    }
}