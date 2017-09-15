using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathoperatorsassignment : MonoBehaviour {
	public float num1;
	public float num2;
	public float num3;

	public float addResult;
	public float subResult;
	public float multResult;
	public float divdResult;
	public float remainderResult;
	public float multnumaddResult;
	public float multnumsubResult;
	public float multnumdivdResult;
	public float multremainderResult;
	public float addaddResult;
	public float subsubResult;
	// Update is called once per frame
	void Update () {
		addResult = num1 + num2; // adding two num
		subResult = num1 - num2; // subtracting two num
		multResult = num1 * num2; //mult two num
		if(num1 != 0 && num2 != 0){ //()part for cannot equal 0
			divdResult = num1 / num2; // divide two num
		} else {
			print("Can't Divide By 0.");
		}
		remainderResult = num1 % num2; //gives us a remainder
		
		multnumaddResult = num1 + num3 * num2;
		multnumsubResult = num3 - num2 - num1;
		if(num1 != 0 && num2 != 0 && num3 !=0){
			multnumdivdResult = num1 / num3 / num2;
		} else {
			print("Can't Divide By 0.");
		}
		multremainderResult = num1 % num3 % num2;
		addaddResult = addResult + multResult;
		subsubResult = subResult - multnumsubResult;
	}
}
