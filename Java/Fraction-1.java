
public class Fraction {
	private int numerator; 
	private int denominator; 
	
	public Fraction(int numerator, int denominator)
	{
		this.numerator = numerator; 
		this.denominator = denominator;
		
		int divisor = gcd(numerator, denominator);
		
		this.numerator /= divisor ; 
		this.denominator /= divisor; 
		
		// Euclid's Algorithm for finding the greatest common divisor
		
	}
	
	public Fraction(int numerator)
	{
		Fraction F1; 
		this.denominator = 1;
		int fraction = numerator/this.denominator; 
		
	}
	
	Fraction add(Fraction right)
	{
		Fraction F1; 
		
		if (this.denominator == right.denominator)
			F1 = new Fraction(this.numerator + right.numerator, this.denominator);
		else
		{
			int den = this.denominator * right.denominator;
			int num = (this.numerator * right.denominator) + (right.numerator * this.denominator);
			F1 = new Fraction(num, den);
		}
		return F1; 
	}
	
	Fraction sub(Fraction right)
	{
		Fraction F1; 
		
		if (this.denominator == right.denominator)
			F1 = new Fraction(this.numerator - right.numerator, this.denominator);
		else
		{
			int den = this.denominator * right.denominator;
			int num = (this.numerator * right.denominator) - (right.numerator * this.denominator);
			F1 = new Fraction(num, den);
		}
		return F1;
	}
	
	Fraction mult(Fraction right)
	{
		Fraction F1; 
		int num = this.numerator * right.numerator;
		int den = this.denominator * right.denominator; 
		F1 = new Fraction(num, den); 
		
		return F1; 
	}
	
	Fraction div(Fraction right)
	{
		Fraction F1; 
		
		int num = this.numerator * right.denominator;
		int den = this.denominator * right.numerator; 
		 
		
		F1 = new Fraction(num, den); 
		
		return F1; 
	}
	
	public String toString() // could be tested on programming test, pg 198
	{
		return numerator + "/" + denominator; 
	}
	
	public boolean equals(Object otherObject)		// step 1 
	{
		if (this == otherObject)
			return true; 							// step 2
		
		if (otherObject == null)
			return false; 							// step 3
		
		//if (! (otherObject instanceof Time1))		// step 4.b
			//	return false; 
		if(getClass() != otherObject.getClass())	// step 4.a
			return false;  
		
		
		Fraction 	other =  (Fraction)otherObject; 		// step 5
		
		// step 6
		
		return numerator == other.numerator && denominator == other.denominator;
		
		
	}
	
	private int gcd(int u, int v)
	{
		u = (u < 0) ? -u : u; // make u non-negative
		v = (v < 0) ? -v : v; // make v non-negative
		while (u > 0)
		{
			if (u < v)
			{
				int t = u; // swap u and v
				u = v;
				v = t;
			}
			u -= v;
		}
		return v; // the GCD of u and v
		
	}
/*	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Fraction F1 = new Fraction(3,6);
		Fraction F2 =new Fraction(3,5); 
		Fraction F3; 
		
		
		F3 = F1.add(F2);
		System.out.println(F3);
		F3 = F1.sub(F2);
		System.out.println(F3);
		F3 = F1.mult(F2);
		System.out.println(F3);
		F3 = F1.div(F2);
		System.out.println(F3);
	}
*/
}
