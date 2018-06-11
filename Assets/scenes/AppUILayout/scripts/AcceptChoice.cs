using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AcceptChoice : MonoBehaviour {

    public bool overMouse;
  //  List<int> statement = new List<int>();
    int currentStatement;
  //  int currentChar;
  //  int character;

    //private var wave1 : List.<String> = new List.<String>();
   // private int waveArray = List.< List.< String > > = new List.< List.< String > > ();

    [SerializeField] List<int> statement = new List<int>();
    [SerializeField] List<int> character = new List<int>();
    [SerializeField] List<int> answers = new List<int>();
    //  List<List<int>> character = new List<List<int>>();
    //List<List<int>> statement = new List<List<int>>();
    //public float[] statement;
    //public float[] statementPoints;

    // Use this for initialization
    void Start ()
    {

        int indexChar = character.IndexOf(120);
       // List.IndexOf(character);


        statement.Add(1);
        statement.Add(2);
        statement.Add(3);
        statement.Add(4);
        statement.Add(5);
        statement.Add(6);
        statement.Add(7);
        statement.Add(8);
        statement.Add(9);
        statement.Add(10);
        statement.Add(11);
        statement.Add(12);
        statement.Add(13);
        statement.Add(14);
        statement.Add(15);
        statement.Add(16);
        statement.Add(17);
        statement.Add(18);
        statement.Add(19);
        statement.Add(20);

        foreach (int o in statement)
        {
            for (int i = 0; i < 6; i++)
            {
                character.Add(i);
            }
        }

        foreach (int p in character)
        {
            for (int i = 0; i < 4; i++)
            {
                answers.Add(i);
            }
        }
            currentStatement = 1;
        // xml, 
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void TaskOnClick()
    {
        print("op knop geklikt");
        //check which square
        currentStatement++;
        // kijk welke catagorie is geklikt
        // sla de punten op
        // ga naar de volgende stelling
    }

    void OnMouseOver()
    {
        overMouse = true;
    }

    private void OnMouseExit()
    {
        overMouse = false;
    }
}
