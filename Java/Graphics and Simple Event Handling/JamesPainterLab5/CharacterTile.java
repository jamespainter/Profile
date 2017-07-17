import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.font.*; 

public class CharacterTile extends Tile {
	private char symbol; 
	
	public CharacterTile(char symbol)
	{
		this.symbol = symbol; 
		setToolTipText(toString());
	}
	
	
	public void paintComponent(Graphics g)
	{
	 	super.paintComponent(g);
	 	//Character.toString('\u767C');
	 	//g.drawString("\u842C", 230, 80);
	 	//this.setFont(this.getFont().deriveFont(10.0f)); 
	 	switch(this.symbol)
		{
			case '1':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("1", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u4E00'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break; 
			case '2':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("2", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u4E8C'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '3': 
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("3", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u4E09'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '4':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("4", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u56DB'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '5':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("5", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u4E94'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '6': 
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("6", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u516D'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '7':  
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("7", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u4E03'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '8':  
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("8", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u516B'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case '9':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("9", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u4E5D'), 115, 125);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(80.0f));
					g.drawString(Character.toString('\u842C'), 115, 210);
				break;
			case 'N':  
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("N", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(100.0f));
					g.drawString(Character.toString('\u5317'), 105, 180);
				break;
			case 'E':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("E", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(100.0f));
					g.drawString(Character.toString('\u6771'), 105, 180);
				break;
			case 'W':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("W", 195, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(100.0f));
					g.drawString(Character.toString('\u897F'), 105, 180);
				break;
			case 'S':
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("W", 210, 90);
					g.setColor(Color.BLACK);
					g.setFont(this.getFont().deriveFont(100.0f));
					g.drawString(Character.toString('\u5357'), 105, 180);
				break;
			case 'C': 
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("C", 210, 90);
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(100.0f));
					g.drawString(Character.toString('\u4E2D'), 105, 180);
				break;
			case 'F': 
					g.setColor(Color.RED);
					g.setFont(this.getFont().deriveFont(35.0f));
					g.drawString("F", 210, 90);
					g.setColor(Color.GREEN);
					g.setFont(this.getFont().deriveFont(100.0f));
					g.drawString(Character.toString('\u767C'), 105, 180);
				break;
			default: //return "Invalid rank";
					g.setColor(Color.BLACK);
					g.drawString("Invalid rank", 105, 180);
				break;
		
		}
	 	
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
	
	public static void main(String[] args)
	{
		JFrame		frame = new JFrame();
		JPanel		tiles = new JPanel();
		JScrollPane	scroller = new JScrollPane(tiles);

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("Character Tiles");
		frame.add(scroller);

		// Try something like this if your tiles don't fit on the screen.
		// Replace "tile width" and "tile height" with your values.
		//scroller.setPreferredSize(new Dimension(8 * tile width, 40 + tile height));

		tiles.add(new CharacterTile('1'));
		tiles.add(new CharacterTile('2'));
		tiles.add(new CharacterTile('3'));
		tiles.add(new CharacterTile('4'));
		tiles.add(new CharacterTile('5'));
		tiles.add(new CharacterTile('6'));
		tiles.add(new CharacterTile('7'));
		tiles.add(new CharacterTile('8'));
		tiles.add(new CharacterTile('9'));
		tiles.add(new CharacterTile('N'));
		tiles.add(new CharacterTile('E'));
		tiles.add(new CharacterTile('W'));
		tiles.add(new CharacterTile('S'));
		tiles.add(new CharacterTile('C'));
		tiles.add(new CharacterTile('F'));

		frame.pack();
		frame.setVisible(true);
	}
}
