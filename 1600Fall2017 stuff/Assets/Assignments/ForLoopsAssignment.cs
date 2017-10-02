using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsAssignment : MonoBehaviour {
	
	void Start () {
		var array = new []{1,2,3,4,5};
		int sum = 0;

		for ( int i=0; i<array.Length; i++ )
		{
			print(string.Format("array [{0}]={1}", i, array[i]));
			sum += array[i];
		}

		print(string.Format("sum of all elements in the array is {0}", sum));
		
		var myAge = new []{18,19,20,21,22,23};
		int age = 18;
		
		for( int i = 18; i<myAge.Length; i+= 4)
		{
			print(string.Format("My age is {0}", age));
		}
		
		int x=1;
		for( int i=0; i<10; i++)
		{
			x = x*(x+1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
