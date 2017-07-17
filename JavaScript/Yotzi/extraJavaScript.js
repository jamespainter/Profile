
	var checkfor4Twos = checkFourOfKindTwos();
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 1" && checkfor4Twos == true)
	{	
			checkforPlayer1Count++;
			
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			//set 3 of kind colum in table 3
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			//pass in point for 3 of a kind
			var totalplayer1Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer1(totalplayer1Points); 
			
			//Clear count
			checkforPlayer1Count = 0; 
	}
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 2" && checkfor3Twos == true)
	{
			checkforPlayer2Count++;
			//myFunction("true"); 
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			
			var totalplayer2Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer2(totalplayer2Points);
			
			checkforPlayer2Count = 0;
		//myFunction("false");
		//alert("False");
	}

	var checkfor4Threes = checkFourOfKindThrees();
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 1" && checkfor4Threes == true)
	{	
			checkforPlayer1Count++;
			
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			//set 3 of kind colum in table 3
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			//pass in point for 3 of a kind
			var totalplayer1Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer1(totalplayer1Points); 
			
			//Clear count
			checkforPlayer1Count = 0; 
	}
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 2" && checkfor4Threes == true)
	{
			checkforPlayer2Count++;
			//myFunction("true"); 
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			
			var totalplayer2Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer2(totalplayer2Points);
			
			checkforPlayer2Count = 0;
		//myFunction("false");
		//alert("False");
	}


	var checkfor4Fours = checkFourOfKindFours();
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 1" && checkfor4Fours == true)
	{	
			checkforPlayer1Count++;
			
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			//set 3 of kind colum in table 3
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			//pass in point for 3 of a kind
			var totalplayer1Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer1(totalplayer1Points); 
			
			//Clear count
			checkforPlayer1Count = 0; 
	}
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 2" && checkfor4Fours == true)
	{
			checkforPlayer2Count++;
			//myFunction("true"); 
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			
			var totalplayer2Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer2(totalplayer2Points);
			
			checkforPlayer2Count = 0;
		//myFunction("false");
		//alert("False");
	}


	var checkfor4Fives = checkFourOfKindFives();
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 1" && checkfor4Fives == true)
	{	
			checkforPlayer1Count++;
			
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			//set 3 of kind colum in table 3
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			//pass in point for 3 of a kind
			var totalplayer1Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer1(totalplayer1Points); 
			
			//Clear count
			checkforPlayer1Count = 0; 
	}
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 2" && checkfor4Fives == true)
	{
			checkforPlayer2Count++;
			//myFunction("true"); 
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			
			var totalplayer2Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer2(totalplayer2Points);
			
			checkforPlayer2Count = 0;
		//myFunction("false");
		//alert("False");
	}

/*************************************************************************************************************/
	var checkfor4Sixes = checkFourOfKindSixes();
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 1" && checkfor4Sixes == true)
	{	
			checkforPlayer1Count++;
			
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			//set 3 of kind colum in table 3
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			//pass in point for 3 of a kind
			var totalplayer1Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer1(totalplayer1Points); 
			
			//Clear count
			checkforPlayer1Count = 0; 
	}
	if(document.getElementById('userLabel').innerHTML.toString() == "Player 2" && checkfor4Sixes == true)
	{
			checkforPlayer2Count++;
			//myFunction("true"); 
			var totalPointOfDice = 0; 
			var i; 
			for(i = 0; i < diceList.length; i++)
			{
				totalPointOfDice += diceList[i];
			}
			document.getElementById('t3col2Row2').innerHTML = totalPointOfDice.toString(); 
			
			var totalplayer2Points = parseInt(document.getElementById('t3col2Row2').innerHTML);
			addToPlayer2(totalplayer2Points);
			
			checkforPlayer2Count = 0;
		//myFunction("false");
		//alert("False");
	}





/*******************************************************************************/



function checkThreeOfKindOnes()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  1)
		{
			countOne++; 
		}

	}
	if(countOne === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkThreeOfKindTwos()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  2)
		{
			countOne++; 
		}

	}
	if(countOne === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkThreeOfKindThrees()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  3)
		{
			countOne++; 
		}

	}
	if(countOne === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkThreeOfKindFours()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  4)
		{
			countOne++; 
		}

	}
	if(countOne === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkThreeOfKindFives()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  5)
		{
			countOne++; 
		}

	}
	if(countOne === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkThreeOfKindSixes()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  6)
		{
			countOne++; 
		}

	}
	if(countOne === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkFourOfKindOnes()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  1)
		{
			countOne++; 
		}

	}
	if(countOne === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkFourOfKindTwos()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  2)
		{
			countOne++; 
		}

	}
	if(countOne === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkFourOfKindThrees()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  3)
		{
			countOne++; 
		}

	}
	if(countOne === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkFourOfKindFours()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  4)
		{
			countOne++; 
		}

	}
	if(countOne === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkFourOfKindFives()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  5)
		{
			countOne++; 
		}

	}
	if(countOne === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}
function checkFourOfKindSixes()
{
	var countOne = 0; 
	var i; 
	for (i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  6)
		{
			countOne++; 
		}

	}
	if(countOne === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}
}