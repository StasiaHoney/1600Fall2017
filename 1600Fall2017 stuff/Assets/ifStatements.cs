using UnityEngine;
using UnityEngine.UI;
public class ifStatements : MonoBehaviour { 
 
  public Text input;  
  private string password = "Evan_Hansen"; 
    
  public int num1 = (7); 
  public int num2 = (10); 
  public int value = (70); 
 
	public bool canPlay; 
	
	public int num3; 
	public int num4; 
	public int value2; 
	
	public bool canMurder; 
	
	public int myage; 
	public int momsAge; 
	public int papasAge; 
	public int KatsAge; 
	
	public bool Klance; 
	public bool Shiro; 
  	void Start() 
	{ 
			if (num1*num2 == 70) 
			{ 
			print(70); 
			}   
		
			if (input.text == password) 
			{ 
			print("You know the password"); 
			print("Correct Password"); 
			} 
		
			if (canPlay == true) 
			{ 
			print("Play"); 
			} 
		
			if (num3+num4 == value2) 
			{ 
			print(value2); 
			} 
		
			if (canMurder == true) 
			{ 
			print("Murdered"); 
			} 
		
			if (myage == 18) 
			{ 
			print("Adulting"); 
			} 
		
			if (momsAge - papasAge == 6){ 
			print("Far Apart"); 
			} 
		
			if (myage - KatsAge == 3){ 
			print("million worlds apart"); 
			} 
		
			if (momsAge - myage == 30){ 
			print("Old"); 
			} 
		
			if (Klance == true){ 
			print("<3"); 
			} 
		
			if (Klance == false){ 
			print("T-T"); 
			} 
		
			if (Shiro == true){ 
			print("Champion"); 
			} 
	
			if (Shiro == false){ 
			print("Finally Died"); 
			} 
 	 } 
   
}