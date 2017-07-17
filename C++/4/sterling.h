struct sterling
{
	int	pounds;
	int	shillings;
	int pence;
};


sterling	make_sterling(int pounds, int shillings, int pence);

sterling	make_sterling(int pence);

void print(sterling& );			// pass by reference

sterling	add(sterling t1, sterling t2);			// pass by value

void	read(sterling* );					// pass by pointer

