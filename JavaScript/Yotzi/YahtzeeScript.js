
	var  totNumOne =0; 
	var  totNumTwo =0; 
	var  totNumThree = 0; 
	var  totNumFour = 0;
	var  totNumFive = 0; 

	var  tot1NumOne =0; 
	var  tot1NumTwo =0; 
	var  tot1NumThree = 0; 
	var  tot1NumFour = 0;
	var  tot1NumFive = 0;

	var  tot2NumOne =0; 
	var  tot2NumTwo =0; 
	var  tot2NumThree = 0; 
	var  tot2NumFour = 0;
	var  tot2NumFive = 0;

	var  tot3NumOne =0; 
	var  tot3NumTwo =0; 
	var  tot3NumThree = 0; 
	var  tot3NumFour = 0;
	var  tot3NumFive = 0;

	var  tot4NumOne =0; 
	var  tot4NumTwo =0; 
	var  tot4NumThree = 0; 
	var  tot4NumFour = 0;
	var  tot4NumFive = 0;

	var dice1 = 0;
	var dice2 = 0;
	var dice3 = 0;
	var dice4 = 0;
	var dice5 = 0;

	var die1Pick = false;
	var die2Pick = false; 
	var die3Pick = false; 
	var die4Pick = false; 
	var die5Pick = false;  

	var rollcount = 0; 
	var diceList = new Array();
	var rollist = new Array();  
	var rollistCount = 0; 

function myFunction(dice1,dice2,dice3,dice4,dice5) {

    document.getElementById('number').innerHTML = dice1.toString()+" "+dice2.toString()+" "+dice3.toString()+" "+dice4.toString()+" "+dice5.toString();
}

function highestScore(dice1,dice2,dice3,dice4,dice5)
{
	

		switch(dice1)
		{
			case 1: 
				totNumOne += 1;
				break;
			case 2:
				totNumTwo += 1; 
				break;	
			case 3:
				totNumThree+=1;
				break;
			case 4: 
				totNumFour +=1;
				break;
			case 5:
				totNumFive +=1;
				break;
			case 6: 
				totNumSix +=1;
				break; 

		}
		myFunction(totNumOne, totNumTwo, totNumThree, totNumFour, totNumFive);
		switch(dice2)
		{
			case 1: 
				tot1NumOne += 1;
				break;
			case 2:
				tot1NumTwo += 1; 
				break;	
			case 3:
				tot1NumThree+=1;
				break;
			case 4: 
				tot1NumFour +=1;
				break;
			case 5:
				tot1NumFive +=1;
				break;
			case 6: 
				tot1NumSix +=1;
				break; 

		}
		switch(dice3)
		{
			case 1: 
				tot2NumOne += 1;
				break;
			case 2:
				tot2NumTwo += 1; 
				break;	
			case 3:
				tot2NumThree+=1;
				break;
			case 4: 
				tot2NumFour +=1;
				break;
			case 5:
				tot2NumFive +=1;
				break;
			case 6: 
				tot2NumSix +=1;
				break; 

		}
		switch(dice4)
		{
			case 1: 
				tot3NumOne += 1;
				break;
			case 2:
				tot3NumTwo += 1; 
				break;	
			case 3:
				tot3NumThree+=1;
				break;
			case 4: 
				tot3NumFour +=1;
				break;
			case 5:
				tot3NumFive +=1;
				break;
			case 6: 
				tot3NumSix +=1;
				break; 

		}
		switch(dice5)
		{
			case 1: 
				tot4NumOne += 1;
				break;
			case 2:
				tot4NumTwo += 1; 
				break;	
			case 3:
				tot4NumThree+=1;
				break;
			case 4: 
				tot4NumFour +=1;
				break;
			case 5:
				tot4NumFive +=1;
				break;
			case 6: 
				tot4NumSix +=1;
				break; 

		}

}
function randomPic()
{
	rollcount= rollcount+1; 
	
	if(!die1Pick)
	{
		
		dice1 = Math.ceil(Math.random() * (5+1));
		diceList[0]=dice1; 
		rollist[rollistCount]=dice1;
	}
	if(!die2Pick)
	{	rollistCount= rollistCount + 1;
		dice2 = Math.ceil(Math.random() * (5+1));
		diceList[1] = dice2;
		rollist[rollistCount]=dice2;
	}
	if(!die3Pick)
	{
		rollistCount= rollistCount + 1;
		dice3 = Math.ceil(Math.random() * (5+1));
		diceList[2] = dice3; 
		rollist[rollistCount]=dice3;
	}
	if(!die4Pick)
	{
		rollistCount= rollistCount + 1;
		dice4 = Math.ceil(Math.random() * (5+1));
		diceList[3] = dice4; 
		rollist[rollistCount]=dice4;
	}
	if(!die5Pick)
	{
		rollistCount= rollistCount + 1;
		dice5 = Math.ceil(Math.random() * (5+1));
		diceList[4] = dice5; 
		rollist[rollistCount]=dice5;
	}

	setUpperSection();
	if(rollcount==3)
  	{
  	
		// var threeOfKind = checkThreeOfKind(diceList);
		// var fourOfKind  = checkFourOfKind(diceList);
		

		 
		rollcount = 0;
		reset(); 
		 
	 	

	
  	}
  	else
  	{
	  	document.getElementById('diceImage').src='./images/die'+dice1+'.gif';	
	  	document.getElementById('diceImage2').src='./images/die'+dice2+'.gif';
	  	document.getElementById('diceImage3').src='./images/die'+dice3+'.gif';	
	  	document.getElementById('diceImage4').src='./images/die'+dice4+'.gif';
	  	document.getElementById('diceImage5').src='./images/die'+dice5+'.gif';	
	  	
  	}
	// highestScore(dice1,dice2,dice3,dice4,dice5);
	// myFunction(random);
	

  	

}
function setUpperSection()
{




		document.getElementById('t2col2Row1').innerHTML = countOnes(rollist).toString(); 
		document.getElementById('t2col2Row2').innerHTML = countTwos(rollist).toString(); 
		document.getElementById('t2col2Row3').innerHTML = countThrees(rollist).toString(); 
		document.getElementById('t2col2Row4').innerHTML = countFours(rollist).toString(); 
		document.getElementById('t2col2Row5').innerHTML = countFives(rollist).toString(); 
		document.getElementById('t2col2Row6').innerHTML = countSixes(rollist).toString(); 



} 
function reset()
{
		die1Pick = false;
		die2Pick = false; 
		die3Pick = false; 
		die4Pick = false; 
		die5Pick = false; 

		rollistCount = 0;
		var zero = 0;
		//rollistCount = 0;
		 document.getElementById('col2Row1').innerHTML= zero.toString();
		 document.getElementById('col2Row2').innerHTML = zero.toString();
		 document.getElementById('col2Row3').innerHTML = zero.toString();
		 document.getElementById('col2Row4').innerHTML = zero.toString();
		 document.getElementById('col2Row5').innerHTML = zero.toString();

		//document.getElementById('t2col2Row1').innerHTML = zero.toString(); 
		//document.getElementById('t2col2Row2').innerHTML = zero.toString(); 
		// document.getElementById('t2col2Row3').innerHTML = zero.toString(); 
		// document.getElementById('t2col2Row4').innerHTML = zero.toString(); 
		// document.getElementById('t2col2Row5').innerHTML = zero.toString(); 
		// document.getElementById('t2col2Row6').innerHTML = zero.toString();

		 for (var i = 0; i < rollist.length; i++) {

		 		rollist[i] = 0;			
		 }
		for (var i = 0; i < diceList.length; i++) {

				diceList[i] = 0;			
		}
}

function countOnes(rollist)
{
	var i = 0; 
	var countOne =0; 
	while(i < rollist.length) {
		i = i +1;
		if(rollist[i] ===  1)
		{
			countOne = countOne + 1; 
		}
	}
	return countOne; 
}
function countTwos(rollist)
{

	var countTwo = 0; 
	var i =0; 

	while(i < rollist.length) {
		i++;
	
		if(rollist[i] === 2)
		{
			countTwo++; 
		}
		
	}
	return countTwo;
}
function countThrees(rollist)
{

	var countThree = 0; 
	

	for (var i = 0; i < rollist.length; i++) {
	
		if(rollist[i] === 2)
		{
			countThree++; 
		}
		
	}
	return countThree;
}
function countFours(rollist)
{

	var countFour = 0; 
	

	for (var i = 0; i < rollist.length; i++) {
	
		if(rollist[i] === 2)
		{
			countFour++; 
		}
		
	}
	return countFour;
}
function countFives(rollist)
{

	var countFive = 0; 
	

	for (var i = 0; i < rollist.length; i++) {
	
		if(rollist[i] === 2)
		{
			countFive++; 
		}
		
	}
	return countFive;
}
function countSixes(rollist)
{

	var countSix = 0; 
	

	for (var i = 0; i < rollist.length; i++) {
	
		if(rollist[i] === 2)
		{
			countSix++; 
		}
		
	}
	return countSix;
}



function checkThreeOfKind(diceList)
{
	var countOne = 0; 
	var countTwo = 0; 
	var countThree = 0; 
	var countFour = 0; 
	var countFive = 0; 
	var countSix = 0; 
	for (var i = 0; i < diceList.length; i++) {
		if(diceList[i] ==  1)
		{
			countOne++; 
		}
		if(diceList[i] === 2)
		{
			countTwo++; 
		}
		if(diceList[i] ===  3)
		{
			countThree++; 
		}
		if(diceList[i] ===  4)
		{
			countFour++; 
		}
		if(diceList[i] === 5)
		{
			countOne++; 
		}
		if(diceList[i] ===  6)
		{
			countSix++; 
		}
	}
	if(countOne === 3)
	{
		return true; 
	}
	else if(countTwo === 3)
	{
		return true; 
	}
	else if (countThree === 3)
	{
		return true; 
	}
	else if (countFour === 3)
	{
		return true; 
	}
	else if (countFive === 3)
	{
		return true; 
	}
	else if (countSix === 3)
	{
		return true; 
	}
	else
	{
		return false; 
	}

}
function checkFourOfKind(diceList)
{
	var countOne = 0; 
	var countTwo = 0; 
	var countThree = 0; 
	var countFour = 0; 
	var countFive = 0; 
	var countSix = 0; 
	for (var i = 0; i < diceList.length; i++) {
		if(diceList[i] ===  1)
		{
			countOne++; 
		}
		if(diceList[i] === 2)
		{
			countTwo++; 
		}
		if(diceList[i] ===  3)
		{
			countThree++; 
		}
		if(diceList[i] ===  4)
		{
			countFour++; 
		}
		if(diceList[i] ===  5)
		{
			countOne++; 
		}
		if(diceList[i] ===  6)
		{
			countSix++; 
		}
	}
	if(countOne === 4)
	{
		return true; 
	}
	else if(countTwo === 4)
	{
		return true; 
	}
	else if (countThree === 4)
	{
		return true; 
	}
	else if (countFour === 4)
	{
		return true; 
	}
	else if (countFive === 4)
	{
		return true; 
	}
	else if (countSix === 4)
	{
		return true; 
	}
	else
	{
		return false; 
	}

}

function saveDie1()
{
	 die1Pick=true; 
	 document.getElementById('col2Row1').innerHTML = dice1.toString(); 

}
function saveDie2()
{
	 die2Pick=true; 
	 document.getElementById('col2Row2').innerHTML = dice2.toString(); 

}
function saveDie3()
{
	 die3Pick=true; 
	 document.getElementById('col2Row3').innerHTML = dice3.toString(); 

}
function saveDie4()
{
	 die4Pick=true; 
	 document.getElementById('col2Row4').innerHTML = dice4.toString(); 

}
function saveDie5()
{
	 die5Pick=true; 
	 document.getElementById('col2Row5').innerHTML = dice5.toString(); 

}
