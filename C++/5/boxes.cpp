#include <iostream>
#include <string>
#include <cstring>
const unsigned char VERT = 179;
const unsigned char HORZ = 196;
const unsigned char DOT = 254;
using namespace std;


void init_board(char unsigned board[][11]);
void display(char unsigned board[][11]);
void get_move(char player, int& row, int& col, char unsigned board[][11], int countX, int countO);
int claim_box(char player, int row, int col, char unsigned board[][11]);
void check_winner(int countX, int countO);



int main()
{
	
	char player = 'X';
	int moves = 44;
	char unsigned board[11][11];
	int countX=0;
	int countO=0;
	init_board(board);
	display(board);
	
	while (moves > 0)
	{
		int row;
		int col;
		moves--;
		player = (player == 'X') ? 'O' : 'X';
		get_move(player, row, col, board,countX, countO);
		check_winner(countX, countO);
	}
	


	return 0;
}

void init_board(char unsigned board[][11])
{
	for (int i = 0; i < 11; i++)
	{
		for (int j = 0; j < 11; j++)
		{
			board[i][j] = ' ';
		}
	}   

	for (int i = 0; i < 11; i += 2)
	{
		for (int j = 0; j < 11; j += 2)
		{
			board[i][j] = DOT;
		}
	}

}

void display(char unsigned board[][11])
{
	system("cls");
	
	cout << "  ";
	for (int i = 0; i < 11; i++)
	{
		cout <<' '<< i;
	}
	cout << endl;
	
	for (int i = 0; i < 11; i++)
	{
		cout <<' '<< i;
		for (int j = 0; j < 11; j++)
		{
			 
			cout <<' '<< board[i][j];
		}
		cout << endl; 
	}

}

void get_move(char player, int& row, int& col, char unsigned board[][11], int countX, int countO)
{
	
	
	int curCount = 0;

	do
	{
		cout << "Move for player: " << player << endl;
		cout << "Row: ";
		cin >> row;

		cout << "Col: ";
		cin >> col;

		if (row == -1 && col == -1)
			exit(0);

		if (row % 2)
		{
			
			board[row][col] = VERT;
			curCount = claim_box(player, row, col, board);

			if (player == 'X')
			{
				countX = countX + curCount;
			}
			else
			{
				countO = countO + curCount;
			}
			display(board);
			

		}
		else
		{
			board[row][col] = HORZ;
			curCount = claim_box(player, row, col, board);
			if (player == 'X')
			{
				countX = countX + curCount;
			}
			else
			{
				countO = countO + curCount;
			}
			display(board);
		}

		player = (player == 'X') ? 'O' : 'X';
	} while (board[row][col] != ' ' ||			// board space not empty
		row < 0 || row > 10 || col < 0 || col > 10 ||	// row or col out of bounds
		(row % 2) || (col % 2));			// row or col not even - is this needed?

	
}

int claim_box(char player, int row, int col, char unsigned board[][11])
{
	int boxCount=0;

	
	if (board[row - 2][col] == HORZ && board[row - 1][col - 1] == VERT && board[row - 1][col + 1] == VERT)
	{
		board[row - 1][col] = player;
		 boxCount++;
	}
	if (board[row + 2][col] == HORZ && board[row + 1][col - 1] == VERT && board[row + 1][col + 1] == VERT)
	{
		board[row + 1][col] = player;
		boxCount++;
	}
	if (board[row][col - 2] == VERT && board[row - 1][col - 1] == HORZ && board[row + 1][col - 1] == HORZ)
	{
		board[row][col - 1] = player;
		boxCount++;
	}
	if (board[row][col + 2] == VERT && board[row - 1][col + 1] == HORZ && board[row + 1][col + 1] == HORZ)
	{
		board[row][col + 1] = player;
		boxCount++;
	}

	return boxCount;
}
void check_winner(int countX, int countO)
{
	cout << "X's score: " << countX << endl;
	cout << "O's score: " << countO << endl;
	if (countX > countO)
	{
		cout << " X wins" << endl; 
	}
	else
	{
		cout << "O wins" << endl; 
	}
}