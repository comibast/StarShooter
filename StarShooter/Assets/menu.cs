using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        //�¦�������:(���a�n���[��)
        //Application.LoadLevel("�U�@�ӳ����W��");
        //Application.LoadLevel(ID);
        //�s��������:(�w���[��,���a���ε�)
        //SceneManager.LoadScene("�U�@�ӳ����W��");
        //SceneManager.LoadScene(ID);
        SceneManager.LoadScene("level");

    }

    public void Quit()
    {
        Application.Quit();
    }
    


}
