
public class CharacterTile extends Tile {
	private char symbol; 
	
	public CharacterTile(char symbol)
	{
		this.symbol = symbol; 
	}
	public boolean matches(Tile other)
	{
		CharacterTile sym = (CharacterTile)other;
		if(super.matches(other) && symbol == sym.symbol)
		{
		  return true; 
		}
		else 
			return false; 
		 
	}
	public String toString()
	{
		switch(this.symbol)
		{
			case '1':  return "Character " + this.symbol;
			case '2':  return "Character " + this.symbol;
			case '3':  return "Character " + this.symbol;
			case '4':  return "Character " + this.symbol;
			case '5':  return "Character " + this.symbol;
			case '6':  return "Character " + this.symbol;
			case '7':  return "Character " + this.symbol;
			case '8':  return "Character " + this.symbol;
			case '9':  return "Character " + this.symbol;
			case 'N':  return "North Wind";
			case 'E':  return "East Wind";
			case 'W':  return "West Wind";
			case 'S':  return "South Wind";
			case 'C':  return "Red Dragon";
			case 'F':  return "Green Dragon";
			default: return "Invalid rank";
		
		}
	}
	

}
