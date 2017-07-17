
abstract public class Tile {
	public boolean matches(Tile other)
	{
		// a quick test to see if the objects are identical
	      if (this == other) return true;

	      // must return false if the explicit parameter is null
	      if (other == null) return false;

	      // if the classes don't match, they can't be equal
	      //if (getClass() != other.getClass())
	      
	     
	      return getClass().equals(other.getClass());
	}
	
}
