import java.io.*;
import java.util.Scanner;

public class Pattern
{
	// Function print pattern
	public static void printPattern(int n)
	{
		// outer loop to handle number of rows
		for (int i=0; i<n; i++)
		{

			// inner loop to handle number spaces
			for (int j=n-i; j>1; j--)
			{
				// printing spaces
				System.out.print(" ");
			}

			// inner loop to handle number of columns
			for (int j=0; j<=i; j++ )
			{
				// printing stars
				System.out.print("#");
			}

			// ending line after each row
			System.out.println();
		}
	}
	
	public static void main(String args[])
	{
		Scanner in = new Scanner(System.in);
		int num=0;
		boolean err = true;
		
		System.out.print("Please input number 0 - 100 : ");
		//Validation number only 0 - 100
		while (err == true){
			try {
				num = in.nextInt();
				if(num<0 || num>100) {
					System.out.println("Input must be number greater than 0 and less than 100");
					System.out.println();
					System.out.print("Please input number 0 - 100 : ");
				} else {
					err = false;
				}
			} catch (Exception e) {
				System.out.println("Input must be number, no char and no symbol");
				System.out.println();
				System.out.print("Please input number 0 - 100 : ");
				in.nextLine();
			}
		}
		
		printPattern(num);
	}
}
