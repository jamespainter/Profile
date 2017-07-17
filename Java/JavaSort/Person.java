
public class Person implements Comparable<Person> 
{
	
	 private int id;
	 private String name;
	 private String street;
	 private String city;
	 private String state;
	 private String phoneNumber;
	
	 public Person(int num, String n, String s, String c, String st, String p)
	 {
		 id = num; 
		 name = n; 
		 street = s; 
		 city = c; 
		 state = st; 
		 phoneNumber = p; 
	 }
	 public Person(String n)// (initialize the name and sets the other values to null or 0 as appropriate)
	 {
		 name = n ; 
		 id = 0;
		 street = " "; 
		 city = " "; 
		 state = " "; 
		 phoneNumber = " "; 
		 
	 }
	 public Person(int n)// (initialize the id number and sets the other values to null)
	 {
		 name = " "; 
		 id = n;
		 street = " "; 
		 city = " "; 
		 state = " "; 
		 phoneNumber = " "; 
	 }
	 public String toString() //(which concatenates all Person instance variables)
	 {
		 return Integer.toString(id) + ", " + name + ", " + street + ", " + city + ", " + phoneNumber; 
	 }
	 public int getID() // (accessor method for the id instance variable)
	 {
		 return id; 
	 }
	 public int compareTo(Person person)
	 {
		 return name.compareTo(person.name);
	 }
}
