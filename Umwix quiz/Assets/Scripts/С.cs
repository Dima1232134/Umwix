using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class С : MonoBehaviour
{
    public GameObject headPanel;
    public GameObject headPanel2;
    public GameObject headPanel3;
    public GameObject headPanel4;
    public GameObject headPanel5;
    public GameObject headPanel6;
    public GameObject headPanel7;
    public GameObject Help1;
    public GameObject Help2;
    public GameObject Start;
    public GameObject Wrong;
    public GameObject Right;

    public void OnClickPlay()
    {
        if (!headPanel.GetComponent<Animator>().enabled) headPanel.GetComponent<Animator>().enabled = true;
        else headPanel.GetComponent<Animator>().SetTrigger("In");
    }

    public void OnClickPlay2()
    {
        if (!headPanel2.GetComponent<Animator>().enabled) headPanel2.GetComponent<Animator>().enabled = true;
        else headPanel2.GetComponent<Animator>().SetTrigger("In2");
    }

    public void Settings()
    {
        if (!headPanel3.GetComponent<Animator>().enabled) headPanel3.GetComponent<Animator>().enabled = true;
        else headPanel3.GetComponent<Animator>().SetTrigger("In3");
    }
    public void Settings1()
    {
        if (!headPanel4.GetComponent<Animator>().enabled) headPanel4.GetComponent<Animator>().enabled = true;
        else headPanel4.GetComponent<Animator>().SetTrigger("In4");
    }
    public void S()
    {
        if (!Help1.GetComponent<Animator>().enabled) Help1.GetComponent<Animator>().enabled = true;
        else Help1.GetComponent<Animator>().SetTrigger("Help1");
    }
    public void S2()
    {
        if (!Help2.GetComponent<Animator>().enabled) Help2.GetComponent<Animator>().enabled = true;
        else Help2.GetComponent<Animator>().SetTrigger("Help2");
    }
    public void start()
    {
        if (!Start.GetComponent<Animator>().enabled) Start.GetComponent<Animator>().enabled = true;
        else Start.GetComponent<Animator>().SetTrigger("start");
    }

    public void right()
    {
        if (!Right.GetComponent<Animator>().enabled) Right.GetComponent<Animator>().enabled = true;
        else Right.GetComponent<Animator>().SetTrigger("Right");
    }

    public void wrong()
    {
        if (!Wrong.GetComponent<Animator>().enabled) Wrong.GetComponent<Animator>().enabled = true;
        else Wrong.GetComponent<Animator>().SetTrigger("Wrong");
    }

    public void ChelVK()
    {
        Application.OpenURL("https://vk.com/public199836935");
    }

    public void Chelfacebook()
    {
        Application.OpenURL("https://www.facebook.com/groups/264379385645750");
    }
    public void ChelTwitter()
    {
        Application.OpenURL("");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    public void NextScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void PrevScene()
    {
        SceneManager.LoadScene(0);
    }
}
