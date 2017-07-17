//Copyright 2015, Bradley Peterson, Weber State University, all rights reserved.

#include <iostream>
#include <string>
#include <stack>
#include <sstream>
#include <algorithm> 
#include <functional> 
#include <cctype>
#include <locale>
#include <cstring>


using namespace std;

bool isOperator(char oper){
	if ((oper == '+') || (oper == '-') || (oper == '*') || (oper == '/') || (oper == '^'))
	{
		return true;
	}
	else
		return false; 
	
}
bool isRP(char rParen){
	if (rParen == ')')
	{
		return true;
	}
	else
		return false; 
}
bool isLP(char lParen)
{
	if (lParen == '(')
	{
		return true;
	}
	else
		return false; 
}
bool isDigit(char digit)
{
	if ((digit == '0') || (digit == '1') || (digit == '2') || (digit == '3') || (digit == '4') || (digit == '5') || (digit == '6') || (digit == '7') || (digit == '8') || (digit == '9'))
	{
		return true;
	}
	else
		return false;
	
}
bool greaterOrEqualPrecedence(const char* oper1, const char* oper2)
{

	if (*oper2 >= *oper1) //(*oper2 == '*') || (*oper2 == '/') || (*oper2 == '^')
	{
		return true;
	}
	else  //(*oper2 == '+') || (*oper2 == '-')
		return false; 
}

string convertToPfx(const string& infx) {
	string pfx = "";
	stack<string> s;
	string sym = "";
	string oper = ""; 
	int position = 0;
	int exitwhile; 
	
	while (position < infx.size()) 
	{
		/*while (position < infx.size() && isDigit(infx.at(position))) {
		}*/
			//sym = infx.at(position);
		//cout << sym << endl;
			if ((isLP(infx.at(position))))
			{
			sym = infx.at(position);
			s.push(sym);

			
			}
			if (isDigit(infx.at(position)))
			{
				sym = infx.at(position);
				if (position + 1 < infx.size())
				{
					if (isDigit(infx.at(position + 1)))
						pfx += sym;
					else
						pfx += sym + " ";
				}
				else
					pfx += sym + " ";
			}
							
				

			if (isOperator(infx.at(position)))
			{
				sym = infx.at(position);

				if (s.size() > 0 )
				{

					const char* oper1;
					const char* oper2;
					while (s.size() > 0 )
					{
						oper1 = sym.c_str();
						oper2 = s.top().c_str();
						
						
						if ((s.top() == "(") )
						{
							
							break;
						}
						else if (greaterOrEqualPrecedence(oper1, oper2))
						{
							
								pfx += s.top() + " ";
								s.pop();
							
						}
						else
						{
							
							break;
						}
						
						 
					}
					

				}
				
				s.push(sym);
				
				
				//position++;
			}
			
			if ((isRP(infx.at(position))))
			{ 
				//s.pop();
				while (s.size() > 0)
				{
					
					 

					if ((s.top() == "("))
					{
						s.pop();
						break;
					}
					else
					{
						pfx += s.top() + " ";
						s.pop();
						
					}
					

				}

				//position++;
			}
			position++;
			/*sym = infx.at(position);*/
		
	}

	while (s.size() > 0)
	{
		pfx += s.top() + " ";
		s.pop();										
	}

	return pfx;
}




//This helps with testing, do not modify.
bool checkTest(string testName, string whatItShouldBe, string whatItIs) {

	//get rid of spaces
	whatItIs.erase(whatItIs.begin(), std::find_if(whatItIs.begin(), whatItIs.end(), std::not1(std::ptr_fun<int, int>(std::isspace))));
	whatItIs.erase(std::find_if(whatItIs.rbegin(), whatItIs.rend(), std::not1(std::ptr_fun<int, int>(std::isspace))).base(), whatItIs.end());

	if (whatItShouldBe == whatItIs) {
		cout << "Passed test " << testName << " ***  Output was \"" << whatItIs << "\"" << endl;
		return true;
	}
	else {
		if (whatItShouldBe == "") {
			cout << "***Failed test " << testName << " *** " << endl << "   Output was \"" << whatItIs << "\"" << endl << "  Output should have been blank. " << endl;
		}
		else {
			cout << "***Failed test " << testName << " *** " << endl << "   Output was \"" << whatItIs << "\"" << endl << "  Output should have been \"" << whatItShouldBe << "\"" << endl;
		}
		return false;
	}
}

int main() {

	string expression = "(2+3)";
	string result = convertToPfx(expression);
	checkTest("Test #1", "2 3 +", result);

	expression = "2+3";
	result = convertToPfx(expression);
	checkTest("Test #2", "2 3 +", result);

	expression = "(123+456)";
	result = convertToPfx(expression);
	checkTest("Test #3", "123 456 +", result);

	expression = "(8-5)";
	result = convertToPfx(expression);
	checkTest("Test #4", "8 5 -", result);

	expression = "((3-4)-5)";
	result = convertToPfx(expression);
	checkTest("Test #5", "3 4 - 5 -", result);

	expression = "(3 - (4 - 5))";
	result = convertToPfx(expression);
	checkTest("Test #6", "3 4 5 - -", result);

	expression = "(3*(8/2))";
	result = convertToPfx(expression);
	checkTest("Test #7", "3 8 2 / *", result);

	expression = "3 + 8 / 2";
	result = convertToPfx(expression);
	checkTest("Test #8", "3 8 2 / +", result);

	expression = "24 / 3 + 2";
	result = convertToPfx(expression);
	checkTest("Test #9", "24 3 / 2 +", result);

	expression = "((1 + 2) * (3 + 4))";
	result = convertToPfx(expression);
	checkTest("Test #10", "1 2 + 3 4 + *", result);

	expression = "2^3";
	result = convertToPfx(expression);
	checkTest("Test #11", "2 3 ^", result);

	expression = "8 + 3^4";
	result = convertToPfx(expression);
	checkTest("Test #12", "8 3 4 ^ +", result);

	expression = "(((3+12)-7)*120)/(2+3)";
	result = convertToPfx(expression);
	checkTest("Test #13", "3 12 + 7 - 120 * 2 3 + /", result);

	expression = "((((9+(2*(110-(20/2))))*8)+1000)/2)-((400*2500)-1000001)";
	result = convertToPfx(expression);
	checkTest("Test #14", "9 2 110 20 2 / - * + 8 * 1000 + 2 / 400 2500 * 1000001 - -", result);



	system("pause");
	return 0;
}