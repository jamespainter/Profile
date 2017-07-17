

class fraction
{
	private: 
		int numerator;
		int denominator;

	public:
	
	fraction(int n = 0, int d = 1) : numerator(n), denominator(d){}

	fraction add(fraction curval);
	fraction sub(fraction curval);
	fraction mult(fraction curval);
	fraction div(fraction curval);
	void print();
	void read();
	

};

//inline fraction :: fraction(int n, int d)
//{
//	numerator = n; 
//	denominator = d;
//}