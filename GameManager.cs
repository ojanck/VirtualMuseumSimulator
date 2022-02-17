using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 0f;
    //public Text point;
    //[SerializeField] float nilai = 0f;

    public void Setup()
    {
        //float masuknilai = FindObjectOfType<DapetKacaPecah>().pecahh;
        //nilai = masuknilai;
        gameObject.SetActive(true);
        //point.text = "Anda telah memecahkan: " + nilai.ToString() + " kaca pelindung";
    }

    //public void GameOver()
    //{
    //    if (GameHasEnded == false)
    //    {
    //        GameHasEnded = true;
    //        Debug.Log("GameOver");
    //        Invoke("Restart", RestartDelay);
    //    }
    //}

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
