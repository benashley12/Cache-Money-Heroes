using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using System.Linq;

public class HighScores : MonoBehaviour {

    public StreamReader inFile;
    public List<string> myList  = new List<string>();
    public SortedDictionary<string, TimeSpan> PlayerName = new SortedDictionary<string, TimeSpan>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SortFile()
    {
        inFile = File.OpenText("highscores.txt");

        
        while(!inFile.EndOfStream)
        (        
            myList.Add(inFile.ReadLine());
        )

        myList.Split(' ');

        inFile.Close();
    }
}
