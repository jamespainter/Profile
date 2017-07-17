import java.util.Comparator;
public class CompareInt implements Comparator<Person>
{
	public int compare(Person p1, Person p2)
	{
		int id1 = p1.getID();
		int id2 = p2.getID(); 
		
		if(id1 > id2)
		{
			return 1; 
		}
		else if(id1 < id2){
			return -1;
		}
		return 0;  
	}
}
