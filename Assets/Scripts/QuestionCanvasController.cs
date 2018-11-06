using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCanvasController : MonoBehaviour
{

    // Use this for initialization
    GameObject sender;
    List<string> solutions = new List<string>(1);
    public Text QuestionText;
    public Text solutionText;
    public InputField solutionField;
    public InputField InputField;


    void Start()
    {
        this.gameObject.SetActive(false);
        solutionText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void checkSolution_Click()
    {
        if (solutionField.text.Trim() != "" && solutions.Contains(solutionField.text.Trim()))
        {
            setFalseSolution(false);
            this.gameObject.SetActive(false);
            sender.GetComponent<PressurePlateController>().recieveSolution(true);
            solutionField.text = "";
        }
        else
        {
            setFalseSolution(true);
        }
    }

    public void cancelSolution_Click()
    {
        setFalseSolution(false);
        this.gameObject.SetActive(false);
        solutionField.text = "";
        sender.GetComponent<PressurePlateController>().recieveSolution(false);
    }

    public void makeVisible(GameObject sender, string question, List<string> solutions)
    {
        this.gameObject.SetActive(true);
        this.sender = sender;
        this.solutions = solutions;
        QuestionText.text = question;
        setFalseSolution(false);
    }

    private void setFalseSolution(bool visible = true)
    {
        if (visible)
        {
            solutionText.text = "Die Lösung ist falsch, probiere es noch einmal mit einer anderen Lösung!";
            return;
        }
        solutionText.text = "";
    }

    

    void OnGUI()
    {
        if (solutionField.isFocused && solutionField.text != "" && Input.GetKey(KeyCode.Return))
        {
            checkSolution_Click();
            solutionField.text = "";
        }
    }

}
