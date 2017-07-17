import java.awt.*;
import java.awt.event.*;
import javax.swing.*;



public class Tile extends JPanel { // could use abstract
	
	//private ImageIcon image;
	
	public Tile()
	{
		this.setPreferredSize(new Dimension(this.getWidth()+300,this.getHeight()+300));
		
	}
	public void paintComponent(Graphics g)
	{
	 	super.paintComponent(g);
	 	//setSize(200, 200);
	 	//g.drawRect(50,50, 200, 200);
	 	
	 	//g.drawLine(1, 1, 50, 50);
	 	Graphics2D	g2 = (Graphics2D)g;
	 	Color yellow = Color.decode("#e5e2ca");
	 	Color green = Color.decode("#00CD00");
	 	
		GradientPaint	grad = new GradientPaint(50, 50, Color.WHITE, 250, 250, yellow);
		g2.setPaint(grad);
		g.fillRect(50, 50, 200, 200);
	
		
//			 	GradientPaint	grad0 = new GradientPaint(150, 50, Color.white, 150, 150, Color.CYAN);
		//Polygon		p0 = new Polygon();
		int[] xPoints = {50, 50, 30, 30}; 
		int[] yPoints = {50, 250, 270, 70};
		int numPoints = 4; 
		g2.setPaint(yellow);
		g2.fillPolygon(xPoints,yPoints, numPoints);
		g.setColor(Color.BLACK);
		g.drawPolygon(xPoints,yPoints, numPoints);
		
		//Polygon		p1 = new Polygon();
		int[] x1Points = {30, 30, 11, 11}; 
		int[] y1Points = {70, 270, 290, 90};
		int numPoints1 = 4; 
		g2.setPaint(green);
		g2.fillPolygon(x1Points,y1Points, numPoints1);
		g.setColor(Color.BLACK);
		g.drawPolygon(x1Points,y1Points, numPoints1);
		
		
		//Polygon		p2 = new Polygon();
		int[] x2Points = {50, 250, 232, 30}; 
		int[] y2Points = {250, 250, 270, 270};
		int numPoints2 = 4; 
		g2.setPaint(yellow);
		g2.fillPolygon(x2Points,y2Points, numPoints2);
		g.setColor(Color.BLACK);
		g.drawPolygon(x2Points,y2Points, numPoints2);
		
		
		//Polygon		p3 = new Polygon();
		int[] x3Points = {30, 232, 215, 11}; 
		int[] y3Points = {270, 270, 290, 290};
		int numPoints3 = 4; 
		g2.setPaint(green);
		g2.fillPolygon(x3Points,y3Points, numPoints3);
		g.setColor(Color.BLACK);
		g.drawPolygon(x3Points,y3Points, numPoints3);
		
		g.setColor(Color.BLACK);
		g.drawRect(50,50, 200, 200);
	}
	 
	
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
	
//	public Tile()
//	{
//		// inside JPanel, setPreferredSize(). 
//		// fits the picture
//	    // Rule of thumb
//		// creating an outside container(not inside of anything else)-setSize(),
//		//if it is inside a container use JPanel setPreferredSize()
//		 
//		setPreferredSize(new Dimension(image.getIconWidth(),image.getIconHeight()+25));
//		//	image.getIconHeight()
//	
//	
//	}
	
	public static void main(String[] args)
	{
		
		
		JFrame frame = new JFrame(); 
		frame.setLayout(new FlowLayout());
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle("Tile");
		frame.add(new Tile());
		frame.pack(); 
		frame.setVisible(true); 
		
		
	}
}
