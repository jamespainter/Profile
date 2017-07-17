
abstract public class RankTile extends Tile{
	protected int rank;
	
	public RankTile(int rank)
	{
		this.rank = rank; 
	}
	public boolean matches(Tile other)
	{
		RankTile r = (RankTile)other;
		 if(super.matches(other) && r.rank == rank)
		 { 
			 return true; 
		 }
		 else
			 return false;
		 
		 
	}
	
}
