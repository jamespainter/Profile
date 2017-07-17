import java.util.Scanner;
public class Palindrome 
{

  public static void main(String[] args) 
  {
		
		if(args.length == 0)
		{
			Scanner reader = new Scanner(System.in);
			System.out.println("Please enter a potential palindrome:");
			String read = reader.nextLine(); 
			String first = "";
			String second = "";
			
			for (int j = 0; j < read.length(); j++)
			{
				if(read.charAt(j)!= ' ')
					first += read.charAt(j);
			}
			for (int i = read.length()-1; i >=0; i--)
			{	
				if(read.charAt(i)!= ' ')
					second +=  read.charAt(i); 
			}
			if(first.equalsIgnoreCase(second))
				System.out.println(read + " is a valid Palindrome");
			else
				System.out.println(read + " is not a valid Palindrome");
			
		}
		
		if(args.length>0)
		{
			int count =0; 
			String first = "";
			String second = "";
			String valid = "Is a valid Palindrome!";
			String nValid ="Is not a valid Palindrome!";
					
			for(int i = 0; i < args.length; i++)
			{
				first += args[i];
			}
			String s = first;
			for(int j = first.length()-1; j >= 0; j--)
			{
				second += first.charAt(j);
			}
			if(s.equalsIgnoreCase(second))
			{
				// top border
				for(String i: args)
					count += i.length();
				count += args.length -1 + valid.length();
				System.out.print("+");
				for(int k = 0; k < count; k++)
				{
					System.out.print("-");
				}
				System.out.println("+");
				
				//Palindrome Print Statement
				System.out.print("|");
				for(int k = 0; k < args.length; k++)
					System.out.print(args[k]+ " "); 
				System.out.println(valid);
				
				// bottom border
				System.out.print("+");
				for(int k = 0; k < count; k++)
				{
					System.out.print("-");
				}
				System.out.println("+");
				
			}	
			else
			{
				// top border
				for(String i: args)
					count += i.length();
				count += args.length -1 + nValid.length();
				System.out.print("+");
				for(int k = 0; k < count; k++)
				{
					System.out.print("-");
				}
				System.out.println("+");
				
				//Palindrome Print Statement
				System.out.print("|");
				for(int k = 0; k < args.length; k++)
					System.out.print(args[k]+ " "); 
				System.out.println(nValid);
				
				// bottom border
				System.out.print("+");
				for(int k = 0; k < count; k++)
				{
					System.out.print("-");
				}
				System.out.println("+");
			}
		}
		System.exit(1);
		
  }
	
		
}
