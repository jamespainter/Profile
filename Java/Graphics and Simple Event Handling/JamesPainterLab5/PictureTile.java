import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public abstract class PictureTile extends Tile {
	private String name;
	private Image image; //swing set
	public PictureTile(String name)
	{
		this.name = name; 
		setToolTipText(toString());
		
	}
	 public void paintComponent(Graphics g)
	 {
		 super.paintComponent(g);
		 Graphics2D g2 = (Graphics2D)g;
		 Dimension D = new Dimension(); 
		  
		 
		 switch(this.name)
			{
		 
				case "Chrysanthemum": 
					
					image = Toolkit.getDefaultToolkit().getImage("images/Chrysanthemum.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					
					break;
				case "Orchid":
					image = Toolkit.getDefaultToolkit().getImage("images/Orchid.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					
					break;
				case "Plum": 
					image = Toolkit.getDefaultToolkit().getImage("images/Plum.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					break;
				case "Bamboo":
					image = Toolkit.getDefaultToolkit().getImage("images/Bamboo.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					break;
				case "Spring":
					image = Toolkit.getDefaultToolkit().getImage("images/Spring.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					break;
				case "Summer":  
					image = Toolkit.getDefaultToolkit().getImage("images/Summer.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					break;
				case "Fall":  
					image = Toolkit.getDefaultToolkit().getImage("images/Fall.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					break;
				case "Winter":
					image = Toolkit.getDefaultToolkit().getImage("images/Winter.png");
					g.drawImage(image, 70, 80, 140, 140, this);
				break;
				default:
					image = Toolkit.getDefaultToolkit().getImage("images/Sparrow.png");
					g.drawImage(image, 70, 80, 140, 140, this);
					break;
			
			}
	 }
	public String toString()
	{
		switch(this.name)
		{
			case "Chrysanthemum":  return "Chrysanthemum";
			case "Orchid":  return "Orchid";
			case "Plum":  return "Plum";
			case "Bamboo":  return "Bamboo";
			case "Spring":  return "Spring";
			case "Summer":  return "Summer";
			case "Fall":  return "Fall";
			case "Winter":  return "Winter";
			default: return "Invalid name";
		
		}
	}
	public static void main(String[] args)
	{
		JFrame	frame = new JFrame();

		frame.setLayout(new FlowLayout());
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("Picture Tiles");

		frame.add(new Bamboo1Tile());

		frame.add(new FlowerTile("Chrysanthemum"));
		frame.add(new FlowerTile("Orchid"));
		frame.add(new FlowerTile("Plum"));
		frame.add(new FlowerTile("Bamboo"));

		frame.add(new SeasonTile("Spring"));
		frame.add(new SeasonTile("Summer"));
		frame.add(new SeasonTile("Fall"));
		frame.add(new SeasonTile("Winter"));

		frame.pack();
		frame.setVisible(true);
	}
}
