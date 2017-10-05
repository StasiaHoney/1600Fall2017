using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsAssignment : MonoBehaviour {
	
	void Start () {
		var array = new []{1,2,3,4,5};
		int sum = 0;

		for ( int i=0; i<array.Length; i++ ) //takes a list or array and some perameters you set to output stuff...
		{
			print(string.Format("array [{0}]={1}", i, array[i])); // this prints every array element as well as it's element #
			sum += array[i]; //adds all elements together
		}

		print(string.Format("sum of all elements in the array is {0}", sum)); //prints sum of elements
		
		var myAge = new []{18,19,20,21,22,23};
		
		for( int age = 18; age<myAge.Length; age += 4)
		{
			print(string.Format("My age is {0}", age));
		}
		
		int x=1;
		for( int i=0; i<10; i++)//can also use ints in for loops
		{
			x = x*(x+1);
			print(string.Format("value of x is {0}", x));
		}

		for (float f = 1.0f ; f < 2.0f; f += 0.3f)
		{
			print(string.Format("Float number is {0}", f));
		}

		float sumf = 5.6f;
		for( float f = 5.6f ; f>= 4.2; f -= 0.1f){
			print(string.Format("Float Subtraction is {0}", f));
			sumf += f;
		}
		print(string.Format("sum of float f is {0}", sumf));

		for(int i = 4; i <= 0; i-= 1 ){
			print(string.Format("int subtraction is {0}", i));
		}

		for(float f = 110.7f; f < 120.5; f++){
			print(string.Format("float is {0}", f));
		}

		for(double d = 1.1D; d < 1.4; d += .001D){
			print(string.Format("double d is {0}", d));
		}

		for(float f = .1f; f>.001; f*=.1f){
			print(string.Format("float mult is {0}", f));
		}

		for(double d = .1D ; d<100D; d/= .1D ){
			print(string.Format("double div is {0}", d));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
