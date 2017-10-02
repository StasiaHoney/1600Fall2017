using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsAssignment : MonoBehaviour {

	// List <string> games = new List<string>{"Bioshock", "Mass Effect"};
	
	// Use this for initialization
	void Start () {
		var array = new []{1,2,3,4,5};
		int sum = 0;

		for ( int i=0; i<array.Length; i++ )
		{
			print(string.Format("arra[{0}]={1}", i, array[i]));
			sum += array[i];
		}

		print(string.Format("sum of all elements in the array is {0}", sum));
		
		
		// foreach (var game in games)
		// {
		//  //Console.WriteLine(game);
		// }

		// int x=1;
		// for( int i=0; i<10; i++)
		// {
		// 	x*=x+i;
		// 	//prime = prime*(prime+1);
		// }

		// int[] array=new[]{1,2,3,4,5};
		// for(int i=0; i<array.Length; i++)
		// {

		// }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
